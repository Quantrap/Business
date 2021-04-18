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
    public partial class SpRunner : Form
    {
        public string Cost,Found;

        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 1, 1);
        public SpRunner()
        {
            InitializeComponent();
            labelPrice.Text = "$10";
            ShowRunners();
            textBoxUrName.Text = "Ваше имя";
            textBoxUrName.ForeColor = Color.Gray;
            comboBoxRunner.SelectedItem = 0;
            textBoxCart.Text = "Владелец карты";
            textBoxUrName.ForeColor = Color.Gray;
            textBoxNumberC.Text = "1234 1234 1234 1234";
            textBoxNumberC.ForeColor = Color.Gray;
            textBoxTime1.Text = "01";
            textBoxTime1.ForeColor = Color.Gray;
            textBoxTime2.Text = "2017";
            textBoxTime2.ForeColor = Color.Gray;
            textBoxCVC.Text = "123";
            textBoxCVC.ForeColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void SpRunner_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (textBoxCart.Text.Length==16 && textBoxUrName.Text.Length>4 && textBoxUrName.Text.Length > 4 && 
                Convert.ToInt32(DateTime.Now.Year)>=Convert.ToInt32(textBoxTime2.Text))
            { 
                if(Convert.ToInt32(DateTime.Now.Month) >= Convert.ToInt32(textBoxTime1.Text))
                {

                }
            }
            Form formThanks = new Thanks();
            formThanks.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUrName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Main();
            form.Show();
            this.Hide();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(labelPrice.Text.Substring(1, labelPrice.Text.Length - 1)) - 10) >= 20)
            {
                labelPrice.Text = "$" + Convert.ToString(Convert.ToInt32(labelPrice.Text.Substring(1, labelPrice.Text.Length - 1)) - 10);
                textBoxMoney.Text = labelPrice.Text.Substring(1, labelPrice.Text.Length - 1);
            }
            else
            {
                labelPrice.Text = "$10";
                textBoxMoney.Text = "10";
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            labelPrice.Text = "$" + Convert.ToString(Convert.ToInt32(labelPrice.Text.Substring(1, labelPrice.Text.Length - 1)) + 10);
            textBoxMoney.Text = labelPrice.Text.Substring(1, labelPrice.Text.Length - 1);
        }

        private void textBoxMoney_TextChanged(object sender, EventArgs e)
        {
            int b = 0;
            if (Int32.TryParse(textBoxMoney.Text, out b))
            {
                if (Convert.ToInt32(textBoxMoney.Text) > 0)
                {
                    labelPrice.Text = "$" + textBoxMoney.Text;

                }
            }
        }
        void ShowRunners()
        {
            comboBoxRunner.Items.Clear();
            foreach (Runner runner in Program.m.Runner)
            {
                string[] item = { runner.User.FirstName + " ", runner.User.LastName + "- ",runner.RunnerId.ToString() + " ","("+runner.Country.CountryName+")" };
                comboBoxRunner.Items.Add(string.Join(" ", item));
            }
        }
    }
}
