using Restaurante.Classes.Contextos;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        //Campo
        PratosContexto contexto = new PratosContexto();
        Dictionary<string, decimal> carrinho = new Dictionary<string, decimal>();

        //Timer para poder fazer a animação
        System.Windows.Forms.Timer timerPanel = new System.Windows.Forms.Timer();

        //Posição final da sidebar
        int posicaoPanelX;


        //Construtores
        public Form1()
        {
            InitializeComponent();
            timerPanel.Interval = 15;
            timerPanel.Tick += TimerPanel_Tick;
        }

        private void TimerPanel_Tick(object? sender, EventArgs e)
        {
            const int velocidade = 20;

            //Move o painel para a direita até alcançar a posição final

            if (panel1.Left < posicaoPanelX)
            {
                panel1.Left += velocidade;

                if (panel1.Left >= posicaoPanelX)
                {
                    panel1.Left = posicaoPanelX;
                }
            }
        }

        //Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = contexto.Pratos.Select(t => new { t.Id, t.Nome_do_prato, Preco = t.Preco.ToString("C") }).ToList();
            dataGridView1.Columns[0].HeaderText = "Nº do Prato";
            dataGridView1.Columns[1].HeaderText = "Nome do Prato";
            dataGridView1.Columns[2].HeaderText = "Preço do Prato";
        }

        private void dataGridView1_MouseHover(object sender, EventArgs e)
        {
            try
            {
                var coordenadaMouse = dataGridView1.PointToClient(Cursor.Position);

                int id = dataGridView1.HitTest(coordenadaMouse.X, coordenadaMouse.Y).RowIndex + 1;

                var comida = contexto.Pratos.FirstOrDefault(e => e.Id == id);

                if (comida.Foto_do_prato != null)
                {
                    pictureBox1.ImageLocation = comida.Foto_do_prato;
                }
                else
                {
                    pictureBox1.ImageLocation = null;
                }
            }
            catch (NullReferenceException)
            {

                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um item do cardápio!");
                return;
            }
            else
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                var comidaselecionada = contexto.Pratos.FirstOrDefault(e => e.Id == id);
                carrinho.Add(comidaselecionada.Nome_do_prato, comidaselecionada.Preco);
                MessageBox.Show("Item selecionado: " + comidaselecionada.Nome_do_prato + " - Preço: " + comidaselecionada.Preco.ToString("C"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conteudoCarrinho = "Lista de pratos adicionados:\n";

            foreach (var item in carrinho)
            {
                conteudoCarrinho += $"Nome do prato: {item.Key} | Preço: {item.Value.ToString("C")}\n";
            }
            MessageBox.Show(conteudoCarrinho);
            panel1.Visible = true;
        }
    }
}
