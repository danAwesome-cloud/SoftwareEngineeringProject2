﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareEngineeringProject2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            DBConnectionClass.getInstanceOfDBConnection().LoginDB(tbUsername.Text, tbPassword.Text);
            this.Hide();
            new CreatorMenu().Show();
        }
    }
}
