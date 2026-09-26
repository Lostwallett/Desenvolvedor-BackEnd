using SistemaERP.Classes.Contextos;

namespace SistemaERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Application.Run(new Login());             


            //ContextoUltimoUsuario usuario = new ContextoUltimoUsuario();
            //usuario.Database.EnsureCreated();

            ContextoPessoa pessoa = new ContextoPessoa();
            pessoa.Database.EnsureCreated();

             if (TestarConexaoBanco())
             {
                 MessageBox.Show("Conexão realizada com sucesso!");
                 Application.Run(new Login());
             }
             else
             {
                 MessageBox.Show("Falha ao conectar ao banco de dados!");
             }
         }
         private static bool TestarConexaoBanco()
         {
             try
             {
                 ContextoPessoa contexto = new ContextoPessoa();
                 return contexto.Database.CanConnect();
             }
             catch (Exception e)
             {
                 MessageBox.Show($"Erro ao conectar ao banco de dados: {e.Message}");
                 return false;
             }
        }
    }
}