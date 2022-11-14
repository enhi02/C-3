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

namespace ps18264_ASM_C3
{
    public partial class DangNhap : Form
    {

        public DangNhap()
        {
            InitializeComponent();
        }
 
        private void btLogin_Click(object sender, EventArgs e)
        {
            using (ASM_C3Entities db = new ASM_C3Entities())
            {
                var user = db.users_login.Where(x => x.username == txtTaiKhoan.Text && x.passwork == txtMatKhau.Text).Select(x => x).FirstOrDefault();
                if (user == null)
                {
                    MessageBox.Show("Sai tài khoản hoăc mật khẩu!");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    if (user.roles == "canbo")
                    {
                        
                        this.Hide();
                        QuanLySV frm_cb = new QuanLySV();
                        frm_cb.ShowDialog();
                        this.Show();
                    }
                    else if (user.roles == "giangvien")
                    {
                        this.Hide();
                        QuanLyDiem frm_gv = new QuanLyDiem();
                        frm_gv.ShowDialog();
                        this.Show();
                    }
                }
            }
        }

        

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();//dùng để hiển thị ngay textbox username
            txtMatKhau.Focus();
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //MessageBox.Show("Ban co muon thoat khoi chuong trinh?", "Xac Nhan", MessageBox.YesNo, MessageBox.Question);
        }

        private void grbLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
