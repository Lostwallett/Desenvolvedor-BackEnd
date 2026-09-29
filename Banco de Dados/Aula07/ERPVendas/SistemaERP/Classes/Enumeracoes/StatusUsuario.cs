using System.ComponentModel;

namespace SistemaERP.Classes.Enumeracoes
{
    internal enum StatusUsuario
    {
        [Description("Aguardando aprovação...")]
        Aguardando = 0,
        [Description("Usuário aprovado!")]
        Aprovado = 1,
        [Description("Usuário reprovado!")]
        Reprovado = 2
    }
}
