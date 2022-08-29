namespace WinFormsApp1_july_5
{
    partial class studentCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_sname = new System.Windows.Forms.Label();
            this.lbl_sid = new System.Windows.Forms.Label();
            this.lbl_semail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_sname
            // 
            this.lbl_sname.AutoSize = true;
            this.lbl_sname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sname.Location = new System.Drawing.Point(23, 19);
            this.lbl_sname.Name = "lbl_sname";
            this.lbl_sname.Size = new System.Drawing.Size(52, 19);
            this.lbl_sname.TabIndex = 0;
            this.lbl_sname.Text = "sname";
            // 
            // lbl_sid
            // 
            this.lbl_sid.AutoSize = true;
            this.lbl_sid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_sid.Location = new System.Drawing.Point(23, 60);
            this.lbl_sid.Name = "lbl_sid";
            this.lbl_sid.Size = new System.Drawing.Size(28, 19);
            this.lbl_sid.TabIndex = 1;
            this.lbl_sid.Text = "sid";
            // 
            // lbl_semail
            // 
            this.lbl_semail.AutoSize = true;
            this.lbl_semail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_semail.Location = new System.Drawing.Point(23, 104);
            this.lbl_semail.Name = "lbl_semail";
            this.lbl_semail.Size = new System.Drawing.Size(52, 19);
            this.lbl_semail.TabIndex = 2;
            this.lbl_semail.Text = "semail";
            // 
            // studentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.lbl_semail);
            this.Controls.Add(this.lbl_sid);
            this.Controls.Add(this.lbl_sname);
            this.Name = "studentCard";
            this.Size = new System.Drawing.Size(159, 149);
            this.Load += new System.EventHandler(this.studentCard_Load);
            this.Click += new System.EventHandler(this.studentCard_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_sname;
        private Label lbl_sid;
        private Label lbl_semail;
    }
}
