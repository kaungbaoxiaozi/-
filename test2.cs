﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Manager
{
    public partial class test2 : Form
    {
        public test2()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
        }

        private void open_FileOk(object sender, CancelEventArgs e)
        {
            player.URL = open.FileName;
        }
    }
}
