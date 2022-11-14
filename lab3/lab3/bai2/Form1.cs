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


namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter x;
        DataSet data = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-66U3G81;Initial Catalog=PS18441_lab3;Integrated Security=True");
            string truyvan = @"Select * from Lop";
       
            x = new SqlDataAdapter(truyvan, con); 
           
            x.Fill(data, "Lop"); 
            comboBox1.DisplayMember = "TenLop"; 
            comboBox1.ValueMember = "MaLop";
            comboBox1.DataSource = data.Tables["Lop"];           
            hienthiGridView(); 
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vitri = dataGridView1.CurrentCell.RowIndex;
            data.Tables["HocSinh"].Rows[vitri].Delete();
            SqlCommandBuilder scb = new SqlCommandBuilder(x);
            x.Update(data.Tables["HocSinh"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = data.Tables["HocSinh"].NewRow();
            row["MaHS"] = textBox1.Text;
            row["TenHS"] = textBox2.Text;
            row["NgaySinh"] = dateTimePicker1.Text.ToString();
            row["DiaChi"] = textBox3.Text;
            row["DTB"] = textBox4.Text;
            row["MaLop"] = comboBox1.SelectedValue;
            data.Tables["HocSinh"].Rows.Add(row);
            SqlCommandBuilder hs = new SqlCommandBuilder(x);
            x.Update(data.Tables["HocSinh"]);

        }
        void hienthiGridView()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-66U3G81;Initial Catalog=PS18441_lab3;Integrated Security=True");
            string truyvanhs = @"select * from HocSinh";
            x = new SqlDataAdapter(truyvanhs, con);
            x.Fill(data, "HocSinh");

            dataGridView1.DataSource = data.Tables["HocSinh"];

        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            textBox3.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
            comboBox1.SelectedValue = row.Cells[5].Value.ToString();
        }
    }
}
