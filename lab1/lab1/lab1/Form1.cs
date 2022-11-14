using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int tong = n + m;
            textBox3.Text = tong.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int tong = n - m;
            textBox3.Text = tong.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int tong = n * m;
            textBox3.Text = tong.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            int m = int.Parse(textBox2.Text);
            int tong = n / m;
            textBox3.Text = tong.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
