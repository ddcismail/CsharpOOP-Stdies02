using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee personelIdDetails = new Employee();
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            MessageBox.Show(personelIdDetails.EmployeeId + " " + personelIdDetails.Name + " " + personelIdDetails.Age);

        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelIdDetails.EmployeeId = Convert.ToInt32(textBox1.Text);
            personelIdDetails.Name = textBox2.Text;
            personelIdDetails.Age = Convert.ToInt32(textBox3.Text);
            MessageBox.Show("Bilgiler Alındı !");

        }
    }
}
