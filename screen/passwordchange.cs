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
    public partial class passwordchangeui : templateform
    {
        string sname = "";
        public passwordchangeui(string stname)
        {
            InitializeComponent();
            sname = stname;
        }

        private void passwordchange_Load(object sender, EventArgs e)
        {

        }

        private void changepass_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Data Source=TUHIN-PC;Initial Catalog=university;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionstring);
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE studentbasic SET pass=@pass WHERE name ='" +sname+ "'", connection);
            command.Parameters.Add("@pass", textBox1.Text);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Update Done ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
