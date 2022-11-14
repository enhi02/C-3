using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                String tong = "";
                if (a == 0)
                {                    
                    if (b ==0)
                    {
                        textBox4.Text = tong = "PT co vo so Nghiem";
                    }
                    else
                    {
                        textBox4.Text = tong = "PT vo Nghiem";
                    }
                }
                else
                {
                    textBox4.Text = tong = "PT co Nghiem :  " + (-b / a).ToString(); 
                }                
            }
            else
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                int c = int.Parse(textBox3.Text);
                float d ;
                
                string tong = "";
                if(a == 0)
                {
                    if(b == 0 && c == 0)
                    {
                        textBox4.Text = tong = "PT co vo so Nghiem";
                    }
                    else if(b == 0 && c!= 0)
                    {
                        textBox4.Text = tong = "PT vo Nghiem";
                    }
                   
                }
                else
                {
                    d = (b * b) - 4 * a * c;
                    if (d < 0)
                    {
                        textBox4.Text = tong = "PT vo Nghiem";
                    }
                    else if(d == 0)
                    {
                        textBox4.Text = tong = "PT co Nghiem Kep: x1 = x2 =  " + (-b/2*a).ToString();
                    }
                    else
                    {
                        textBox4.Text = tong = "Co 2 Nghiem phan biet : "
                        + "x1 = " + (Math.Round(-b - (- Math.Sqrt(d)) / (2 * a)),2).ToString()
                        + "  x2 = " + (Math.Round(-b - (-Math.Sqrt(d)) / (2 * a)),2).ToString();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
