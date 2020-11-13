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
    public partial class Teste1 : Form
    {
        public Teste1()
        {
            InitializeComponent();
        }        
       
        private void btnSomar_Click(object sender, EventArgs e)
        {
            NUMEROS_1 classe = new NUMEROS_1();
            
            try
            {
                txtResultado.Text = (classe.Soma(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))).ToString();

            }
            catch
            {
                MessageBox.Show("Digite um número válido!",  "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NUMEROS_1 classe = new NUMEROS_1();

            try
            {
                txtResultado.Text = (classe.Subtrai(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))).ToString();

            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NUMEROS_1 classe = new NUMEROS_1();

            try
            {
                txtResultado.Text = (classe.Multiplica(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text))).ToString();

            }
            catch
            {
                MessageBox.Show("Digite um número válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

      
    }
}
