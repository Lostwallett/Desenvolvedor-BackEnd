using SistemaERP.Classes.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaERP.Telas
{
    public partial class Senha : Form
    {
        public Senha()
        {
            InitializeComponent();
        }

        private void Senha_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Botão de fechar a tela de registro, volta para a tela de login
            TelaLogin.AbrirTelaLogin();
        }
    }
}
