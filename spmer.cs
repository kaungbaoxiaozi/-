using System;
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
    public partial class spmer : Form
    {
        public spmer()
        {
            InitializeComponent();
        }

        private void spmer_FormClosed(object sender, FormClosedEventArgs e)
        {
            main mai = (main)this.Owner;
            mai.spre();
        }
    }
}
