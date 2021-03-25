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
    public partial class addstudentui : templateform
    {
        public addstudentui()
        {
            InitializeComponent();
        }

        private void addstudent_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source = TUHIN - PC\SQLEXPRESS; Initial Catalog = university; Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO studentbasic(name,id,intake,section,gender,pass,dept) VALUES(@name,@id,@intake,@section,@gender,@pass,@dept)", connection);
            command.Parameters.Add("@name", nametxt.Text);
            command.Parameters.Add("@id", idtxt.Text);
            command.Parameters.Add("@intake", intaketxt.Text);
            command.Parameters.Add("@section", sectiontxt.Text);
            command.Parameters.Add("@gender", comboBox1.SelectedItem.ToString());
            command.Parameters.Add("@pass", 12345);
            command.Parameters.Add("@dept", depttxt.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Student Added");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacherfirstform teacherfirstformui = new teacherfirstform();
            teacherfirstformui.Show();
            this.Close();
        }
    }
}
