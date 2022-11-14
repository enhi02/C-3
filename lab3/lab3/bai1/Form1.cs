using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        SqlConnection ketnoi;
        SqlDataAdapter x;
        DataSet data = new DataSet();
        SqlCommand comand;


        private void Form1_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(@"Data Source=DESKTOP-66U3G81;Initial Catalog=PS18441_lab3;Integrated Security=True");
            ketnoi.Open();
            string truyvan = @"Select * from Lop";
            x = new SqlDataAdapter(truyvan, ketnoi);
            x.Fill(data, "Lop");
            comboBox1.DisplayMember = "Tenlop";
            comboBox1.ValueMember = "MaLop";
            comboBox1.DataSource = data.Tables["Lop"];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(@"Data Source=DESKTOP-66U3G81;Initial Catalog=PS18441_lab3;Integrated Security=True");
            string truyvan = @"Select * from HocSinh";
            comand = new SqlCommand(truyvan, ketnoi);
            x = new SqlDataAdapter(comand);
            x.Fill(data, "HocSinh");


            DataRow row = data.Tables["HocSinh"].NewRow();
            row["MaHS"] = textBox1.Text;
            row["TenHS"] = textBox2.Text;
            row["NgaySinh"] = dateTimePicker1.Value.ToString();
            row["DiaChi"] = textBox4.Text;
            row["DTB"] = textBox6.Text;
            row["MaLop"] = comboBox1.SelectedValue;
            data.Tables["HocSinh"].Rows.Add(row);
            SqlCommandBuilder hs = new SqlCommandBuilder(x);
            x.Update(data.Tables["HocSinh"]);
            MessageBox.Show("Cập Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";            
            textBox4.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";

            
        }
    }
}
