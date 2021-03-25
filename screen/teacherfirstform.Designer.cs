namespace universitymanagementsystem.screen
{
    partial class teacherfirstform
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
            this.addstudent = new System.Windows.Forms.Button();
            this.viewstudent = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addresultbtn = new System.Windows.Forms.Button();
            this.updateresultbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addstudent
            // 
            this.addstudent.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addstudent.Location = new System.Drawing.Point(131, 108);
            this.addstudent.Name = "addstudent";
            this.addstudent.Size = new System.Drawing.Size(164, 92);
            this.addstudent.TabIndex = 6;
            this.addstudent.Text = "Add Student";
            this.addstudent.UseVisualStyleBackColor = true;
            this.addstudent.Click += new System.EventHandler(this.addstudent_Click);
            // 
            // viewstudent
            // 
            this.viewstudent.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewstudent.Location = new System.Drawing.Point(374, 108);
            this.viewstudent.Name = "viewstudent";
            this.viewstudent.Size = new System.Drawing.Size(164, 92);
            this.viewstudent.TabIndex = 5;
            this.viewstudent.Text = "View Student";
            this.viewstudent.UseVisualStyleBackColor = true;
            this.viewstudent.Click += new System.EventHandler(this.viewstudent_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Transparent;
            this.update.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(608, 112);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(148, 88);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(608, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 92);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addresultbtn
            // 
            this.addresultbtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresultbtn.Location = new System.Drawing.Point(131, 265);
            this.addresultbtn.Name = "addresultbtn";
            this.addresultbtn.Size = new System.Drawing.Size(164, 92);
            this.addresultbtn.TabIndex = 6;
            this.addresultbtn.Text = "Add Result";
            this.addresultbtn.UseVisualStyleBackColor = true;
            this.addresultbtn.Click += new System.EventHandler(this.addresultbtn_Click);
            // 
            // updateresultbtn
            // 
            this.updateresultbtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateresultbtn.Location = new System.Drawing.Point(374, 265);
            this.updateresultbtn.Name = "updateresultbtn";
            this.updateresultbtn.Size = new System.Drawing.Size(164, 92);
            this.updateresultbtn.TabIndex = 6;
            this.updateresultbtn.Text = "Update Result";
            this.updateresultbtn.UseVisualStyleBackColor = true;
            this.updateresultbtn.Click += new System.EventHandler(this.updateresultbtn_Click);
            // 
            // teacherfirstform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 540);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.updateresultbtn);
            this.Controls.Add(this.addresultbtn);
            this.Controls.Add(this.addstudent);
            this.Controls.Add(this.viewstudent);
            this.Controls.Add(this.update);
            this.Name = "teacherfirstform";
            this.Text = "Teacher First Form";
            this.Load += new System.EventHandler(this.teacherfirstform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addstudent;
        private System.Windows.Forms.Button viewstudent;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addresultbtn;
        private System.Windows.Forms.Button updateresultbtn;
    }
}