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
   
    public partial class UsoInterfaces : Form
    {
        public UsoInterfaces()
        {
            InitializeComponent();
        }
               
        private void btnTeste1_Click(object sender, EventArgs e)
        {
            Teste1 teste = new Teste1();
            teste.ShowDialog();
        }

        private void btnTeste2_Click(object sender, EventArgs e)
        {
            Teste2 teste = new Teste2();
            teste.ShowDialog();
        }
    }
}
