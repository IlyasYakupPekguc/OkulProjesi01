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
    public partial class DersSinifProgrami : Form
    {
       
        public DersSinifProgrami()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new Pazartesi().Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Sali().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            new cuma().Show();
            this.Hide();
        }
    }
}
