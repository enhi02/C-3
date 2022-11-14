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
    public partial class bai2 : Form
    {
        public bai2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//nhập
        {
            if (comboBox1.Text != "")
            {
                string text;
                text = comboBox1.Text + "\r\n";
                text += tbtime1.Text + "\t" + tbtime2.Text + "\r\n";
                text += "Môn chọn : \r\n";
                for (int i = 0; i < lbchon.Items.Count; i++)
                {
                    text += lbchon.Items[i];
                    if (i < lbchon.Items.Count - 1)
                    {
                        text += " , ";
                    }
                    else
                    {
                        text += " . ";
                    }

                }
                textBox1.Text = text;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//thoát
        {
            Close();
        }

        private void BUTReset_Click(object sender, EventArgs e)//reset
        {
            textBox1.ResetText();
            lbchon.Items.Clear();
            textBox1.ResetText();
            tbtime1.ResetText();
            comboBox1.ResetText();
        }

        private void tbtime1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)//time
        {
            tbtime1.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tbtime2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click_2(object sender, EventArgs e)//>>
        {
            for (int i = 0; i < lbdanhsach.Items.Count; i++)
            {
                lbchon.Items.Add(lbdanhsach.Items[i]);
            }
            lbdanhsach.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)//>
        {
            lbchon.Items.Add(lbdanhsach.SelectedItem);
            lbdanhsach.Items.Remove(lbdanhsach.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)//<<
        {
            for (int i = 0; i < lbchon.Items.Count; i++)
            {
                lbdanhsach.Items.Add(lbchon.Items[i]);
            }
            lbchon.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)//<
        {
            lbdanhsach.Items.Add(lbchon.SelectedItem);
            lbchon.Items.Remove(lbchon.SelectedItem);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
