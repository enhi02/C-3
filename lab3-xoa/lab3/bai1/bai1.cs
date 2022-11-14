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
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter x;
        DataSet data = new DataSet();

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int diem = Convert.ToInt32(txtDiemtrungbinh.Text);
                con = new SqlConnection(@"Data Source=DESKTOP-66U3G81;Initial Catalog=PS18441_lab3;Integrated Security=True");
                con.Open();
                var insertsql = @"insert into    hocsinh values ('" + txtMahocsinh.Text + "','" + txtTenhocsinh.Text + "','" + dateTimePicker1.Value.Date + "','" + texDiachi.Text + "','" + txtDiemtrungbinh.Text + "','" +comboboxLop.Text+ "')";
                SqlCommand cm = new SqlCommand(insertsql, con);
                int thongbao=(int)cm.ExecuteNonQuery();
                if (thongbao > 0)
                {
                    MessageBox.Show("tc");
                }
                else
                {
                    MessageBox.Show("tb");
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("lôi" + x.Message);
            }
            

        }

        private void bai1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=DESKTOP-66U3G81;Initial Catalog=PS18441_lab3;Integrated Security=True");
            string truyvan = @"Select * from Lop";
            SqlCommand cmd = new SqlCommand(truyvan, con);
            x = new SqlDataAdapter(truyvan, con);

            x.Fill(data, "Lop");
            comboboxLop.DisplayMember = "maLop";//ok nha
            comboboxLop.ValueMember = "MaLop";
            comboboxLop.DataSource = data.Tables["Lop"];
            //hienthiGridView();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
