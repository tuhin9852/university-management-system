using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using universitymanagementsystem.screen.template;

namespace universitymanagementsystem.screen
{
    public partial class teacherfirstform : templateform
    {
        public teacherfirstform()
        {
            InitializeComponent();
        }

        private void teacherfirstform_Load(object sender, EventArgs e)
        {

        }

        private void dsa_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            addstudentui addstudentui = new addstudentui();
            this.Close();
            addstudentui.Show();
        }
        private void updateresultbtn_Click(object sender, EventArgs e)
        {
            resultupdate resultupdate = new resultupdate();
            this.Close();
            resultupdate.Show();
        }
        private void addresultbtn_Click(object sender, EventArgs e)
        {
            resultadd resultadd = new resultadd();
            resultadd.Show();
            this.Close();
        }
        private void viewstudent_Click(object sender, EventArgs e)
        {
            View_Student viewstudent = new View_Student();
            viewstudent.Show();
            this.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            studentupdate studentupdateui = new studentupdate();
            studentupdateui.Show();
            this.Close();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
