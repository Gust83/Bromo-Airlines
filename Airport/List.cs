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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void list_load(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            BeliTiket form = new BeliTiket();
            form.ShowDialog();
            
        }

        private void List_Load_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(" IP - 0209", "Pelita Air", "Juanda", "Soekarno Hatta", "634.000", "24-05-2023", "15:10 - 21:45");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Costumer form = new Costumer();
            form.ShowDialog();
          
        }
    }
}
