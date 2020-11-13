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
    public partial class UseControl : Form
    {
        public UseControl()
        {
            InitializeComponent();
        }

        private void btnGetState_Click(object sender, EventArgs e)
        {
           MessageBox.Show(string.Format("ID do Estado = {0}, Nome = {1}", userControlState1.SelectedState.ID, userControlState1.SelectedState.Name), "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
