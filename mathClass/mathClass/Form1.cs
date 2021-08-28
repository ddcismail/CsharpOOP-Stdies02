using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double firstNumber = 0, seconderNumber = 0;
        bool control = false;
        void SetParameter(string text)
        {
            if (text.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else
                control = false;
        }
        void Set2Parameter(string text , string text2)
        {
            if (text.Trim() != "" && text2.Trim() !="")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
                seconderNumber= Convert.ToDouble(text2);
            }
            else
                control = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            seconderNumber = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Set2Parameter(textBox1.Text, textBox2.Text);
            if (!control)
            {
                MessageBox.Show("Text Boxları Doldurunuz!!");
            }
            else
            {
                textBox3.Text = Math.Min(Convert.ToDecimal(firstNumber), Convert.ToDecimal(seconderNumber)).ToString();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Set2Parameter(textBox1.Text, textBox2.Text);
            if (!control)          
                MessageBox.Show("Text Boxları Doldurunuz!!");          
            else
            {
                textBox3.Text = Math.Max(Convert.ToDecimal(firstNumber), Convert.ToDecimal(seconderNumber)).ToString();
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            SetParameter(textBox1.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                textBox3.Text = Math.Abs(Convert.ToDecimal(firstNumber)).ToString();
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            SetParameter(textBox1.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                textBox3.Text = Math.Sign(Convert.ToDecimal(firstNumber)).ToString();//Değer Pozitifse 1 Negatifse -1 değerini gösterir.
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            SetParameter(textBox1.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                double temp = (firstNumber * (Math.PI) / 180);
                textBox3.Text = Math.Sin(temp).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            SetParameter(textBox1.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                double temp = (firstNumber * (Math.PI) / 180);
                textBox3.Text = Math.Cos(temp).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            SetParameter(textBox1.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                double temp = (firstNumber * (Math.PI) / 180);
                textBox3.Text = Math.Tan(temp).ToString();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {

            Set2Parameter(textBox1.Text, textBox2.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                textBox3.Text = Math.Pow((firstNumber), (seconderNumber)).ToString();
            }
        }

        private void btnSiqrt_Click(object sender, EventArgs e)
        {
            SetParameter(textBox1.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                textBox3.Text = Math.Sqrt(firstNumber).ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Set2Parameter(textBox1.Text, textBox2.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                textBox3.Text = Math.Log((firstNumber), (seconderNumber)).ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetParameter(textBox1.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                textBox3.Text = Math.Log10(firstNumber).ToString();
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            SetParameter(textBox1.Text);
            if (!control)
                MessageBox.Show("Text Boxları Doldurunuz!!");
            else
            {
                textBox3.Text = Math.Exp(firstNumber).ToString();
            }
        }

        private void btnCopyFirst_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()!="")
            textBox1.Text = textBox3.Text;
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
