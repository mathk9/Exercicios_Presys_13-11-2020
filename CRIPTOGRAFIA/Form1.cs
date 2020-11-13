using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Criptografia_Exemplo
{
    public partial class Form1 : Form
    {        
          public Form1()
        {
            InitializeComponent();
        }

          private void btnCript_Click(object sender, EventArgs e)
          {
              string texto = txtInput.Text;

              string key = "@23.02.2001"; //Está chave você mesmo é quem escolhe.


              Criptografia crip = new Criptografia(CryptProvider.DES);

              crip.Key = key;

              txtOutput.Text = crip.Encrypt(texto);
          }

          private void btnDescript_Click(object sender, EventArgs e)
          {
              string texto = txtOutput.Text;


              //Está chave tem que ser a mesma que a do texto Encriptado.

              string key = "@23.02.2001";


              Criptografia crip = new Criptografia(CryptProvider.DES);

              crip.Key = key;


              MessageBox.Show(crip.Decrypt(texto), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
          }

          private void btnClear_Click(object sender, EventArgs e)
          {

          }

          private void toolStripLabel1_Click(object sender, EventArgs e)
          {
              Close();
          }
    }
}
