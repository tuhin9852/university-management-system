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
    public partial class resultadd : templateform
    {
        public resultadd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=TUHIN-PC;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT name,id FROM studentbasic WHERE id = '" + studentview.Text + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            nametxt.Text = reader["name"].ToString();
            idtxt.Text = reader["id"].ToString();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teacherfirstform teacherfirstform = new teacherfirstform();
            teacherfirstform.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=TUHIN-PC;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO course(id,course_name,credit,mark,cal) VALUES(@id,@course_name,@credit,@mark,@cal)", connection);
            
            command.Parameters.Add("@id", idtxt.Text);
            command.Parameters.Add("@course_name", course_nametxt.Text);
            command.Parameters.Add("@credit", credittxt.Text);
            command.Parameters.Add("@mark", marktxt.Text);
            double credit = Convert.ToDouble(credittxt.Text);
            double mark = Convert.ToDouble(marktxt.Text);
            double grade=0;
            
            if (mark < 40) { grade = 0; }
            else if(mark >  40  & mark <45) { grade = 2; }
            else if (mark > 45 & mark < 50) { grade = 2.25; }
            else if (mark > 50 & mark < 55) { grade = 2.5; }
            else if (mark > 55 & mark < 60) { grade = 2.75; }
            else if (mark > 60 & mark < 65) { grade = 3; }
            else if (mark > 65 & mark < 70) { grade = 3.25; }
            else if (mark > 70 & mark < 75) { grade = 3.5; }
            else if (mark > 75 & mark < 80) { grade = 3.75; }
            else if (mark > 80 ) { grade = 4; }
            double cal = (grade * credit);
            command.Parameters.Add("@cal",cal );
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Mark Added");
        }
    }
}
