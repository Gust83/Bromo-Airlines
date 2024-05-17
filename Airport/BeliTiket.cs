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
    public partial class BeliTiket : Form
    {
        public BeliTiket()
        {
            InitializeComponent();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            List form = new List();
            form.ShowDialog();
        }
    }
}
