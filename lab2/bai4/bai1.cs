using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//thoát
        {
            Close();
        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)// tính
        {
            int a = int.Parse(textBox1.Text);//chỉ số cũ
            int b = int.Parse(textBox7.Text);//chỉ số mới


            int tong;
            tong = b - a;
            textBox3.Text = tong.ToString();//số kw tiêu thụ
            int x = 50;
            textBox5.Text = x.ToString();//số kw trong định mức 
            int y = tong - 50;
            textBox6.Text = y.ToString();//số kw vượt định mức
            int sum = 50 * 500;
            int suum = y * 1000;
            int tongtien = sum + suum;
            textBox4.Text = tongtien.ToString();//tổng tiền phải chi trả
        }

        private void button2_Click(object sender, EventArgs e)//in
        {
            richTextBox1.Text = "Tên :" + (comboBox1.Text).ToString() + "\nSố Kw Tiêu Thụ :" + (textBox3.Text).ToString() + "\nTổng Tiền :" + (textBox4.Text).ToString();
        }
    }
}
