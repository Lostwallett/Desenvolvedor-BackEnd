using Banco;

namespace Master
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Declaração de variáveis
        string nome, temp;
        int numero;
        double saldo;
        ContaBancaria conta1;
        bool erro = false;

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                nome = textBox1.Text;
                numero = int.Parse(textBox2.Text);
                if (textBox3.Text == "")
                {
                    saldo = 0;
                }
                else
                {
                    saldo = double.Parse(textBox3.Text);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
                erro = true;
            }

            if (!erro)
            {
                if (saldo > 0 )
                {
                    conta1 = new ContaBancaria(nome, numero);
                }
                else 
                {
                    conta1 = new ContaBancaria(nome, numero, saldo);
                }                
                MessageBox.Show(conta1.ExibirDados());
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Enabled = checkBox1.Checked;
            textBox3.Enabled = checkBox1.Checked;
        }
    }
}
