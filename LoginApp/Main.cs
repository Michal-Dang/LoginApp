﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
