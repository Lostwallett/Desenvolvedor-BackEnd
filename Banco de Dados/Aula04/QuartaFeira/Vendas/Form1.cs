using VendasSENAI.Classes.Contextos;

namespace VendasSENAI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CarregarDados();
        }
        void CarregarDados()
        {
            try
            {
                VendasSENAIContexto vendasContexto = new VendasSENAIContexto();
                var listaDeVendas = vendasContexto.vendas.ToList();
                dataGridView1.DataSource = listaDeVendas;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}