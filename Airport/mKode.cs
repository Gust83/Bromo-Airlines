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
    public partial class mKode : Form
    {
        public mKode()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
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
        {
            this.Hide();
            mJadwal form = new mJadwal();
            form.ShowDialog();
        }

        private void ubahStatusPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mStatus form = new mStatus();
            form.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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
