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
        SqlConnection con  = new SqlConnection(@"Data Source=DESKTOP-66U3G81;Initial Catalog=PS18441_lab3;Integrated Security=True");
        SqlDataAdapter ada;
        DataSet data = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            string truyvan = @"Select * from Lop";
            SqlCommand cmd = new SqlCommand(truyvan, con);
            ada = new SqlDataAdapter(truyvan, con);

            ada.Fill(data, "Lop"); 
            cblop.DisplayMember = "maLop"; 
            cblop.ValueMember = "MaLop";
            cblop.DataSource = data.Tables["Lop"];           
            hienthiGridView(); 
        }


        private void button3_Click(object sender, EventArgs e)//Thoát
        {
            Close();
        }
        public void load()
        {
            con.Open();
            var thongtin = "select * from hocsinh";
            SqlDataAdapter dt = new SqlDataAdapter(thongtin, con);
            DataTable tb = new DataTable();
            dt.Fill(tb);
            dataGridView1.DataSource = tb;

        }

        private void button2_Click(object sender, EventArgs e)//Xóa
        {
            int vitri = dataGridView1.CurrentCell.RowIndex;
            data.Tables["HocSinh"].Rows[vitri].Delete();
            SqlCommandBuilder scb = new SqlCommandBuilder();
            ada.Update(data.Tables["HocSinh"]);
        }

        private void button1_Click(object sender, EventArgs e)//Lưu
        {
            string query = "select * from hocsinh";
            ada = new SqlDataAdapter(query, con);


            DataRow row = data.Tables["hocsinh"].NewRow();
            row["mahocsinh"] = textBox1.Text;
            row["tenhs"] = tbten.Text;
            row["ngaysinh"] = pktime.Value.ToString("yyyy/MM/dd");
            row["diachi"] = diachi.Text;
            row["dtb"] = tbdiem.Text;
            row["malop"] = cblop.SelectedValue.ToString();
            try
            {
                data.Tables["hocsinh"].Rows.Add(row);
                SqlCommandBuilder builder = new SqlCommandBuilder(ada);
                ada.Update(data.Tables["hocsinh"]);

                MessageBox.Show("Save success!");
            }
            catch
            {
                MessageBox.Show("Save Error!");
                data.Tables["hocsinh"].Rows.Remove(row);
            }

            //["MaHS"] = textBox1.Text;
            //row["TenHS"] = tbten.Text;
            //row["NgaySinh"] = pktime.Text.ToString();
            //row["DiaChi"] = tbdiachi.Text;
            //row["DTB"] = tbdiem.Text;
            //row["MaLop"] = cblop.SelectedValue;
            //data.Tables["HocSinh"].Rows.Add(row);
            //SqlCommand hs = new SqlCommand(row.ToString(),con);
            //hs.Updated(data.Tables["HocSinh"]);
            //MessageBox.Show("tc");

        }
        void hienthiGridView()
        {
            string truyvanhs = @"select * from HocSinh";
            ada = new SqlDataAdapter(truyvanhs, con);
            ada.Fill(data, "HocSinh");

            dataGridView1.DataSource = data.Tables["HocSinh"];

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            tbten.Text = row.Cells[1].Value.ToString();
            pktime.Value = DateTime.Parse(row.Cells[2].Value.ToString());
            diachi.Text = row.Cells[3].Value.ToString();
            tbdiem.Text = row.Cells[4].Value.ToString();
            cblop.SelectedValue = row.Cells[5].Value.ToString();
        }
    }
}
