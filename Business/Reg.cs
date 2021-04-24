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
    public struct Users
    {
        public string login;
        public string password;
        public string type;
        public string money;
        public string found;
    }
    public partial class Reg : Form
    {
        public static Users users = new Users();
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 1, 1);
        public Reg()
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
        private void label2_Click(object sender, EventArgs e)
        {
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool key = false;
            if(textBoxLogin.Text!="" && textBoxPassword.Text!="")
            {
                foreach (User user in Program.m.User)
                {
                    
                    
                        if (textBoxLogin.Text == user.Email && textBoxPassword.Text == user.Password)
                        {
                            if (user.RoleId == "R")
                            {
                                Form form = new Runs();
                                form.Show();
                                this.Hide();
                                users.login = user.Email;
                                users.password = user.Email;
                                users.type = "R";
                                key = true;
                                break;
                            }
                            else if (user.RoleId == "A")
                            {
                                Form form = new AdmMenu();
                                form.Show();
                                this.Hide();
                                users.login = user.Email;
                                users.password = user.Email;
                                users.type = "A";
                                key = true;
                                break;
                            }
                            else if (user.RoleId == "C")
                            {
                                Form form = new MenuCoordinator();
                                form.Show();
                                this.Hide();
                                users.login = user.Email;
                                users.password = user.Email;
                                users.type = "";
                                key = true;
                                break;
                            }
                        }
                    
                }
                if(!key) MessageBox.Show("Пользователь не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form form = new Main();
            form.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Form form = new Main();
            form.Show();
            this.Hide();
        }
    }
}
