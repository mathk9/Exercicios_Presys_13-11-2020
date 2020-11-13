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
    public partial class Teste2 : Form
    {
        public Teste2()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            NUMEROS_2 classe = new NUMEROS_2();

            try
            {
                txtResultado.Text = (classe.Soma(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))).ToString();

            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            NUMEROS_2 classe = new NUMEROS_2();

            try
            {
                txtResultado.Text = (classe.Multiplica(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))).ToString();

            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            NUMEROS_2 classe = new NUMEROS_2();

            try
            {
                txtResultado.Text = (classe.Subtrai(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))).ToString();

            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            NUMEROS_2 classe = new NUMEROS_2();

            try
            {
                txtResultado.Text = (classe.Divide(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))).ToString();

            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnElevar_Click(object sender, EventArgs e)
        {
            NUMEROS_2 classe = new NUMEROS_2();

            try
            {
                txtResultado.Text = (classe.Eleva(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))).ToString();

            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            NUMEROS_2 classe = new NUMEROS_2();

            try
            {
                txtResultado.Text = (classe.Raiz(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))).ToString();

            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
