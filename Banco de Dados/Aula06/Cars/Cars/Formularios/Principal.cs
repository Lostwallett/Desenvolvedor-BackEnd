using Cars.Classes.Animation;
using Cars.Classes.Contextos;
using Cars.Classes.Service;
using Microsoft.IdentityModel.Tokens;

namespace Cars;

public partial class Principal : Form
{
    // Controlador que concentra toda a lógica de animação do panel1.
    private readonly AnimationPanel animacaoPainel;

    public Principal()
    {
        // Inicializa os controles criados pelo Windows Forms Designer.
        InitializeComponent();

        // Cria o controlador e informa qual painel deverá ser animado.
        animacaoPainel = new AnimationPanel(panel1);

        // Associa os botões de navegação ao método que fecha o painel.
        button3.Click += FecharPanel_Click;
        button4.Click += FecharPanel_Click;
        button5.Click += FecharPanel_Click;
    }

    private void button2_Click(object? sender, EventArgs e)
    {
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

        bool moto = radioButton1.Checked;
        bool carro = radioButton2.Checked;
        string texto = textBox1.Text;

        Pesquisa.Pesquisas(moto, carro, texto, dataGridView1);
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
}
