using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        interface Computer
        {
            void GetDesktop ();
            void GetLaptops();
        }
        interface Dellinterface
        {
            void GetDelllaptops();
        }
        class Dell : Computer,Dellinterface
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public void GetDelllaptops()
            {
                Name = "Dell Laptops";
                Price = 9500;
            }

            public void GetDesktop() 
            {
                Name = "Desktop";
                Price = 10000;
            }
            public void GetLaptops()
            {
                Name = "Laptop";
                Price = 20000;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Dell dell = new Dell();
            dell.GetDesktop();
            txtText.Text = dell.Name+""+dell.Price+Environment.NewLine;
            dell.GetLaptops();
            txtText.Text += dell.Name + "" + dell.Price + Environment.NewLine;
            dell.GetDelllaptops();
            txtText.Text += dell.Name + "" + dell.Price + Environment.NewLine;





        }
    }
}
