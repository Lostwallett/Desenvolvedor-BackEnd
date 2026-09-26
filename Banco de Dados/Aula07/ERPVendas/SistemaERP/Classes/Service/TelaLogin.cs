namespace SistemaERP.Classes.Service
{
    internal static class TelaLogin
    {
        //Campo
        static Login login;

        //Método
        public static void AbrirTelaLogin()
        {
            login = new Login();
            login.Show();
        }
    }
}