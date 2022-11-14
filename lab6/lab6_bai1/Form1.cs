using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company objcompany = new Company();
            objcompany.CompanyId = textBox1.Text;
            objcompany.Name = textBox2.Text;

            CodeFirstContext objcontext = new CodeFirstContext();
            objcontext.companies.Add(objcompany);
            objcontext.SaveChanges();
            MessageBox.Show("thành công");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
