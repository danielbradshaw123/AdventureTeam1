﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAdventure2
{
    public partial class frm_title : Form
    {
        public frm_title()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Location1 = new Location1();
            this.Close();
            Location1.Show();
        }

        private void frm_title_Load(object sender, EventArgs e)
        {

        }

        private void Alec_Click(object sender, EventArgs e)
        {

        }
    }
}
