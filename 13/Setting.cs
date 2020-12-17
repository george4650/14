﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Cols = Convert.ToInt32(nudCol.Value);
            Data.Rows = Convert.ToInt32(nudRow.Value);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            nudCol.Value = Data.Cols;
            nudRow.Value = Data.Rows;
        }
    }
}
