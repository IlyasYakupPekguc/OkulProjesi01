﻿using System;
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
    public partial class DersOlusturma2 : Form
    {
        public DersOlusturma2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=proje101;Integrated Security=True");
        private void DersOlusturma2_Load(object sender, EventArgs e)
        {
            string[] gunler = { "Pazartesi", "Sali", "Carsamba", "Persembe", "Cuma" };
            foreach (string g in gunler)
            {
                comboBox5.Items.Add(g);
                comboBox8.Items.Add(g);
                comboBox2.Items.Add(g);
                comboBox11.Items.Add(g);
                comboBox14.Items.Add(g);
                comboBox17.Items.Add(g);
                comboBox20.Items.Add(g);

            }
            string[] saatler = { "8.30 - 10.20 ", "10.30 - 12.20", "13.30 - 15.20", "15.30 - 17.20", "17.30 - 19.20" };
            foreach (string g in saatler)
            {
                comboBox4.Items.Add(g);
                comboBox7.Items.Add(g);
                comboBox3.Items.Add(g);
                comboBox10.Items.Add(g);
                comboBox13.Items.Add(g);
                comboBox16.Items.Add(g);
                comboBox19.Items.Add(g);
            }
            string[] sube = { "1. Şube", "2. Şube", "3. Şube", "4. Şube", "5. Şube" };
            foreach (string g in sube)
            {
                comboBox6.Items.Add(g);
                comboBox9.Items.Add(g);
                comboBox1.Items.Add(g);
                comboBox12.Items.Add(g);
                comboBox15.Items.Add(g);
                comboBox18.Items.Add(g);
                comboBox21.Items.Add(g);
            }
        }

        private void Kaydet1_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = "";

            SqlCommand KOMUT = new SqlCommand("select DersID from Dersler2 where DersAd='Data Structures'", con);
            SqlDataReader KOMUTr = KOMUT.ExecuteReader();
            while (KOMUTr.Read())
            {
                id = KOMUTr[0].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("update Dersler2 set DersGun=@a1 , DersSaat=@a2 where DersID='" + id + "'", con);
            sqlCommand.Parameters.AddWithValue("@a1", comboBox5.Text);
            sqlCommand.Parameters.AddWithValue("@a2", comboBox4.Text);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //burası kaydet3

            con.Open();
            string id = "";

            SqlCommand KOMUT = new SqlCommand("select DersID from Dersler2 where DersAd='Elektrik ve Elektronik Devreleri'", con);
            SqlDataReader KOMUTr = KOMUT.ExecuteReader();
            while (KOMUTr.Read())
            {
                id = KOMUTr[0].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("update Dersler2 set DersGun=@a1 , DersSaat=@a2 where DersID='" + id + "'", con);
            sqlCommand.Parameters.AddWithValue("@a1", comboBox2.Text);
            sqlCommand.Parameters.AddWithValue("@a2", comboBox3.Text);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        private void Kaydet2_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = "";

            SqlCommand KOMUT = new SqlCommand("select DersID from Dersler2 where DersAd='Olasılık ve İstatistik'", con);
            SqlDataReader KOMUTr = KOMUT.ExecuteReader();
            while (KOMUTr.Read())
            {
                id = KOMUTr[0].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("update Dersler2 set DersGun=@a1 , DersSaat=@a2 where DersID='" + id + "'", con);
            sqlCommand.Parameters.AddWithValue("@a1", comboBox8.Text);
            sqlCommand.Parameters.AddWithValue("@a2", comboBox7.Text);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        private void Kaydet4_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = "";

            SqlCommand KOMUT = new SqlCommand("select DersID from Dersler2 where DersAd='Object Oriented Programming'", con);
            SqlDataReader KOMUTr = KOMUT.ExecuteReader();
            while (KOMUTr.Read())
            {
                id = KOMUTr[0].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("update Dersler2 set DersGun=@a1 , DersSaat=@a2 where DersID='" + id + "'", con);
            sqlCommand.Parameters.AddWithValue("@a1", comboBox11.Text);
            sqlCommand.Parameters.AddWithValue("@a2", comboBox10.Text);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        private void Kaydet5_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = "";

            SqlCommand KOMUT = new SqlCommand("select DersID from Dersler2 where DersAd='Differantial Equations'", con);
            SqlDataReader KOMUTr = KOMUT.ExecuteReader();
            while (KOMUTr.Read())
            {
                id = KOMUTr[0].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("update Dersler2 set DersGun=@a1 , DersSaat=@a2 where DersID='" + id + "'", con);
            sqlCommand.Parameters.AddWithValue("@a1", comboBox14.Text);
            sqlCommand.Parameters.AddWithValue("@a2", comboBox13.Text);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        private void Kaydet6_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = "";

            SqlCommand KOMUT = new SqlCommand("select DersID from Dersler2 where DersAd='Türk Dili I'", con);
            SqlDataReader KOMUTr = KOMUT.ExecuteReader();
            while (KOMUTr.Read())
            {
                id = KOMUTr[0].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("update Dersler2 set DersGun=@a1 , DersSaat=@a2 where DersID='" + id + "'", con);
            sqlCommand.Parameters.AddWithValue("@a1", comboBox17.Text);
            sqlCommand.Parameters.AddWithValue("@a2", comboBox16.Text);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        private void Kaydet7_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = "";

            SqlCommand KOMUT = new SqlCommand("select DersID from Dersler2 where DersAd='Academic English I'", con);
            SqlDataReader KOMUTr = KOMUT.ExecuteReader();
            while (KOMUTr.Read())
            {
                id = KOMUTr[0].ToString();
            }
            con.Close();
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("update Dersler2 set DersGun=@a1 , DersSaat=@a2 where DersID='" + id + "'", con);
            sqlCommand.Parameters.AddWithValue("@a1", comboBox20.Text);
            sqlCommand.Parameters.AddWithValue("@a2", comboBox19.Text);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OgretmenSinifSecimi().Show();
            this.Hide();
        }
    }
}