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
    public partial class DesignPattern : Form
    {
        public DesignPattern()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();
            Orcamento orcamento;
            CalculadoraImpostos calculadora = new CalculadoraImpostos();

            Verificacao(textBox1.Text);
            
            orcamento = new Orcamento(double.Parse(textBox1.Text));

            if (comboBox1.Text.Equals("ISS"))
            {
                textBox2.Text = calculadora.Calculo(orcamento, iss).ToString();
            }
            else if (comboBox1.Text.Equals("ICMS"))
            {
                textBox2.Text = calculadora.Calculo(orcamento, icms).ToString();
            }
            else
            {
                MessageBox.Show("Selecione algum tipo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }

        public void Verificacao(string txtbox)
        {
            double result = 0;
            bool aux = double.TryParse(txtbox, out result);
            if (!aux) 
            {
                MessageBox.Show("Digite um valor válido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                textBox1.Text = "";
            }
                       
        }
    }
}

