﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight
{
    public partial class Logging : Form
    {
        public Logging()
        {
            InitializeComponent();
        }

        private void Logging_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
