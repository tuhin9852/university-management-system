using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using universitymanagementsystem.screen.template;

namespace universitymanagementsystem.screen
{
    public partial class All_Student : templateform
    {
        public All_Student()
        {
            InitializeComponent();
        }
        
private void show_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=TUHIN-PC\SQLEXPRESS;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT name,id,intake,section,gender,dept from studentbasic ";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            teacherfirstform teacherfirstform = new teacherfirstform();
            this.Close();
            teacherfirstform.Show();
        }
    }
}
