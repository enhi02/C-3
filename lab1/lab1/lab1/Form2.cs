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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban That Su Muon Thoat Ung Dung? Yes or No","",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            { Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked )
            {
                //textBox1.Text = "UCLN";
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int i;
                int Min;
                if (a > b) { Min = b; }
                else { Min = a; }
                for (i = Min; i > 1; i++)
                {
                    if ((a % i) == 0 && (b % i) == 0)
                    {
                        textBox3.Text = i.ToString();
                        break;
                    }
                    //else
                    //{
                    //    textBox3.Text = ((a * b) / i).ToString();
                    //    textBox3.Text = "BCNN";
                    //}
                }
            }
            else
            {
                int a = int.Parse(textBox1.Text); 
                int b = int.Parse(textBox2.Text);
                int i = a * b;

                textBox3.Text = i.ToString();
            }

        }
    }
}
