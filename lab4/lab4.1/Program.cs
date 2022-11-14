using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._1
{
    
    class Program
    {     
        static void Main(string[] args)
        {
            DataSet set = loaddata();

            DataTable usersTable = set.Tables["users"];
            DataTable groupsTable = set.Tables["groups"];


            DataRelation relation = new DataRelation("group_user",
                groupsTable.Columns["groupid"],
                usersTable.Columns["groupid"]);

            set.Relations.Add(relation);
        }

        private static DataSet loaddata()
        {
            var con = new SqlConnection(@"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = quanly;
                                        integrated security=SSPI");

            con.Open();

            var cmd = "select * from users";
            var dataAdapter = new SqlDataAdapter(cmd, con);
            var dataset = new DataSet();

            dataAdapter.Fill(dataset, "users");

            dataAdapter.SelectCommand.CommandText = "select * from groups";
            dataAdapter.Fill(dataset, "groups");

            con.Close();

            return dataset;
        }
    }
    
}
