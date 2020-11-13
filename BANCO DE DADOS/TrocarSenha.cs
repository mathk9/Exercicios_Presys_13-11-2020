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
    public partial class TrocarSenha : Form
    {
        public TrocarSenha()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle control = new Controle();
            string mensagem = control.alterar(txtLogin.Text, txtSenha.Text, txtConfirmacao.Text);
            if (control.existe)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(control.mensagem);
            }
        }
    }
}
