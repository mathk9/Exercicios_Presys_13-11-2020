using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Web.Script.Serialization;


namespace Criptografia_Exemplo
{
    public partial class Serializacao : Form
    {
       public List<Pessoa> lista = new List<Pessoa>();
       public int contador = 1;
       /*public List<String> nome = new List<String>();
       public List<String> tel = new List<String>();*/

        public Serializacao()
        {
            InitializeComponent();
            File.Delete("Hey.xml");
            txtID.Text = "1";
        }

        private void Serializacao_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            lista.Add(new Pessoa
            {   
                ID = int.Parse(txtID.Text),
                Nome = txtNome.Text,
                Telefone = mtbTelefone.Text
            });
            }
            catch
            {
                MessageBox.Show("Digite corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            FileStream fs = new FileStream("Hey.xml", FileMode.Create);
            XmlSerializer xz = new XmlSerializer(typeof(List<Pessoa>));
            xz.Serialize(fs, lista);
            fs.Close();

            contador++;

            txtID.Text = contador.ToString();
            txtNome.Text = "";
            mtbTelefone.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo("Hey.xml");
            if (fi.Exists)
            {
                FileStream fs = new FileStream("Hey.xml", FileMode.Open);
                XmlSerializer xz = new XmlSerializer(typeof(List<Pessoa>));
                List<Pessoa> lista2 = (List<Pessoa>)xz.Deserialize(fs);
                fs.Close();
                foreach(Pessoa a in lista2)
                MessageBox.Show(string.Format("ID: {0} \nNome: {1} \nTelefone: {2}",a.ID, a.Nome, a.Telefone));
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Add(new Pessoa
                {
                    ID = int.Parse(txtID.Text),
                    Nome = txtNome.Text,
                    Telefone = mtbTelefone.Text
                });
            }
            catch
            {
                MessageBox.Show("Digite corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            JavaScriptSerializer json = new JavaScriptSerializer();
            File.WriteAllText("Hi.json", json.Serialize(lista));
            
            contador++;

            txtID.Text = contador.ToString();
            txtNome.Text = "";
            mtbTelefone.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {      
            FileInfo fi = new FileInfo("Hi.json");
            if (fi.Exists)
            {
                JavaScriptSerializer json = new JavaScriptSerializer();
                var resultado = json.Deserialize<List<Pessoa>>(File.ReadAllText("Hi.json"));
                foreach (Pessoa a in resultado)
                {
                    MessageBox.Show(string.Format("ID: {0} \n Nome: {1} \n Telefone: {2}", a.ID, a.Nome, a.Telefone));
                }
            }
            else
            {
                   MessageBox.Show("Arquivo não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
  
       
        }
    }
}
