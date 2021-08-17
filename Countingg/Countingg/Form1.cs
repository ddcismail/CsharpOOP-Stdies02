using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countingg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int firstNumber, lastNumber,divisibleNumber;
        string divisibleText;
        int control = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleNumber = Convert.ToInt32(comboBox1.SelectedItem);
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
        }

     
        private void btnCount_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()=="" && textBox2.Text.Trim()=="")
            {
                fromError.SetError(textBox1, "Alanı Boş Bıraktınız");
                MessageBox.Show("Alanları Boş Geçtiniz!!","UYARI");
            }
            else if (comboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("İşlem Yapacağınız Sayıyı Seçin !!");
            }
            else { 
            firstNumber = Convert.ToInt32(textBox1.Text);
            lastNumber = Convert.ToInt32(textBox2.Text);
            for (int i = firstNumber; i < lastNumber; i++)
            {
                if (i%divisibleNumber==0)
                {
                    divisibleText += " " + i.ToString();
                    control++;
                    if (control%10==0)
                    {
                        divisibleText += Environment.NewLine;
                    }
                }
            }
            textBox3.Text = divisibleText;
            }
        }
    }
}
