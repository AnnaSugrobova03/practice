using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetPay(int payment)
        {
            int credit = Convert.ToInt32(textBox1.Text);
            int debt;//задолженность
            int overpayment;

            if(payment > credit)
            {
                overpayment = payment - credit;
                MessageBox.Show("Кредит погашен. Сумма переплаты составила " + overpayment + " рублей");

            }
            else if (payment == credit)
            {
                MessageBox.Show("Кредит погашен");
            }
            else
            {
                debt = credit - payment;
                MessageBox.Show("Задолженность составляет " + debt + " рублей");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int debt = 0;
                int overpayment = 0;
                GetPay(Convert.ToInt32(textBox3.Text));
                
            }
            catch
            {
                MessageBox.Show("err0r");
            }
        }
    }
}
