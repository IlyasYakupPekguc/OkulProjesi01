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
    public partial class OgretmenSinifSecimi : Form
    {
        public OgretmenSinifSecimi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new öğrdersoluşturma().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new DersOlusturma2().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new OgretmenDersSecimi3().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new OgretmenDersSecimi4().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
