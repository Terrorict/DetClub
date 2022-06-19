using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DetClub
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

/*        public bool AuthCheck(string login, string password)
        {
            DataTable result = Select("user", "*", "login = '" + login + "' AND password = '" + password + "' AND enabled = 1");
            if (result.Rows.Count == 1)
            {
                Variables.User.Fill(Convert.ToInt32(result.Rows[0][0]), result.Rows[0][2].ToString() + " " + result.Rows[0][3].ToString() + " " + result.Rows[0][4].ToString(), login, result.Rows[0][1].ToString());
                return true;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
                return false;
            }
        }*/

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e) 
        {
            if(!(tbLogin.Text == "") || (tbPassword.Text == ""))
            {
                DataBase DB = new DataBase();
                if (DB.AuthCheck(tbLogin.Text, tbPassword.Text))
                {
                    MenuForm frm = new MenuForm();
                    ActiveUpdater.MakeActive();
                    Hide();
                    frm.ShowDialog();
                }
                else
                {
                    tbPassword.Clear();
                    tbLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Поле логина или пароля не заполнено", "Ошибка");
                tbLogin.Focus();
                tbPassword.Clear();

            }
        }

        private void AuthForm_FormClosing(object senger, KeyEventArgs e)
        {
            Application.Exit();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}
