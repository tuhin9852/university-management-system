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
    public partial class studentupdate : templateform
    {
        public studentupdate()
        {
            InitializeComponent();
        }

      

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=TUHIN-PC;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE studentbasic SET name=@name,intake=@intake,section=@section WHERE id ='" + studentview.Text + "'", connection);
            command.Parameters.Add("@name", nametxt1.Text);
            command.Parameters.Add("@section", sectiontxt1.Text);
            command.Parameters.Add("@intake", intaketxt1.Text);

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Update Done ");

        }

        private void view_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=TUHIN-PC;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT name,intake,section FROM studentbasic WHERE id = '" + studentview.Text + "' ";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            
            nametxt.Text = reader["name"].ToString();
            intaketxt.Text = reader["intake"].ToString();
            sectiontxt.Text = reader["Section"].ToString();
           
            connection.Close();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            teacherfirstform teacherfirstformui = new teacherfirstform();
            teacherfirstformui.Show();
            this.Close();
        }
    }
}
