using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Employee employee01 = new Employee();
            Employee employee02 = new Employee();
            Employee employee03 = new Employee();
            employee01.employeeID = 1;
            employee01.employeeName = "İsmail";
            employee01.employeeAge = 21;

            employee02.employeeID = 2;
            employee02.employeeName = "İhsan";
            employee02.employeeAge = 21;

            employee03.employeeID = 3;
            employee03.employeeName = "Ömer Asaf";
            employee03.employeeAge = 3;
            list.Add(employee01);
            list.Add(employee02);
            list.Add(employee03);

            Days day01 = new Days();
            Days day02 = new Days();
            Days day03 = new Days();
            Days day04 = new Days();
            Days day05 = new Days();
            Days day06 = new Days();
            Days day07 = new Days();

            day01.daysID = 1;
            day01.daysName = "Pazartesi";
            daysList.Add(day01);

            day02.daysID = 2;
            day02.daysName = "Salı";
            daysList.Add(day02);

            day03.daysID = 3;
            day03.daysName = "Çarşamba";
            daysList.Add(day03);

            day04.daysID = 4;
            day04.daysName = "Perşembe";
            daysList.Add(day04);

            day05.daysID = 5;
            day05.daysName = "Cuma";
            daysList.Add(day05);

            day06.daysID = 6;
            day06.daysName = "Cumartesi";
            daysList.Add(day06);

            day07.daysID = 7;
            day07.daysName = "Pazar";
            daysList.Add(day07);

            comboBox1.DataSource = daysList;
            comboBox1.DisplayMember = "daysName";
            comboBox1.ValueMember = "daysID";

            dataGridView1.DataSource = daysList;

        }

        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> list = new List<Employee>();
        List<Days> daysList = new List<Days>();

        void fillList()
        {
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillList();
            foreach (int item in numberList)
            {
                textBox1.Text += item.ToString()+Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                textBox2.Text += item.employeeID.ToString() + "  " + item.employeeName + "  " + item.employeeAge.ToString()+Environment.NewLine;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedValue.ToString();
        }
    }
}
