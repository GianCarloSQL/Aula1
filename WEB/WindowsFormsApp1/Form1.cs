using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using DataFrame;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool first = true;
        public Form1()
        {
            MapToDataBase<P> mapa = new MapToDataBase<P>();
            mapa.CreateTables();
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 0;
            int y = 60;
            Label lblT = new Label();
            lblT.Text = "TESTE";
            lblT.ForeColor = Color.Red;
            lblT.Font = new Font("Arial", 15, FontStyle.Regular);
            lblT.Location = new Point(165,20);
            Controls.Add(lblT);
            foreach (PropertyInfo prop in typeof(P).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                Label lbl = new Label();
                TextBox txt = new TextBox();
                txt.Width = 200;
                lbl.Width = 100;
                lbl.Text = prop.Name;
                lbl.Location = new Point(x, y);
                if (first)
                {
                    txt.Location = new Point(x + 100, y);
                    first = false;
                }
                else
                {
                    txt.Location = new Point(x + 100, y - 5);
                }

                Controls.Add(lbl);
                Controls.Add(txt);
                y += 50;
                x++;
            }


        }


    }
    public class P
    {
        public string A { get; set; }
        public string BBBB { get; set; }
        public string CCCC { get; set; }
        public string DDDD { get; set; }
        public string EEEE { get; set; }
        public string FFFF { get; set; }
    }

}
