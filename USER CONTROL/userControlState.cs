using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Criptografia_Exemplo
{
    public partial class userControlState : UserControl
    {
        public userControlState()
        {
            InitializeComponent();
        }

        public States SelectedState
        {
            get
            {
                return (States)cmbState.SelectedItem;
            }
        }

        private void userControlState_Load(object sender, EventArgs e)
        {
            List<States> lista = new List<States>();
            lista.Add(new States(){ID = 1, Name = "São Paulo"});
            lista.Add(new States(){ID = 2, Name = "Rio de Janeiro"});
            lista.Add(new States(){ID = 3, Name = "Pará"});
            lista.Add(new States(){ID = 4, Name = "Goias"});
            cmbState.DataSource = lista;
            cmbState.ValueMember = "ID";
            cmbState.DisplayMember = "Name";
        }
    }
}
