using System.ComponentModel;

namespace SistemaERP.Classes.Enumeracoes
{
    internal enum StatusUsuario
    {
        [Description("Aguardando aprovação...")]
        Aguardando,
        [Description("Usuário aprovado!")]
        Aprovado,
        [Description("Usuário reprovado!")]
        Reprovado
    }
}
