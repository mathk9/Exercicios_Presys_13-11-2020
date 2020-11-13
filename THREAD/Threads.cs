using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Criptografia_Exemplo
{
    public partial class Threads : Form
    {
        public Threads()
        {
            InitializeComponent();
        }

        #region Exemplo 1
        public Thread[] example01;
        private void btnIniciar_Click(object sender, EventArgs e)
        {

            txtValorAtual01.Text = txtValor.Text;
            double valor = int.Parse(txtValor.Text);
            double retirada = double.Parse(txtRetirada.Text);
            double auxiliar = ((valor- valor%retirada) / retirada) + 1;
            int elements = (int)auxiliar;
            example01 = new Thread[elements];
             
            

            for (int i = 0; i < example01.Length; i++)
            {
                Thread thread = new Thread(Conta01);
                thread.Name = "Thread " + "(" + i + ")";
                example01[i] = thread;
            }



            foreach (var aux in example01)
            {
                aux.Start();
                
            }

            txtValorAtual02.Text = txtValor.Text;
            double valor2 = int.Parse(txtValor2.Text);
            double add = double.Parse(txtAdd.Text);
            double auxiliar2 = ((valor - valor % add) / add) + 1;
            int elements2 = (int)auxiliar;
            example02 = new Thread[elements2];



            for (int i = 0; i < example01.Length; i++)
            {
                Thread thread = new Thread(Conta02);
                thread.Name = "Thread " + "(" + i + ")";
                example02[i] = thread;
            }



            foreach (var aux in example02)
            {
                aux.Start();

            }

        }

        
        public object locker = new object();

        public int cont = 1;
        public void Conta01()
        {

            lock (locker2)
            {
                double valor = double.Parse(txtValorAtual01.Text);

                this.Invoke(new Action(() =>
                {

                    if (valor > 0)
                    {
                        double retirada = double.Parse(txtRetirada.Text);
                        Thread.Sleep(1000);



                        txtThread01.Text = "Thread " + "(" + cont2 + ")";
                        txtValorAtual01.Text = valor.ToString();
                        valor -= retirada;

                        txtValorAtual01.Text = valor.ToString();

                    }
                    else
                    {
                        txtValorAtual01.Text = "Insuficiente";
                    }
                }));
            }

            cont2++;

        }
        #endregion

        public Thread[] example02;
       
        public object locker2 = new object();

        public int cont2 = 1;
        public void Conta02()
        {

            lock (locker2)
            {
                double valor = double.Parse(txtValorAtual02.Text);

                this.Invoke(new Action(() =>
                {

                    if (valor > 0)
                    {
                        double add = double.Parse(txtAdd.Text);
                        Thread.Sleep(1000);
                        txtThread02.Text = "Thread " + "(" + cont2 + ")";
                        txtValorAtual02.Text = valor.ToString();
                        valor += add;

                        txtValorAtual02.Text = valor.ToString();

                    }
                    else
                    {
                        txtValorAtual02.Text = "Insuficiente";
                    }
                }));
            }

            cont2++;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
