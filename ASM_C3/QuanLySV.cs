using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ps18264_ASM_C3
{
    public partial class QuanLySV : Form
    {
        ASM_C3Entities db = new ASM_C3Entities();
        public QuanLySV()
        {
            InitializeComponent();
            hienthi();
        }

        void hienthi()
        {
            using (ASM_C3Entities db = new ASM_C3Entities())
            {
                dataGridView1.DataSource =
                    (from x in db.Students

                     select new
                     {
                         MASV = x.MASV,
                         Name = x.HoTen,
                         Email = x.Email,
                         SĐT = x.SDT,
                         GioiTinh = x.GioiTinh,
                         Địa_Chỉ = x.DiaChi,
                         Hinh = x.Hinh

                     }).ToList();
            }
        }
        string hinh;
        //void dongbo()
        //{
        //    textBoxMASV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        //    textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        //    textBoxEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        //    textBoxSDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        //    var gioitinh = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        //    textBoxDiaChi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        //    hinh = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        //    // cai nay no nhu nao?// nó lấy dưới datagrid có cột thứ 4
        //    //textBoxMASV.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
        //    //textBoxName.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Name", true, DataSourceUpdateMode.Never));
        //    //textBoxEmail.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Email", true, DataSourceUpdateMode.Never));
        //    //textBoxSDT.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SĐT", true, DataSourceUpdateMode.Never));
        //    //textBoxDiaChi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Địa_Chỉ", true, DataSourceUpdateMode.Never));
        //    //radioButtonNam.DataBindings.Add(new Binding("Checked", dataGridView1.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
        //    if (gioitinh == "Nam")
        //    {
        //        radioButtonNam.Checked = true;

        //    }
        //    else if (gioitinh == "Nữ")
        //    {
        //        radioButtonNu.Checked = true;
        //    }

        //    //var vt = dataGridView1.CurrentCell.OwningRow.Cells["Hinh"].Value.ToString();
        //    //pictureBox1.Image = Image.FromFile("D:\\c2\\" + vt);
        //}
        ////private void dataGridView1_CellClick(object sender, EventArgs e)
        ////{
        ////    var vt = dataGridView1.CurrentCell.OwningRow.Cells[7].Value.ToString();
        ////    pictureBox1.Image = Image.FromFile("D:\\c2\\" + vt);
        //}
        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var vt = dataGridView1.CurrentCell.OwningRow.Cells["Hinh"].Value?.ToString();
        //    try
        //    {
        //        pictureBox1.Image = Image.FromFile("D:\\img\\" + vt);

        //    }
        //    catch
        //    {
        //        pictureBox1.Image = Image.FromFile("D:\\img\\default.jpg");             
        //    }

            
        //}
        private void QuanLySV_Load(object sender, EventArgs e)
        {
            hienthi();
           // dongbo();
        }
        //private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButtonNam.Checked == true)
        //    {
                
        //    }
        //    else
        //    {
        //        radioButtonNu.Checked = true;
        //    }
        //}

        //private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (radioButtonNam.Checked)
        //    {

        //    }
        //    else
        //    {
        //        radioButtonNu.Checked = true;
        //    }
        //}

        //void them()
        //{
        //    using (ASM_C3Entities db = new ASM_C3Entities())
        //    {
        //        Student x = new Student()
        //        {
        //            MASV = textBoxMASV.Text,
        //            HoTen = textBoxName.Text,
        //            Email = textBoxEmail.Text,
        //            SDT = textBoxSDT.Text,
        //        };
        //        db.Students.Add(x);
        //        db.SaveChanges();
        //    }
        //    hienthi();
        //}

        private bool SaveStudentDetail(Student stu)//save
        {           
            bool result = false;
            try
            {
                string Gioitinh;
                if (radioButtonNam.Checked)
                {
                    Gioitinh = "Nam";
                }
                else
                {
                    Gioitinh = "Nữ";
                }
                
                stu.MASV = textBoxMASV.Text;
                stu.HoTen = textBoxName.Text;
                stu.Email = textBoxEmail.Text;
                stu.SDT = textBoxSDT.Text;
                stu.DiaChi = textBoxDiaChi.Text;
                stu.GioiTinh = Gioitinh;
                stu.Hinh = textBoxHinh.Text;
                db.Students.Add(stu);
                db.SaveChanges();
                result = true;
            }
            catch { db.Students.Remove(stu); }

            return result;
        }

        private void buttonSave_Click(object sender, EventArgs e)//save
        {
            bool result = false;
            Student st = new Student();
            result = SaveStudentDetail(st);
            hienthi();
            MessageBox.Show("Thanh Cong");
        }
        private void ClearField()//new
        {
            textBoxMASV.Text = "";
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxSDT.Text = "";          
            radioButtonNam.Checked = true;
            textBoxDiaChi.Text = "";
            textBoxHinh.Text = "";
            pictureBox1.Image = null;
        }

        private void buttonNew_Click(object sender, EventArgs e)//new
        {
            ClearField();
        }
        //private bool UpdateStudentDetail(Student stu)
        //{
        //    //bool result = false;
        //    //try
        //    //{
        //    //    stu.MASV = textBoxMASV.Text;
        //    //    stu.HoTen = textBoxName.Text;
        //    //    stu.Email = textBoxEmail.Text;
        //    //    stu.SDT = textBoxSDT.Text;
        //    //    //stu.GioiTinh = radioButtonNam.Checked;
        //    //    stu.DiaChi = textBoxDiaChi.Text;
        //    //    db.SaveChanges();
        //    //    result = true;
        //    //}
        //    //catch { }
        //    //return result;

        //}
        void update()//update
        {
            using(ASM_C3Entities db = new ASM_C3Entities())
            {
                string Gioitinh;
                if (radioButtonNam.Checked)
                {
                    Gioitinh = "Nam";
                }
                else
                {
                    Gioitinh = "Nữ";
                }
                var capnhat = db.Students.Where(x => x.MASV == textBoxMASV.Text).FirstOrDefault();
                if (capnhat != null){
                    capnhat.HoTen = textBoxName.Text;
                    capnhat.Email = textBoxEmail.Text;
                    capnhat.SDT = textBoxSDT.Text;
                    capnhat.GioiTinh = Gioitinh;
                    capnhat.DiaChi = textBoxDiaChi.Text;
                }
                db.SaveChanges();
                hienthi();
                MessageBox.Show("Thanh cong");
            }
        }       

        private void buttonUpdate_Click(object sender, EventArgs e)//update
        {

            //bool result = false;
            //Student stu = db.Students.Find(textBoxMASV.Text);
            //result = UpdateStudentDetail(stu);

            //UpdateStudentDetail();
            update();
        }
        private bool DeleteStudentDetail(Student stu)
        {
            bool result = false;
            try
            {
                using(ASM_C3Entities db = new ASM_C3Entities())
                {
                    var xoa = db.Students.Where(x => x.MASV == textBoxMASV.Text);
                    var xoa1 = db.Grades.Where(x => x.MASV == textBoxMASV.Text);
                    if (xoa.Count() > 0)
                    {
                        if (xoa1.Count() > 0)
                        {
                            db.Grades.Remove(xoa1.FirstOrDefault());
                        }
                        db.Students.Remove(xoa.FirstOrDefault());
                    }
                    
                    db.SaveChanges();
                    hienthi();
                }    
             
              
                result = true;
            }
            catch { }

            return result;
        }
     
        private void buttonDel_Click(object sender, EventArgs e)
        {
            bool result = true;
            Student st = db.Students.Find(textBoxMASV.Text);
            result = DeleteStudentDetail(st);
            //hienthi(); 
            MessageBox.Show("Xoa Thanh Cong");
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMASV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxSDT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            var gioitinh = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxDiaChi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();           
            hinh = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.Image = Image.FromFile(@"D:\img\"+hinh);
            textBoxHinh.Text = hinh;
            
            //textBoxMASV.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
            //textBoxName.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Name", true, DataSourceUpdateMode.Never));
            //textBoxEmail.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Email", true, DataSourceUpdateMode.Never));
            //textBoxSDT.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "SĐT", true, DataSourceUpdateMode.Never));
            //textBoxDiaChi.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Địa_Chỉ", true, DataSourceUpdateMode.Never));
            //radioButtonNam.DataBindings.Add(new Binding("Checked", dataGridView1.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
            if (gioitinh == "Nam")
            {
                radioButtonNam.Checked = true;

            }
            else if (gioitinh == "Nữ")
            {
                radioButtonNu.Checked = true;
            }           
            //var vt = dataGridView1.CurrentCell.OwningRow.Cells["Hinh"].Value.ToString();
            //pictureBox1.Image = Image.FromFile("D:\\c2\\" + vt);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMASV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
