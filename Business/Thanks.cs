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
    public partial class Thanks : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 1, 1);
        public Thanks()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            timer1.Start();
            labelCost.Text=Reg.users.money ;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            metroLabel1.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }
        private void label2_Click(object sender, EventArgs e)
        {
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formMain = new Main();
            formMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Thanks_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new Main();
            form.Show();
            this.Hide();
        }

        private void labelCost_Click(object sender, EventArgs e)
        {

        }
    }
}
