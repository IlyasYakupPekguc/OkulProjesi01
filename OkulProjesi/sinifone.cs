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
    public partial class sinifOne : Form
    {
        public sinifOne()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=proje101;Integrated Security=True");
        public string email="";

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void BilProgramalama_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad = "";
            string saat = "";
            string gunler = "";
            string sube = "";
            con.Open();
            SqlCommand secim = new SqlCommand("select DersAd, DersSaat, DersGun,DersSube from Dersler where DersAd='Bilgisayar Programlama I' and DersSube='" + BilProgramalama.Text + "'", con);
            SqlDataReader secimdr = secim.ExecuteReader();
            while (secimdr.Read())
            {
                ad = secimdr[0].ToString();
                saat = secimdr[1].ToString();
                gunler = secimdr[2].ToString();
                sube = secimdr[3].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand kmt = new SqlCommand("update OgrenciBilgileri set Ders1='" + ad + " " + saat + " " + gunler + " " + sube + "' where OgrenciMail='" + email + "'", con);
            kmt.ExecuteNonQuery();
            con.Close();
        }

        private void sinifOne_Load(object sender, EventArgs e)
        {
            BilProgramalama.Items.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select DersSube from Dersler where DersAd='Bilgisayar Programlama I'",con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                BilProgramalama.Items.Add(dr1[0].ToString());
            }
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select DersSube from Dersler where DersAd='Bilgisayar Müh. Giris'", con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0].ToString());
            }
            con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select DersSube from Dersler where DersAd='Fizik I'", con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                comboBox2.Items.Add(dr3[0].ToString());
            }
            con.Close();
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select DersSube from Dersler where DersAd='English I'", con);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while (dr4.Read())
            {
                comboBox3.Items.Add(dr4[0].ToString());
            }
            con.Close();
            con.Open();
            SqlCommand cmd5 = new SqlCommand("select DersSube from Dersler where DersAd='Mathematics I'", con);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while (dr5.Read())
            {
                comboBox4.Items.Add(dr5[0].ToString());
            }
            con.Close();
            con.Open();
            SqlCommand cmd6 = new SqlCommand("select DersSube from Dersler where DersAd='Lineer Cebir'", con);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while (dr6.Read())
            {
                comboBox6.Items.Add(dr6[0].ToString());
            }
            con.Close();
            con.Open();
            SqlCommand cmd7 = new SqlCommand("select DersSube from Dersler where DersAd='Atatürk Ilkeleri I'", con);
            SqlDataReader dr7 = cmd7.ExecuteReader();
            while (dr7.Read())
            {
                comboBox5.Items.Add(dr7[0].ToString());
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad = "";
            string saat = "";
            string gunler = "";
            string sube = "";
            con.Open();
            SqlCommand secim = new SqlCommand("select DersAd, DersSaat, DersGun,DersSube from Dersler where DersAd='Bilgisayar Müh. Giris' and DersSube='" +comboBox1.Text + "'", con);
            SqlDataReader secimdr = secim.ExecuteReader();
            while (secimdr.Read())
            {
                ad = secimdr[0].ToString();
                saat = secimdr[1].ToString();
                gunler = secimdr[2].ToString();
                sube = secimdr[3].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand kmt = new SqlCommand("update OgrenciBilgileri set Ders2='" + ad + " " + saat + " " + gunler + " " + sube + "' where OgrenciMail='" + email + "'", con);
            kmt.ExecuteNonQuery();
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad = "";
            string saat = "";
            string gunler = "";
            string sube = "";
            con.Open();
            SqlCommand secim = new SqlCommand("select DersAd, DersSaat, DersGun,DersSube from Dersler where DersAd='Fizik I' and DersSube='" + comboBox2.Text + "'", con);
            SqlDataReader secimdr = secim.ExecuteReader();
            while (secimdr.Read())
            {
                ad = secimdr[0].ToString();
                saat = secimdr[1].ToString();
                gunler = secimdr[2].ToString();
                sube = secimdr[3].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand kmt = new SqlCommand("update OgrenciBilgileri set Ders3='" + ad + " " + saat + " " + gunler + " " + sube + "' where OgrenciMail='" + email + "'", con);
            kmt.ExecuteNonQuery();
            con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ad = "";
            string saat = "";
            string gunler = "";
            string sube = "";
            con.Open();
            SqlCommand secim = new SqlCommand("select DersAd, DersSaat, DersGun,DersSube from Dersler where DersAd='English I' and DersSube='" + comboBox3.Text + "'", con);
            SqlDataReader secimdr = secim.ExecuteReader();
            while (secimdr.Read())
            {
                ad = secimdr[0].ToString();
                saat = secimdr[1].ToString();
                gunler = secimdr[2].ToString();
                sube = secimdr[3].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand kmt = new SqlCommand("update OgrenciBilgileri set Ders4='" + ad + " " + saat + " " + gunler + " " + sube + "' where OgrenciMail='" + email + "'", con);
            kmt.ExecuteNonQuery();
            con.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ad = "";
            string saat = "";
            string gunler = "";
            string sube = "";
            con.Open();
            SqlCommand secim = new SqlCommand("select DersAd, DersSaat, DersGun,DersSube from Dersler where DersAd='Mathematics I' and DersSube='" + comboBox4.Text + "'", con);
            SqlDataReader secimdr = secim.ExecuteReader();
            while (secimdr.Read())
            {
                ad = secimdr[0].ToString();
                saat = secimdr[1].ToString();
                gunler = secimdr[2].ToString();
                sube = secimdr[3].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand kmt = new SqlCommand("update OgrenciBilgileri set Ders5='" + ad + " " + saat + " " + gunler + " " + sube + "' where OgrenciMail='" + email + "'", con);
            kmt.ExecuteNonQuery();
            con.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ad = "";
            string saat = "";
            string gunler = "";
            string sube = "";
            con.Open();
            SqlCommand secim = new SqlCommand("select DersAd, DersSaat, DersGun,DersSube from Dersler where DersAd='Lineer Cebir' and DersSube='" + comboBox6.Text + "'", con);
            SqlDataReader secimdr = secim.ExecuteReader();
            while (secimdr.Read())
            {
                ad = secimdr[0].ToString();
                saat = secimdr[1].ToString();
                gunler = secimdr[2].ToString();
                sube = secimdr[3].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand kmt = new SqlCommand("update OgrenciBilgileri set Ders6='" + ad + " " + saat + " " + gunler + " " + sube + "' where OgrenciMail='" + email + "'", con);
            kmt.ExecuteNonQuery();
            con.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

            string ad = "";
            string saat = "";
            string gunler = "";
            string sube = "";
            con.Open();
            SqlCommand secim = new SqlCommand("select DersAd, DersSaat, DersGun,DersSube from Dersler where DersAd='Atatürk İlkeleri I' and DersSube='" + comboBox5.Text + "'", con);
            SqlDataReader secimdr = secim.ExecuteReader();
            while (secimdr.Read())
            {
                ad = secimdr[0].ToString();
                saat = secimdr[1].ToString();
                gunler = secimdr[2].ToString();
                sube = secimdr[3].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand kmt = new SqlCommand("update OgrenciBilgileri set Ders6='" + ad + " " + saat + " " + gunler + " " + sube + "' where OgrenciMail='" + email + "'", con);
            kmt.ExecuteNonQuery();
            con.Close();
        }
    }
}
