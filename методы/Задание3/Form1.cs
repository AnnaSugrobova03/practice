using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c;

            if(radioButton1.Checked)
            {
                c = a / b - b;
                MessageBox.Show("Остаток от деления: " + c);
            }
            if(radioButton2.Checked)
            {
                c = Math.Pow(a, b);
                MessageBox.Show("Число а в степени b: " + c);
            }
            if (radioButton3.Checked)
            {
                c = Convert.ToDouble(string.Concat(a, b));
                MessageBox.Show("Конкатенация: " + c);
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                MessageBox.Show("Деления числа а на число b: " + c);
            }
        }
    }
}
