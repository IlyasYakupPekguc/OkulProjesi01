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
    public partial class Kayıt : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=proje101;Integrated Security=True");
        
        public Kayıt()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.Open();
            if (SifreTekrarOgren.Text != string.Empty || Sifre.Text != string.Empty || OgrenciMail.Text != string.Empty)
            {
                if (Sifre.Text == SifreTekrarOgren.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from OgrenciBilgileri where OgrenciMail='" + OgrenciMail.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into OgrenciBilgileri (OgrenciMail,Sifre,AdSoyad,okulNo) values('"+OgrenciMail.Text+"',@Sifre,@w1,@w2)", cn);
                        cmd.Parameters.AddWithValue("@OgrenciMail", OgrenciMail.Text);
                        cmd.Parameters.AddWithValue("@Sifre", Sifre.Text);
                        cmd.Parameters.AddWithValue("@w1",AdSoyad.Text);
                        cmd.Parameters.AddWithValue("@w2", okulNo.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        new Login().Show();
                        this.Hide();
                        cn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen aynı şifreyi giriniz. ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bütün alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

    }
}
