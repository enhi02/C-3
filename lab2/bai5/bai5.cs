using lab2;
using bai3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai5
{
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)//bài 1
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)//bài 2
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)//bài 3
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bai1 frm = new bai1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bai2 frm = new bai2();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
