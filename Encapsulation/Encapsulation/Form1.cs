using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.PersonelID = textBox1.Text;
            personel.Ad = textBox2.Text;
            personel.Yas = textBox3.Text;
            personel.Pozisyon = textBox4.Text;
            Form2 form = new Form2();
            form.personel = personel;
            form.Show();
        }
    }
}
