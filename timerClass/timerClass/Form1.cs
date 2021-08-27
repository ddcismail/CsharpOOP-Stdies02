using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 60 ;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter==0)
            {
                timer1.Stop();
                MessageBox.Show("TİMER LİMTE ULAŞTI");

            }
            progressBar1.Value = counter;
            counter--;
            label1.Text = counter.ToString();
            if (counter % 2 == 1)
            {
                button3.BackColor = Color.Red;
            }
            else
                button3.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
