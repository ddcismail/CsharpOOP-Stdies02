using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues();
            teacher.SetValues2();
            textBox1.Text += teacher.Id + Environment.NewLine;
            textBox1.Text += teacher.Name + Environment.NewLine;
            textBox1.Text += teacher.Surname + Environment.NewLine;
            textBox1.Text += teacher.Position + Environment.NewLine;
            textBox1.Text += teacher.Salary + Environment.NewLine;
            textBox1.Text += teacher.Branch + Environment.NewLine;
        }
    }
}
