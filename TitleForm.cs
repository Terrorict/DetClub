using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetClub
{
    public partial class TitleForm : Form
    {
        ResizeHandler Sizer = new ResizeHandler();

        public TitleForm()
        {
            InitializeComponent();
            Sizer.Form = this;
            Sizer.GroupBox = groupBox1;
        }

        private void TitleForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(Variables.filepath))
                btLoad_Click_1(sender, e);
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            Sizer.TitleResize();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.FillConnection(tbServer.Text, tbPort.Text, tbDB.Text, tbLogin.Text, tbPassword.Text);
            if (DB.TestConnection())
            {
               AuthForm frm = new AuthForm();
                Hide();
                frm.ShowDialog();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            tbServer.Text = "192.168.0.94";
            tbPort.Text = "3306";
            tbDB.Text = "is-31-terehove";
            tbLogin.Text = "is-31-terehove";
            tbPassword.Text = "2C9bgm";
        }

        private void btLoad_Click_1(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.LoadConnection(tbServer, tbPort, tbDB, tbLogin, tbPassword);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите сохранить настройки подключения?", "Потверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DataBase DB = new DataBase();
                DB.SaveConnection(tbServer.Text, tbPort.Text, tbDB.Text, tbLogin.Text, tbPassword.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();
            DB.OpenDirectory();
        }
    }
}
