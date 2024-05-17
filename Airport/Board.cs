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
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(menuStrip1.Visible == false)
            {
                menuStrip1.Visible = true;
            }
            else
            {
                menuStrip1.Visible=false;
            }

            if(button2.Visible == false)
            {
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log form = new Log();
            form.ShowDialog();
        }         
    

        private void MasterBandaraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Bandara form = new Bandara();
            form.ShowDialog();
        }

        private void ubahStatusPToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            mStatus form = new mStatus();
            form.ShowDialog();
        }

        private void masterJadwalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mJadwal form = new mJadwal();
            form.ShowDialog();
        }

        private void iriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mMaskapai form = new mMaskapai();
            form.ShowDialog();
        }

        private void masterKodePromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            mKode form = new mKode();
            form.ShowDialog();
        }
    }
}
