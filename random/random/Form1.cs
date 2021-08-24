using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            label1.Text = rndm.Next().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            label2.Text = rndm.Next(100).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            label3.Text = rndm.Next(10,100).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            label4.Text = rndm.NextDouble().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            byte[] arrays = new byte[5];
            rndm.NextBytes(arrays);
            textBox1.Text += arrays[0].ToString() + " " + arrays[1].ToString() + " " + arrays[2].ToString() + " " + arrays[3].ToString() + " " + arrays[4].ToString() +" "+  Environment.NewLine;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            const string chars = "abcdefghıijklmnoöprsştuüvyzwqxABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string result = "";
            Random rndm02 = new Random();
            for (int i = 0; i < 6; i++)
            {
                result += chars[rndm02.Next(0, Convert.ToInt32(chars.Length))];
            }

            label5.Text = result;
        }
    }
}
