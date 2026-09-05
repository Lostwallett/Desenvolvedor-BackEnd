using CasasBahia2.Classes.Entidades;
using CasasBahia2.Classes.Contextos;

namespace CasasBahia2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Tab1 - Botão para cadastrar item
        private void button1_Click(object sender, EventArgs e)
        {
            ProdutosContexto contexto = new ProdutosContexto();
            string cadastroNomeProduto = textBox1.Text;
            int quantidadeDoProduto = int.Parse(textBox2.Text);
            decimal valorDoProduto = decimal.Parse(textBox3.Text);

            Produtos produtos = new Produtos(cadastroNomeProduto, quantidadeDoProduto, valorDoProduto);
            contexto.Produtos.Add(produtos);
            contexto.SaveChanges();
            MessageBox.Show("Produto cadastrado com sucesso!");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        // Tab2 - Botão para consultar item
        private void button2_Click(object sender, EventArgs e)
        {
            ProdutosContexto contexto = new ProdutosContexto();
            var produto = contexto.Produtos.FirstOrDefault(p => p.CodigoDoProduto == int.Parse(textBox4.Text));
            if (produto == null)
            {
                MessageBox.Show("Produto não cadastrado!");
            }
            else
            {
                MessageBox.Show("Produto encontrado!\n" +
                    $"Nome do produto: {produto.NomeDoProduto}\n" +
                    $"Quantidade do produto: {produto.QuantidadeDoProduto}\n" +
                    $"Valor do produto: {produto.ValorDoProduto}");
            }
            textBox4.Text = "";
        }

        // Tab3 - Botão para editar/pesquisar item
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
