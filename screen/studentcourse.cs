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
    public partial class studentcourse : templateform
    {
        int id = 0;
        public studentcourse(string idb)
        {
            InitializeComponent();
             id =Convert.ToInt32(idb);
        }

        private void show_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=TUHIN-PC;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            string query = "SELECT course_name,mark,credit FROM course WHERE id='"+id+"' ";
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
