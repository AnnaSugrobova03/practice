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
            new Presenter(this);
        }

        public event EventHandler Start;
        public event EventHandler Stop;
        public event EventHandler Reset;

        class Model
        {
            internal int s;
            public string Time()
            {
                s++;
                return (s >= 60) ? "мин. " + s / 60 + " сек. " + s % 60 : s.ToString();
            }
        }
        class Presenter
        {
            private readonly Form1 view;
            Model model;

            public Presenter(Form1 form1)
            {
                model = new Model();
                view = form1;

                view.Start += View_Start;
                view.Stop += View_Stop;
                view.Reset += View_Reset;
                view.timer1.Tick += TimerTick;
                view.timer1.Start();
                view.timer1.Enabled = false;
            }

            private void TimerTick(object sender, EventArgs e)
            {
                view.textBox1.Text = model.Time();
            }

            private void View_Reset(object sender, EventArgs e)
            {
                model.s = 0;
                view.timer1.Stop();
                view.textBox1.Text = "0";
            }

            private void View_Stop(object sender, EventArgs e)
            {
                view.timer1.Stop();
                view.timer1.Enabled = false;
            }

            private void View_Start(object sender, EventArgs e)
            {
                view.timer1.Start();
                view.timer1.Enabled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Start(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stop(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset(sender, e);
        }
    }
}
