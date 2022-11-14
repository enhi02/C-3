using  System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace lab4
{
    public partial class From : Form
    {
        public From()
        {
            InitializeComponent();
            LoadData();
        }
        DataSet set;
        DataView dv;
        SqlDataAdapter dataAdapter;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NRD3QQN\NGOCSANG;Initial Catalog=QuanLy_ps18412;Integrated Security=True");
        void LoadData()
        {
            set = GetData();

            DataTable usersTable = set.Tables["users"];
            DataTable groupsTable = set.Tables["groups"];
        
            DataRelation relation = new DataRelation("group_user",
                groupsTable.Columns["groupid"],
                usersTable.Columns["groupid"]);

            set.Relations.Add(relation);

            dv = set.Tables["users"].DefaultView;
            dataGridView1.DataSource = dv;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// hàm lấy data từ database
        /// </summary>
        /// <returns>dataset</returns>
        private DataSet GetData()
        {
            con.Open();

            var cmd = "select * from users";
            dataAdapter = new SqlDataAdapter(cmd, con);
            var dataset = new DataSet();

            dataAdapter.Fill(dataset, "users");

            dataAdapter.SelectCommand.CommandText = "select * from groups";
            dataAdapter.Fill(dataset, "groups");

            con.Close();

            return dataset;
        }
      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            UserName.Text = row.Cells[1].Value.ToString();
            Groupid.Text = row.Cells[2].Value.ToString();
            UserID.Text= row.Cells[0].Value.ToString();
        }
        private void Sort_Click(object sender, EventArgs e)
        {
            DataSet set = GetData();
            DataView dv = set.Tables["users"].DefaultView;
            dv.Sort = "UserName ASC";
            dataGridView1.DataSource = dv;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            var cmd = "select * from users";
            dataAdapter = new SqlDataAdapter(cmd, con);

            dv.AllowEdit = true;
            dv[row].BeginEdit();
            dv[row]["userName"] = UserName.Text;
            dv[row]["UserID"] = UserID.Text;
            try
            {
                dv[row]["groupId"] = Convert.ToInt32(Groupid.Text);
                dv[row].EndEdit();
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(set.Tables["users"]);
            }
            catch
            {
            }
            finally
            {
                LoadData();
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;

            dv.AllowDelete = true;
            dv.Table.Rows[row].Delete();

            var cmd = "select * from users";
            dataAdapter = new SqlDataAdapter(cmd, con);

            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.Update(set.Tables["users"]);
        }

      

        private void AddUSser_Click(object sender, EventArgs e)
        {
            var cmd = "select * from users";
            dataAdapter = new SqlDataAdapter(cmd, con);

            dv.AllowNew = true;
            DataRowView newRow = dv.AddNew();
            newRow.BeginEdit();
            newRow["userName"] = UserName.Text;
            newRow["UserID"] = UserID.Text;
            try
            {
                newRow["groupId"] = Convert.ToInt32(Groupid.Text);
                newRow.EndEdit();
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(set.Tables["users"]);
            }
            catch
            {
                newRow.Delete();
            }
            finally
            {
                LoadData();
            }
        }
    }
}
