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
            if (SifreTekrarOgren.Text != string.Empty || SifreOgren.Text != string.Empty || Email.Text != string.Empty)
            {
                if (SifreOgren.Text == SifreTekrarOgren.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from OgrenciBilgileri where Email='" + Email.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into OgrenciBilgileri values(@Email,@SifreOgren)", cn);
                        cmd.Parameters.AddWithValue("username", Email.Text);
                        cmd.Parameters.AddWithValue("password", SifreOgren.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        new Anasayfa().Show();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
