using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetClub
{
    class ButtonSorter
    {
        public List<Button> SortButts(Control.ControlCollection ctrls)
        {
            List<Button> btlist = new List<Button>();
            foreach (Control ctrl in ctrls)
            {
                if (ctrl is Button)
                    btlist.Add(ctrl as Button);
            }
            btlist.Sort(new Comparison<Button>(ComparerTabIndex));
            return btlist;
        }

        private int ComparerTabIndex(Button c1, Button c2)
        {
            return c1.TabIndex.CompareTo(c2.TabIndex);
        }
    }
}
