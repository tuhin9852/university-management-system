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
    public partial class View_Student : templateform
    {
        public View_Student()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=TUHIN-PC\SQLEXPRESS;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT name,intake,section,gender,dept FROM studentbasic WHERE id = '" + studentview.Text + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            idtxt.Text = studentview.Text;
            nametxt.Text = reader["name"].ToString();
            intaketxt.Text = reader["intake"].ToString();
            sectiontxt.Text = reader["Section"].ToString();
            gendertxt.Text = reader["gender"].ToString();
            depttxt.Text = reader["dept"].ToString();
            connection.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            teacherfirstform teacherfirstformui = new teacherfirstform();
            teacherfirstformui.Show();
            this.Close();
        }

        private void allstudent_Click(object sender, EventArgs e)
        {
            All_Student allstudent = new All_Student();
            this.Close();
            allstudent.Show();
        }
    }
}
