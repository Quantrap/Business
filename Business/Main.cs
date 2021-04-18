using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace Business
{

    public partial class Main : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 1, 1);
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle=FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            metroLabel1.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new RegRunnescs();
            form.Show();
            this.Hide();
        }


            private void label2_Click(object sender, EventArgs e)
            {
                label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new SpRunner();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Inform();
            form.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form form = new Reg();
            form.Show();
            this.Hide();
        }
    }

    } 
