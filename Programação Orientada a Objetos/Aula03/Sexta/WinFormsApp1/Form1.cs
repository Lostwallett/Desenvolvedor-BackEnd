namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const string user = "SENAI";
            int senha = 123456;
            bool ok1, ok2;

            string usuario = textBox1.Text;
            int pass = Convert.ToInt32(textBox2.Text);

            if (user == usuario)
            {
                ok1 = true;
            }
            else
            {
                ok1 = false;
            }

            if (senha == pass)
            {
                ok2 = true;
            }
            else
            {
                ok2 = false;
            }
            if (ok1 & ok2)
            {
                MessageBox.Show("Usuário e senha corretos. Acesso permitido.");
            }
            else
            {
                MessageBox.Show("Usuário e senha inválidos.");
            }
        }
    }
}
