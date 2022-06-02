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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DersSinifProgrami().Show();
            this.Close();
            //burada hata olustu ne olduna dair bir fikrim yoktu dersone mı ne yazıyordu.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Anasayfa().Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
