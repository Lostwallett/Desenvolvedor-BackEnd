using Cars.Classes.Animation;
using Cars.Classes.Contextos;
using Cars.Classes.Entidades;
using Cars.Classes.Service;
using Microsoft.IdentityModel.Tokens;

namespace Cars;

public partial class Principal : Form
{
    // Controlador que concentra toda a lógica de animação do panel1.
    private readonly AnimationPanel animacaoPainel;
    EstoqueContexto contexto = new EstoqueContexto();

    public Principal()
    {
        // Inicializa os controles criados pelo Windows Forms Designer.
        InitializeComponent();

        // Cria o controlador e informa qual painel deverá ser animado.
        animacaoPainel = new AnimationPanel(panel1);

        // Associa os botões de navegação ao método que fecha o painel.        
        button4.Click += FecharPanel_Click;
        button5.Click += FecharPanel_Click;
    }

    //Botão de comprar
    private void button2_Click(object? sender, EventArgs e)
    {
        try
        {
            DataGridViewRow linhaSelecionada = dataGridView1.SelectedRows[0];

            textBox2.Text = linhaSelecionada.Cells["Modelo"].Value.ToString();
            textBox3.Text = linhaSelecionada.Cells["Tipo"].Value.ToString();
            if (textBox3.Text.Equals("1"))
            {
                textBox3.Text = "Carro";
            }

            else if (textBox3.Text.Equals("2"))
            {
                textBox3.Text = "Moto";
            }
            textBox4.Text = linhaSelecionada.Cells["Valor"].Value.ToString();
            textBox5.Text = linhaSelecionada.Cells["Quantidade"].Value.ToString();
            pictureBox1.ImageLocation = contexto.Estoque.FirstOrDefault(m => m.Modelo == linhaSelecionada.Cells["Modelo"].Value.ToString())?.Foto;
        }
        catch (Exception)
        {
            MessageBox.Show("Nenhuma linha selecionada.");
        }     

        // Solicita à classe de animação que abra o painel ao clicar em Comprar.
        animacaoPainel.Abrir();
    }

    private void FecharPanel_Click(object? sender, EventArgs e)
    {
        // Solicita à classe de animação que feche o painel.
        animacaoPainel.Fechar();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Dados();        
    }

    private void radioButton1_Click(object sender, EventArgs e)
    {
        bool botao = radioButton1.Checked;
        if (botao)
        {
            radioButton1.Checked = true;
        }
        else
        {
            radioButton2.Checked = false;
        }
    }
    private void radioButton2_Click(object sender, EventArgs e)
    {
        bool botao1 = radioButton2.Checked;
        if (botao1)
        {
            radioButton2.Checked = true;
        }
        else
        {
            radioButton1.Checked = false;
        }
    }
    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        bool botao2 = radioButton3.Checked;
    }

    //Fechar compra
    private void button3_Click(object sender, EventArgs e)
    {
        if (numericUpDown1.Value.Equals(0))
        {
            MessageBox.Show("Valor zero. Selecione a quantidade desejada!");
        }

        else if (numericUpDown1.Value > contexto.Estoque.FirstOrDefault(m => m.Modelo == textBox2.Text).Quantidade)
        {
            MessageBox.Show("O valor não pode ser maior do que há em estoque. Tente novamente!");
        }
        else
        {
            decimal total = contexto.Estoque.FirstOrDefault(m => m.Modelo == textBox2.Text).Valor * numericUpDown1.Value;
            MessageBox.Show($"Compra realizada com sucesso no total de R$ {total:F2}!");

            contexto.Estoque.FirstOrDefault(m => m.Modelo == textBox2.Text).Quantidade -= (int)numericUpDown1.Value;
            contexto.SaveChanges();

            animacaoPainel.Fechar();
        }
    }

    private void textBox1_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            Dados();
            e.SuppressKeyPress = true;
        }
    }
    /// <summary>
    /// Insere os dados na pesquisa ao pressionar a tecla Enter.
    /// </summary>
    private void Dados()
    {
        bool moto = radioButton1.Checked;
        bool carro = radioButton2.Checked;
        string texto = textBox1.Text;
        string filtro = comboBox1.Text;

        Pesquisa.Pesquisas(moto, carro, texto, dataGridView1, filtro);
    }
}