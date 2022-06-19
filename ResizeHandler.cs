using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetClub
{
    class ResizeHandler
    {
        public GroupBox GroupBox { get; set;}
        public Form Form { get; set; }
        public bool GroupBoxIsChanging = false;

        public void TitleResize()
        {
            if (!GroupBoxIsChanging)
            {
                Timer tm = new Timer();
                tm.Enabled = true;
                tm.Interval = 5;
                int interval = tm.Interval;
                if (!GroupBox.Enabled)
                    tm.Tick += new EventHandler(tm_TickPlus);
                else
                    tm.Tick += new EventHandler(tm_TickMinus);
                GroupBox.Enabled = !GroupBox.Enabled;
                GroupBoxIsChanging = true;
            }
        }

        void tm_TickPlus(object sender, EventArgs e)
        {
            if (Form.Height < 489)
                Form.Height = Form.Height + 10;
            else
            {
                (sender as Timer).Stop();
                Form.Height = 489;
                GroupBoxIsChanging = false;
            }
        }

        void tm_TickMinus(object sender, EventArgs e)
        {
            if (Form.Height > 304)
                Form.Height = Form.Height - 10;
            else
            {
                (sender as Timer).Stop();
                Form.Height = 304;
                GroupBoxIsChanging = false;
            }
        }

    }
}
