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
    public partial class QuanLyDiem : Form
    {
        ASM_C3Entities db = new ASM_C3Entities();
        public QuanLyDiem()
        {
            InitializeComponent();
            hienthi();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void hienthi()
        {
            using (ASM_C3Entities db = new ASM_C3Entities())
            {
                dataGridView1.DataSource = (from z in db.Grades
                                            select new
                                            {
                                                ID =z.ID,
                                                MaSV = z.MASV,
                                                Names = z.Student.HoTen,
                                                TiengAnh = z.TiengAnh,
                                                TinHoc = z.TinHoc,
                                                GDTC = z.GDTC,
                                                DiemTB = (z.TiengAnh + z.TinHoc + z.GDTC) / 3
                                            }
                ).OrderByDescending(z => z.DiemTB).Take(3).ToList(); ;// 3 sinh vien

            }
            //textBoxMaSV.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
            //textID.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Names", true, DataSourceUpdateMode.Never));
            //textBoxTiengAnh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TiengAnh", true, DataSourceUpdateMode.Never));
            //textBoxTin.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "TinHoc", true, DataSourceUpdateMode.Never));
            //textBoxGDTC.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "GDTC", true, DataSourceUpdateMode.Never));
            //textBoxDTB.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DiemTB", true, DataSourceUpdateMode.Never));

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textBoxMaSV.Text = "";
            textname.Text = "";
            textBoxTiengAnh.Text = "";
            textBoxTin.Text = "";
            textBoxGDTC.Text = "";
            textBoxDTB.Text = "";
        }
            //private bool SaveGradeDetail(Grade gr)
            //{
            ////    bool result = false;
            ////    try
            ////    {
            ////        gr.MASV = textBoxMaSV.Text;
            ////        gr.TiengAnh = int.Parse(textBoxTiengAnh.Text);
            ////        gr.GDTC = int.Parse(textBoxGDTC.Text);
            ////        gr.TinHoc = int.Parse(textBoxTin.Text);
            ////        db.Grades.Add(gr);
            ////        db.SaveChanges();
            ////        result = true;
            ////    }
            ////    catch
            ////    {
            ////        db.Grades.Remove(gr);d
            ////    }

            ////    return result;
            ////}
            //public void Save()
            // {
            //     using (ASM_C3Entities db = new ASM_C3Entities() )
            //     {
            //         try
            //         {
            //             var diem = new Grade// tạo table mới chứa các điểm
            //                 {
            //                     MASV = textBoxMaSV.Text,
            //                     TiengAnh = int.Parse(textBoxTiengAnh.Text),//giá trị
            //                     TinHoc = int.Parse(textBoxTin.Text),
            //                     GDTC = int.Parse(textBoxGDTC.Text),
            //                 };
            //                 db.Grades.Add(diem);
            //                 db.SaveChanges();
            //                 hienthi();


            //         }//textID
            //         catch (Exception e)
            //         {
            //             MessageBox.Show("loi" + e.Message);
            //         }

            //     }
            // }
        private bool SaveStudentDetail()
        {
            bool result = false;
            try
            {
                using (ASM_C3Entities db = new ASM_C3Entities())
                {
                    //Grade gr = new Grade();
                    try
                    {
                        Grade gr = new Grade();
                        gr.MASV = textBoxMaSV.Text;
                        gr.ID = textname.Text;
                        gr.TiengAnh = int.Parse(textBoxTiengAnh.Text);
                        gr.GDTC = int.Parse(textBoxGDTC.Text);
                        gr.TinHoc = int.Parse(textBoxTin.Text);
                        db.Grades.Add(gr);
                        db.SaveChanges();
                        result = true;
                        MessageBox.Show("thanh cong");
                    }
                    catch { }
                }
            }
            catch {}

            return result;
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {

            bool result = false;

            result = SaveStudentDetail();
            hienthi();
        }
        // các lõi cần làm 
        // 1 chưa thông báo mỗi khi thực hiện 1 chức năng
        // 2 tải lại dữ liệu khi thực hiện 1 chwucs năng
        // còn lại t làm hết rồi đó, ok
        //t chay nha?
        //private bool deleteGradeDetail(Grade gr)//update  dak
        //{
        //    bool result = false;
        //    try
        //    {
        //        db.Grades.Remove(gr);
        //        db.SaveChanges();
        //        result = true;
        //    }
        //    catch { }
        //    return result;
        //}
        void xoa()
        {
            using (ASM_C3Entities db = new ASM_C3Entities())
            {
                var delete = db.Grades.Where(x => x.MASV == textBoxMaSV.Text).FirstOrDefault();
                if(delete != null)
                {
                    db.Grades.Remove(delete);
                    db.SaveChanges();
                    hienthi();
                }
                db.SaveChanges();
                MessageBox.Show("tc");

            }
        }
        private void buttonDel_Click(object sender, EventArgs e)
        {
            xoa();
            //bool result = false;
            //Grade gr = db.Grades.Where(x => x.MASV == textBoxMaSV.Text).FirstOrDefault();
            //result = deleteGradeDetail(gr);
            //sao ko để tên mà để id chi z, nhin nham//bh sửa lại là sửa cả sql nữa,bỏ cái id , um de tui, ok, 2 nut kia la ok hetroi phai k?
        }
 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textname.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxMaSV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
           // text.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxTiengAnh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
           textBoxTin.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxGDTC.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxDTB.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void QuanLyDiem_Load(object sender, EventArgs e)
        {

        }

        private void buttonTimKiem_Click_1(object sender, EventArgs e)
        {
            var gradeFind = db.Grades.Where(x => x.MASV == textBoxTimKiem.Text).Select(x => new
            {
                id = x.ID,
                MaSV = x.MASV,
                HoTen = x.Student.HoTen,
                TiengAnh = x.TiengAnh,
                TinHoc = x.TinHoc,
                GDTC = x.GDTC,
                DiemTB = (x.GDTC + x.TinHoc + x.TiengAnh) / 3
            }).ToList();

            if (gradeFind.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên hợp lệ!");
            }
            else
            {
                dataGridView1.DataSource = gradeFind;
            }
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private bool UpdateStudentDetail(Grade gr)
        {
            bool result = false;
            //3 nut save delete update bi loi
            using (ASM_C3Entities db = new ASM_C3Entities())
            {

                    
               // try
                //{
                    Grade grade = db.Grades.Find(gr.MASV);
                    grade.ID = gr.ID;
                    //grade.MASV = gr.MASV;
                    grade.TiengAnh = gr.TiengAnh;
                    grade.TinHoc = gr.TinHoc;
                    grade.GDTC = gr.GDTC;
                    db.Grades.Add(gr);
                    db.SaveChanges();
                    result = true;
                
               // }
                //catch { MessageBox.Show("Update ko thành công"); }
                
            }
            return result;
        }
        private void buttonUp_Click_1(object sender, EventArgs e)
        {
            
            var gr = new Grade();
            //gr.MASV = textBoxMaSV.Text;
            //gr.ID = textname.Text;
            gr.TiengAnh = int.Parse(textBoxTiengAnh.Text);
            gr.GDTC = int.Parse(textBoxGDTC.Text);
            gr.TinHoc = int.Parse(textBoxTin.Text);
            bool result = UpdateStudentDetail(gr);
            hienthi();
        }
    }
}
