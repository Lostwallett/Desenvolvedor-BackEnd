using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UltimaAula.Models.Entidades;

namespace UltimaAula.Servicos
{
    public class JwtTokenService
    {
        //Campos
        string chavesecreta;
        JwtSecurityTokenHandler manipuladorToken;
        TokenValidationParameters validarToken;
        Claim[] claims;
        SymmetricSecurityKey chave;
        SigningCredentials credenciais;
        JwtSecurityToken token;

        //Construtor
        public JwtTokenService(string chavesecreta)
        {
            this.chavesecreta = chavesecreta;
        }

        //Métodos
        public string GerarToken(Usuario usuario)
        {
            claims = new[]
            {
                new Claim(ClaimTypes.Name, usuario.Nome),
                new Claim(ClaimTypes.Role, usuario.Regra)
            };

            chave = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(chavesecreta));
            credenciais = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);

            token = new JwtSecurityToken(
                issuer: "LojaVirtual",
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credenciais
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public string ValidarToken(string token)
        {
            try
            {
                //Valida o token
                var chave = Encoding.UTF8.GetBytes(chavesecreta);
                manipuladorToken = new JwtSecurityTokenHandler();
                validarToken = new TokenValidationParameters
                {
                    IssuerSigningKey = new SymmetricSecurityKey(chave),
                    ValidateIssuerSigningKey = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuer = true,
                    ValidIssuer = "LojaVirtual",
                    ValidateAudience = false,
                    ValidateLifetime = true
                };

                return manipuladorToken.ValidateToken(token, validarToken, out SecurityToken validatedToken).Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)!.Value;
                
            }
            catch (Exception e)
            {
                return "Erro: " + e.Message;    
            }
        }
    }
}