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
    public partial class studentinterface : templateform
    {
        string sname = "";
        

        public studentinterface(string studentname)
        {
            InitializeComponent();
            sname = studentname;
        }

        

        private void studentinterface_Load(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=TUHIN-PC\SQLEXPRESS;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT name,id,intake,section,gender FROM studentbasic WHERE name = '" + sname + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            idtxt.Text = reader["id"].ToString();
            nametxt.Text = reader["name"].ToString();
            intaketxt.Text = reader["intake"].ToString();
            sectiontxt.Text = reader["Section"].ToString();
            gendertxt.Text = reader["gender"].ToString();
            connection.Close();
            connection.Open();
             query = "SELECT SUM(cal) FROM course WHERE id = '" + idtxt.Text + "' ";
             command = new SqlCommand(query, connection);
            double cal = Convert.ToDouble(command.ExecuteScalar());
            
            cgpatxt.Text =Convert.ToString( cal);
            connection.Close();
            connection.Open();
            query = "SELECT SUM(credit) FROM course WHERE id = '" + idtxt.Text + "' ";
            command = new SqlCommand(query, connection);
            double credit = Convert.ToDouble(command.ExecuteScalar());
            credit = cal / credit;
            cgpatxt.Text = Convert.ToString(credit);
            connection.Close();
        }

        private void changepassbtn_Click(object sender, EventArgs e)
        {
            passwordchangeui passwordchangeui = new passwordchangeui(sname);
            passwordchangeui.Show();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentcourse studentcourse = new studentcourse(idtxt.Text);
            studentcourse.Show();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
