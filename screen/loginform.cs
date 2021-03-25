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
    public partial class loginform : templateform
    {
        public loginform()
        {
            InitializeComponent();
            txtpassword.PasswordChar = '#';
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            if (radiobtnstudent.Checked == true)
            {
                string connectionstring1 = @"Data Source=TUHIN-PC\SQLEXPRESS;Initial Catalog=university;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring1);
                SqlCommand command = new SqlCommand("SELECT *FROM studentbasic WHERE name='" + txtname.Text + "'and pass='" + txtpassword.Text + "'", connection);
                connection.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    studentinterface studentinterface = new studentinterface(txtname.Text);
                    studentinterface.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Name Or Password Is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else if(radiobtnteacher.Checked == true)
            {
                
                string connectionstring1 = @"Data Source=TUHIN-PC\SQLEXPRESS;Initial Catalog=university;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionstring1);
                SqlCommand command = new SqlCommand("SELECT *FROM teacher WHERE name='" + txtname.Text + "'and pass='" + txtpassword.Text + "'", connection);
                connection.Open();
                SqlDataReader reader;
                reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    teacherfirstform teacherfirstform = new teacherfirstform();
                    this.Hide();
                    teacherfirstform.Show();
                    
                }
                else
                {
                    MessageBox.Show("Name Or Password Is incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
            

        }
    }
}
