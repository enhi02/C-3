using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;
using DTO_QuanLY;

namespace Lab7_QuanLyThanhVien
{
    public partial class GUI_THANHVIEN : Form
    {
        BUS_ThanhVien busTv = new BUS_ThanhVien();

        public GUI_THANHVIEN()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txb_email.Text) &&
                !string.IsNullOrEmpty(txb_name.Text) &&
                !string.IsNullOrEmpty(txb_sdt.Text))
            {
                DTO_ThanhVien tv = new DTO_ThanhVien(0, txb_name.Text, txb_sdt.Text, txb_email.Text);

                if(busTv.themThanhVien(tv))
                {
                    MessageBox.Show("Thêm thành công");
                    dataGridView1.DataSource = busTv.getThanhVien();
                }
                else
                {
                    MessageBox.Show("thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("hãy nhập đầy đủ");
            }
        }

        private void GUI_THANHVIEN_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busTv.getThanhVien();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if (!string.IsNullOrEmpty(txb_email.Text) &&
                !string.IsNullOrEmpty(txb_name.Text) &&
                !string.IsNullOrEmpty(txb_sdt.Text))
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    int id = Convert.ToInt16(row.Cells[0].Value.ToString());

                    DTO_ThanhVien tv = new DTO_ThanhVien(id, txb_name.Text, txb_sdt.Text, txb_email.Text);

                    if (busTv.suaThanhVien(tv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dataGridView1.DataSource = busTv.getThanhVien();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("hãy chọn thành viên bạn muốn sửa");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                int id = Convert.ToInt32(row.Cells[0].Value.ToString());

                if (busTv.xoaThanhVien(id))
                {
                    MessageBox.Show("xóa thành công");
                    dataGridView1.DataSource = busTv.getThanhVien();
                }
                else
                {
                    MessageBox.Show("xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("hãy chọn thành viên muốn xóa");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count >0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                txb_name.Text = row.Cells[1].Value.ToString();
                txb_sdt.Text = row.Cells[2].Value.ToString();
                txb_email.Text = row.Cells[3].Value.ToString();
            }
            
        }
    }
}
