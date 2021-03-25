namespace universitymanagementsystem.screen
{
    partial class loginform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.iconlist = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.radiobtnteacher = new System.Windows.Forms.RadioButton();
            this.radiobtnstudent = new System.Windows.Forms.RadioButton();
            this.txtname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtpassword);
            this.panel2.Controls.Add(this.radiobtnteacher);
            this.panel2.Controls.Add(this.radiobtnstudent);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Location = new System.Drawing.Point(284, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 383);
            this.panel2.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogin.ImageIndex = 1;
            this.btnlogin.ImageList = this.iconlist;
            this.btnlogin.Location = new System.Drawing.Point(110, 280);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(82, 34);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Log";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // iconlist
            // 
            this.iconlist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconlist.ImageStream")));
            this.iconlist.TransparentColor = System.Drawing.Color.Transparent;
            this.iconlist.Images.SetKeyName(0, "if_18_-_Shirt_2102054.ico");
            this.iconlist.Images.SetKeyName(1, "if_linkedin2_326115.ico");
            this.iconlist.Images.SetKeyName(2, "if_ok-sign_173063.ico");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(47, 222);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(217, 20);
            this.txtpassword.TabIndex = 3;
            // 
            // radiobtnteacher
            // 
            this.radiobtnteacher.AutoSize = true;
            this.radiobtnteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnteacher.Location = new System.Drawing.Point(192, 67);
            this.radiobtnteacher.Name = "radiobtnteacher";
            this.radiobtnteacher.Size = new System.Drawing.Size(87, 22);
            this.radiobtnteacher.TabIndex = 2;
            this.radiobtnteacher.TabStop = true;
            this.radiobtnteacher.Text = "Teacher";
            this.radiobtnteacher.UseVisualStyleBackColor = true;
            // 
            // radiobtnstudent
            // 
            this.radiobtnstudent.AutoSize = true;
            this.radiobtnstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.radiobtnstudent.Location = new System.Drawing.Point(47, 67);
            this.radiobtnstudent.Name = "radiobtnstudent";
            this.radiobtnstudent.Size = new System.Drawing.Size(83, 22);
            this.radiobtnstudent.TabIndex = 1;
            this.radiobtnstudent.TabStop = true;
            this.radiobtnstudent.Text = "Student";
            this.radiobtnstudent.UseVisualStyleBackColor = true;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(47, 146);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(217, 20);
            this.txtname.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(284, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 58);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(101, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUBT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "loginform";
            this.Text = "loginform";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ImageList iconlist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.RadioButton radiobtnteacher;
        private System.Windows.Forms.RadioButton radiobtnstudent;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}