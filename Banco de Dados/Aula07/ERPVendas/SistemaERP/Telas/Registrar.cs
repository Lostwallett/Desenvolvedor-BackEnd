using SistemaERP.Classes.Contextos;
using SistemaERP.Classes.Entidades;
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
    public partial class Registrar : Form
    {
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Botão de fechar a tela de registro, volta para a tela de login
            TelaLogin.AbrirTelaLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string sobrenome = textBox2.Text;
            long cpf = long.Parse(textBox3.Text);
            DateTime data = DateTime.SpecifyKind(monthCalendar1.SelectionStart, DateTimeKind.Utc);

            MessageBox.Show($"Nome: {nome}\n" +
                $"Sobrenome: {sobrenome}\n" +
                $"CPF: {cpf}\n" +
                $"Data: {data}");
            string nomecompleto = nome + " " + sobrenome;

            Pessoa usuario = new Pessoa(nomecompleto, cpf, data, 0);
            ContextoPessoa pessoa = new ContextoPessoa();
            pessoa.Pessoas.Add(usuario);
            pessoa.SaveChanges();
            MessageBox.Show("Cadastro realizado com sucesso!");

            Hide();
                        
            TelaLogin.AbrirTelaLogin();
        }
    }
}
