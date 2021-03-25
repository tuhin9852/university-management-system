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
    public partial class resultupdate : templateform
    {
        public resultupdate()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=TUHIN-PC;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT course_name,credit,mark FROM course WHERE id = '" + studentview.Text + "' ";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void update_Click(object sender, EventArgs e)
        {
            
            string connectionstring = @"Data Source=TUHIN-PC;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE course SET course_name=@course_name,credit=@credit,mark=@mark WHERE id ='" + studentview.Text + "'and course_name = '"+coursenametxt.Text+"'and credit ='"+credittxt.Text+"'", connection);
            command.Parameters.Add("@course_name", coursenametxt.Text);
            command.Parameters.Add("@credit", credittxt.Text);
            command.Parameters.Add("@mark", marktxt.Text);
            MessageBox.Show("Update Done");
            command.ExecuteNonQuery();
            connection.Close();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=TUHIN-PC;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE course WHERE id ='" + studentview.Text + "'and course_name = '" + coursenametxt.Text + "'and credit ='" + credittxt.Text + "'", connection);
            
            MessageBox.Show("Delete Done");
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            coursenametxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            credittxt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            marktxt.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            teacherfirstform teacherfirstform = new teacherfirstform();
            this.Hide();
            teacherfirstform.Show();
        }
    }
}
