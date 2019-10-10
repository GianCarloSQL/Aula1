using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BicicletaLibrary.Controller;
using BicicletaLibrary.Model;

namespace View
{
    public partial class Form1 : Form
    {
        public static BicicletaController Control = new BicicletaController();

        public Form1()
        {

            InitializeComponent();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Control.Inserir(new Bicicleta(textBox1.Text));
            MessageBox.Show("Bicicleta Cadastrada!");

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Control.GetLista().ToList().ForEach(x => listBox1.Items.Add($"{x.Id}   |   {x.Modelo}\n"));
            Carrega();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {
            
        }
        public  void Carrega() {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(30);
            }
        }
    }
}
