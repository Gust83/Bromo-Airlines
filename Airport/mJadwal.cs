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
    public partial class mJadwal : Form
    {
        public mJadwal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mJadwal_Load(object sender, EventArgs e)
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
            mJadwal form = new mJadwal();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mKode form = new mKode();
            form.ShowDialog();
        }

        private void ubahStatusPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mStatus form = new mStatus();
            form.ShowDialog();
        }

        private void masterJadwalToolStripMenuItem_Click(object sender, EventArgs e)
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
