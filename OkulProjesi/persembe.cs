using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProjesi
{
    public partial class persembe : Form
    {
        public persembe()
        {
            InitializeComponent();
        }

        private void label66_Click(object sender, EventArgs e)
        {
            new DersSinifProgrami().Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
