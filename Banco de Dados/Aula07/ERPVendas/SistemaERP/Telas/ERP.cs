using SistemaERP.Classes.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SistemaERP.Telas
{
    public partial class ERP : Form
    {
        public ERP()
        {
            InitializeComponent();
        }

        private void ERP_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Botão de fechar a tela de registro, volta para a tela de login
            TelaLogin.AbrirTelaLogin();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            TelaLogin.AbrirTelaLogin();
        }

        private void aprovaçãoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Aprovacao tela = new Aprovacao();
            tela.Show();
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarRelatorio();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Não foi possível carregar o relatório: Erro -> {ex.Message}!");
            }
        }

        private void CarregarRelatorio()
        {
            Hide();
            RelatorioVendas relatorio = new RelatorioVendas();
            relatorio.Show();

        }
        
    }
}