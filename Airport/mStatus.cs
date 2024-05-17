using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airport
{
    public partial class mStatus : Form
    {
        public mStatus()
        {
            InitializeComponent();
        }

        private void ubahStatusPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void omoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bandara form = new Bandara();
            form.ShowDialog();
        }

        private void iriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mMaskapai form = new mMaskapai();
            form.ShowDialog();
        }

        private void masterJadwalToolStripMenuItem_Click(object sender, EventArgs e)
        {this.Hide();
            mJadwal form = new mJadwal();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {this.Hide();           
            mKode form = new mKode();
            form.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log form = new Log();
            form.ShowDialog();
        }
    }
}
