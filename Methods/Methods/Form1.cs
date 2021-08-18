using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void HideRadioButtons()
        {
            groupBox1.Visible = false;
        }
        public void ClearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        public string FillTextBox()
        {
            string text = textBox1.Text;
            return text;
        }
        string SetNumber()
        {
            string age = textBox1.Text;
            return age;
        }
        void GetName(string text)    //parametre alıp değer dödürmeyen methot
        {
            textBox2.Text = text;
        }
        int Sum(int x , int y)       //parametreli ve değer döndüren 
        {
            int sumResult;
            sumResult = x + y;
            return sumResult;

        }
         private void button1_Click(object sender, EventArgs e)
        {
            HideRadioButtons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearAllText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = FillTextBox();
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = SetNumber();
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetName(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sumresult = Sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label1.Text = sumresult.ToString();
        }
    }
}
