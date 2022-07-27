namespace WinFormsApp1_july_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lalblEmail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Caladea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(68, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(120, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLastName.Font = new System.Drawing.Font("Caladea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(68, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lalblEmail
            // 
            this.lalblEmail.AutoSize = true;
            this.lalblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lalblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lalblEmail.Font = new System.Drawing.Font("Caladea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lalblEmail.ForeColor = System.Drawing.Color.White;
            this.lalblEmail.Location = new System.Drawing.Point(68, 145);
            this.lalblEmail.Name = "lalblEmail";
            this.lalblEmail.Size = new System.Drawing.Size(77, 25);
            this.lalblEmail.TabIndex = 0;
            this.lalblEmail.Text = "E-mail";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Caladea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(68, 202);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(32, 25);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Id";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhone.Font = new System.Drawing.Font("Caladea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(68, 256);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(72, 25);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone";
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtFName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFName.Location = new System.Drawing.Point(225, 35);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(136, 34);
            this.txtFName.TabIndex = 1;
            this.txtFName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtLName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLName.Location = new System.Drawing.Point(225, 81);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(136, 34);
            this.txtLName.TabIndex = 1;
            this.txtLName.Leave += new System.EventHandler(this.txtLName_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(225, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 34);
            this.txtEmail.TabIndex = 1;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(225, 193);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 34);
            this.txtId.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(225, 250);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(136, 34);
            this.txtPhone.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(139, 404);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 38);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Resgister";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(242, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(345, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(225, 314);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 29);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDate.Font = new System.Drawing.Font("Caladea", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(68, 314);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(394, 35);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(638, 249);
            this.dgv1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1071, 488);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lalblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblLastName;
        private Label lalblEmail;
        private Label lblID;
        private Label lblPhone;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtEmail;
        private TextBox txtId;
        private TextBox txtPhone;
        private Button btnRegister;
        private Button btnClear;
        private Button btnCancel;
        private DateTimePicker dateTimePicker1;
        private Label lblDate;
        private DataGridView dgv1;
        private ErrorProvider errorProvider1;
    }
}