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
    public partial class coreForm : Form
    {
        public coreForm()
        {
            InitializeComponent();
            //scContain.Panel2.Controls.Add(new ucCross());
        }

        private void bikeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void coreForm_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBike ab = new AddBike();
            if(ab.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void remoweToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openSavedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coreForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Goodbye.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
