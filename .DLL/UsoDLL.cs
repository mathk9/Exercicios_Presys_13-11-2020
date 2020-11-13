using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExemploDLL;

namespace Criptografia_Exemplo
{
    public partial class UsoDLL : Form
    {
        public UsoDLL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {             
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;

            try
            {
                n1 = EntradaDados(txtNum1.Text);
                n2 = EntradaDados(txtNum2.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números inteiros!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            txtResultado.Text = (OperacoesMatematicas.Somar(n1, n2)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;

            try
            {
            n1 = EntradaDados(txtNum1.Text);
            n2 = EntradaDados(txtNum2.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números inteiros!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            txtResultado.Text = (OperacoesMatematicas.Subtrair(n1, n2)).ToString();

        }
        public int EntradaDados(string txt)
        {
            int n =0;
                        
            n = int.Parse(txt);                
            
            return n;
        }

        
    }
}
