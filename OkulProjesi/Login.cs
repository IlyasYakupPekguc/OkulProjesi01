using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OkulProjesi
{
    public partial class Login : Form
    {
        String sqlStr = "";
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=proje101;Integrated Security=True");
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=proje101;Integrated Security=True");
        

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textUserName.Clear();   
            textPassword.Clear();
            textUserName.Focus();
            OgrenciSifre.Clear();
            OgrenciAd.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlStr = "Select * from OgretmenBilgileri where KullaniciAdi='" + textUserName.Text + "' and Sifre='" + textPassword.Text + "'";

            conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlStr, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {
                new öğrdersoluşturma().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Şifreniz veya kullanıcı adınız hatalı. Lütfen yeniden deneyin.");
                textUserName.Clear();   
                textPassword.Clear();
                textUserName.Focus();
            }
            
            conn.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            sqlStr = "Select * from OgrenciBilgileri where OgrenciMail='" + OgrenciAd.Text + "' and Sifre='" + OgrenciSifre.Text + "'";

            conn.Open();
            SqlCommand cmd1 = new SqlCommand(sqlStr, conn);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            if (dr1.Read())
            {
                new Anasayfa().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Şifreniz veya kullanıcı adınız hatalı. Lütfen yeniden deneyin.");
                OgrenciAd.Clear();
                OgrenciSifre.Clear();
                textUserName.Focus();
            }

            conn.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
            //new Anasayfa().Show();
            //this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Kayıt().Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}