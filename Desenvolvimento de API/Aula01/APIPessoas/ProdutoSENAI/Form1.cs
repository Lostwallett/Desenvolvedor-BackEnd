using System.Net.Http.Json;

namespace ProdutoSENAI
{
    public partial class Form1 : Form
    {
        private readonly HttpClient clienteHttp = new()
        {
            BaseAddress = new Uri("http://localhost:5194")
        };
        public Form1()
        {
            InitializeComponent();
        }

        //Botão criar
        private void button1_Click(object sender, EventArgs e)
        {
            string mensagem;
            mensagem = clienteHttp.GetStringAsync("Produtos").Result;
            MessageBox.Show(mensagem);
        }
    }
}
