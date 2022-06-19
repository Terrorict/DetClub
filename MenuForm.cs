using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetClub
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            Text = Variables.User.Name;
        }

        private void button5_Click(object sender, EventArgs e) // Выход
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            switch (Variables.User.Role)
            {
                case "Кассир":
                    btReports.Visible =
                    btManagers.Visible =
                    btAccountants.Visible =
                    btCashiers.Visible = false;
                break;
                case "Бухгалтер":
                    btReports.Visible =
                    btManagers.Visible =
                    btAccountants.Visible =
                    btCashiers.Visible = false;
                    break;
            }
            int height = 12;
            ButtonSorter btst = new ButtonSorter();
            foreach(Control bt in btst.SortButts(this.Controls))
            {
                if(bt is Button && (bt as Button).Visible)
                {
                    (bt as Button).Location = new Point(12, height);
                    height += (bt as Button).Height + 6;
                }
            }
            this.Height = height + 45;
        }
    }
}
