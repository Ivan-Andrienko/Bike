using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_2
{
    public partial class AddBike : Form
    {
        private ucCross ucCross = new ucCross();
        private ucHard ucHard = new ucHard();
        private ucHardTeil ucHardTeil = new ucHardTeil();
        public AddBike()
        {
            InitializeComponent();
            cbBikeType.Items.Add(BikeType.Cross);
            cbBikeType.Items.Add(BikeType.Hard);
            cbBikeType.Items.Add(BikeType.HardTeil);
        }
        private void AddBike_Load(object sender, EventArgs e)
        {

        }
        private void cbBikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = (BikeType)Enum.Parse(
                typeof (BikeType),
                cbBikeType.SelectedItem.ToString());
            switch (type)
            {
                case BikeType.Cross:
                    plBikeType.Controls.Clear();
                    plBikeType.Controls.Add(ucCross);
                    break;

                case BikeType.Hard:
                    plBikeType.Controls.Clear();
                    plBikeType.Controls.Add(ucHard);
                    break;

                case BikeType.HardTeil:
                    plBikeType.Controls.Clear();
                    plBikeType.Controls.Add(ucHardTeil);
                    break;
                //default:
                   // return null;
            }
        }
       // public Bike 
    }
}
