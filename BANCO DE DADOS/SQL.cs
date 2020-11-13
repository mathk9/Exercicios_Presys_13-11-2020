using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Criptografia_Exemplo
{
    public partial class SQL : Form
    {
        public SQL()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro tela = new Cadastro();
            tela.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle control = new Controle();
            control.acessar(txtLogin.Text, txtSenha.Text);
            if (control.mensagem.Equals(""))
            {

                if (control.existe)
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login não encontrado, verifique login e senha", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show(control.mensagem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle control = new Controle();
            control.Descadastrar(txtLogin.Text, txtSenha.Text);

            if (control.existe)
            {
                MessageBox.Show("Usuário deletado!");
            }
            else
            {
                MessageBox.Show("Usuário Inexistente!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrocarSenha tela = new TrocarSenha();
            tela.ShowDialog();
        }
       
    }
}
