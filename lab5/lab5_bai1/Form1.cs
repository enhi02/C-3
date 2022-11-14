using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            display();
        }
        public void display()
        {
            using (StudentInformationEntities db = new StudentInformationEntities())
            {
                List<StudenInformation> studenlist = new List<StudenInformation>();
                studenlist = db.StudentDetails.Select(x => new StudenInformation
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age,
                    City = x.City,
                    Gender = x.Gender
                }).ToList();
                dataGridView1.DataSource = studenlist;
            }
        }
        public bool SaveStudentDetails(StudentDetail Stu)
        {
            bool result = false;
            using(StudentInformationEntities db = new StudentInformationEntities())
            {
                db.StudentDetails.Add(Stu);
                db.SaveChanges();
                result = true;
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDetail stu = new StudentDetail();
                stu.Name = textBox1.Text;
                stu.Age = Convert.ToInt32(textBox2.Text);
                stu.City = textBox3.Text;
                stu.Gender = comboBox1.SelectedItem.ToString();
                bool result = SaveStudentDetails(stu);
                display();
                ShowStatus(result, "Save");
            }catch 
            {               
                MessageBox.Show("Error : No data found!..", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            label1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.Rows[i].Cells[4].Value.ToString();

        }
        public bool UpdateStudentDetails(StudentDetail stu)
        {
            bool result = false;
            using(StudentInformationEntities db = new StudentInformationEntities())
            {
                StudentDetail student = db.StudentDetails.Where(x => x.Id == stu.Id).Select(x => x).FirstOrDefault();
                student.Name = stu.Name;
                student.Age = stu.Age;
                student.City = stu.City;
                student.Gender = stu.Gender;
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDetail stu = new StudentDetail();
                stu.Id = Convert.ToInt32(label1.Text);
                stu.Name = textBox1.Text;
                stu.Age = Convert.ToInt32(textBox2.Text);
                stu.City = textBox3.Text;
                stu.Gender = comboBox1.SelectedItem.ToString();
                bool result = UpdateStudentDetails(stu);
                display();
                ShowStatus(result, "Update");
            }
            catch 
            {               
                MessageBox.Show("Error : No data found!..", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
    
        }
        public bool DeleteStudentDetails(StudentDetail stu)
        {
            bool result = false;
            using (StudentInformationEntities db = new StudentInformationEntities())
            {
                StudentDetail student = db.StudentDetails.Where(x => x.Id == stu.Id).Select(x => x).FirstOrDefault();
                db.StudentDetails.Remove(student);
                db.SaveChanges();
                result = true;
            }
            return result;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDetail stu = new StudentDetail();
                stu.Id = Convert.ToInt32(label1.Text);
                stu.Name = textBox1.Text;
                stu.Age = Convert.ToInt32(textBox2.Text);
                stu.City = textBox3.Text;
                stu.Gender = comboBox1.SelectedItem.ToString();
                bool result = DeleteStudentDetails(stu);
                display();
                ShowStatus(result, "Delete");
            }
            catch
            {
                MessageBox.Show("Error : No data found!..", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            
        }
        public void ShowStatus(bool result, string Action)
        {
            if (result)
            {
                if(Action.ToUpper() == "SAVE")
                {
                    MessageBox.Show("Saved Successfully!..", "Save", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else if(Action.ToUpper() == "UPDATE")
                {
                    MessageBox.Show("Updated Successfully!..", "Update", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleted Successfully!..", "Delete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Something went wrong!. Please try again!..", "error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            display();
            ClearFields();
        }
        public void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.SelectedIndex = -1;
        }
        
    }   
}
