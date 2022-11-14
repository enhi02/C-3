using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2(string text)
        {
            InitializeComponent();
        }
        void hienthi()
        {
            using (thiEntities db = new thiEntities())
            {
                dataGridView1.DataSource =
                    (from x in db.NhanViens

                     select new
                     {
                         Mã = x.maNV,
                         Name = x.hoTenNV,
                         GioiTinh = x.GioiTinh,
                         Hinh = x.hinh,
                         VaiTro = x.vaitro
                     }).ToList();
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

       void xoa()
        {
            using(thiEntities db = new thiEntities())
            {
                string hinh;
                hinh = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pictureBox1.Image = Image.FromFile(@"D:\img\" + hinh);
                var xoa = db.NhanViens.Where(x => x.hinh == hinh).FirstOrDefault();
                if(xoa != null)
                {
                    db.NhanViens.Remove(xoa);
                }
                db.SaveChanges();
            }
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string hinh;
            hinh = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            pictureBox1.Image = Image.FromFile(@"D:\img\" + hinh);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)//xoa
        {
            xoa();
        }
    }
}
