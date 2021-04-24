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
    public partial class VolunteerManagement : Form
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 1, 1);
        public VolunteerManagement()
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
        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void buttonZagVolonteer_Click(object sender, EventArgs e)
        {
            Form form = new VolunteerManagement();
            form.Show();
            this.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form form = new Main();
            form.Show();
            this.Hide();
        }
    }
}
