﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using World_Game.function;

namespace World_Game
{
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
        }

        private void staff_Load(object sender, EventArgs e)
        {

        }

        private void SerachMenu_Click(object sender, EventArgs e)
        {
            search sea = new search();
            sea.Show();
            this.Hide();
        }
    }
}
