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
    public partial class UsoDelegate : Form
    {
        public UsoDelegate()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result;
            int num1 = 0;
            int num2 = 0;
            try
            {
                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);
            }
            catch
            {
                MessageBox.Show("Digite um número inteiro!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtNum1.Clear();
                txtNum2.Clear();
            }

            operation Dlg1 = new operation(TesteDelegate.soma);

            result = Dlg1(num1, num2);
            txtSoma.Text = result.ToString();

            Dlg1 = new operation(TesteDelegate.multiplicacao);
            result = Dlg1(num1, num2);
            txtMulti.Text = result.ToString();
        }

    }
}
