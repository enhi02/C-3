using bai3;
using lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class bai4 : Form
    {
        public bai4()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai1 frm = new bai1();
            frm.Show();
        }

        private void bai2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai2 frm = new bai2();
            frm.Show();
        }

        private void bai3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
