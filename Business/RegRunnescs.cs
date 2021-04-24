using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business
{
    public partial class RegRunnescs : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 1, 1);
        public RegRunnescs()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            metroLabel1.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            Form form = new Reg();
            form.Show();
            this.Hide();
        }

        private void buttonSecond_Click(object sender, EventArgs e)
        {
            Form form = new RegistrationRunners2();
            form.Show();
            this.Hide();
        }
    }
}
