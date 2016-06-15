using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_2
{
    public partial class ucCross : UserControl
    {
        //public string Wheel { get; private set; }

        public ucCross()
        {
            InitializeComponent();
        }

        private void ucCross_Load(object sender, EventArgs e)
        {

        }
        public Cross GetCross()
        {
            return new Cross {
               // Name = tbName.Text;
                Wheel = tbWheel.Text,
                SpeedCount = tbSpeedCount.Text,
                Color = cbColor.Text
            };
        }
    }
}
