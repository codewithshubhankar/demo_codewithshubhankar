namespace LIBRARY_MANAGEMENT_SYSTEM
{
	partial class viewStudentinformation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewStudentinformation));
			this.txtSearchEnrollmentNumber = new System.Windows.Forms.TextBox();
			this.lblEnrollmentNumber = new System.Windows.Forms.Label();
			this.viewData1 = new System.Windows.Forms.DataGridView();
			this.btnRefresh1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtStudentSemester = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.txtStudentEmail = new System.Windows.Forms.TextBox();
			this.txtStudentContact = new System.Windows.Forms.TextBox();
			this.txtDepartment = new System.Windows.Forms.TextBox();
			this.txtEnrollment = new System.Windows.Forms.TextBox();
			this.txtStudentName = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.viewData1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtSearchEnrollmentNumber
			// 
			this.txtSearchEnrollmentNumber.Location = new System.Drawing.Point(297, 109);
			this.txtSearchEnrollmentNumber.Name = "txtSearchEnrollmentNumber";
			this.txtSearchEnrollmentNumber.Size = new System.Drawing.Size(197, 20);
			this.txtSearchEnrollmentNumber.TabIndex = 29;
			this.txtSearchEnrollmentNumber.TextChanged += new System.EventHandler(this.txtSearchEnrollmentNumber_TextChanged);
			// 
			// lblEnrollmentNumber
			// 
			this.lblEnrollmentNumber.AutoSize = true;
			this.lblEnrollmentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnrollmentNumber.Location = new System.Drawing.Point(129, 109);
			this.lblEnrollmentNumber.Name = "lblEnrollmentNumber";
			this.lblEnrollmentNumber.Size = new System.Drawing.Size(162, 20);
			this.lblEnrollmentNumber.TabIndex = 28;
			this.lblEnrollmentNumber.Text = "Enrollment Number";
			// 
			// viewData1
			// 
			this.viewData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewData1.Location = new System.Drawing.Point(2, 146);
			this.viewData1.Name = "viewData1";
			this.viewData1.Size = new System.Drawing.Size(792, 240);
			this.viewData1.TabIndex = 31;
			this.viewData1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewData1_CellClick);
			// 
			// btnRefresh1
			// 
			this.btnRefresh1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRefresh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh1.Location = new System.Drawing.Point(500, 106);
			this.btnRefresh1.Name = "btnRefresh1";
			this.btnRefresh1.Size = new System.Drawing.Size(82, 23);
			this.btnRefresh1.TabIndex = 30;
			this.btnRefresh1.Text = "Refresh";
			this.btnRefresh1.UseVisualStyleBackColor = true;
			this.btnRefresh1.Click += new System.EventHandler(this.btnRefresh1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 97);
			this.panel1.TabIndex = 27;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label8.Location = new System.Drawing.Point(443, 63);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 16);
			this.label8.TabIndex = 2;
			this.label8.Text = "Student";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(442, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "View   ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(322, -1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(144, 98);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel2.Controls.Add(this.txtStudentSemester);
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnUpdate);
			this.panel2.Controls.Add(this.txtStudentEmail);
			this.panel2.Controls.Add(this.txtStudentContact);
			this.panel2.Controls.Add(this.txtDepartment);
			this.panel2.Controls.Add(this.txtEnrollment);
			this.panel2.Controls.Add(this.txtStudentName);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(2, 392);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 218);
			this.panel2.TabIndex = 32;
			// 
			// txtStudentSemester
			// 
			this.txtStudentSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStudentSemester.Location = new System.Drawing.Point(536, 19);
			this.txtStudentSemester.Name = "txtStudentSemester";
			this.txtStudentSemester.Size = new System.Drawing.Size(197, 26);
			this.txtStudentSemester.TabIndex = 27;
			// 
			// btnCancel
			// 
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(658, 146);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 26;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(577, 146);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 25;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Location = new System.Drawing.Point(496, 146);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 24;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// txtStudentEmail
			// 
			this.txtStudentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStudentEmail.Location = new System.Drawing.Point(536, 103);
			this.txtStudentEmail.Name = "txtStudentEmail";
			this.txtStudentEmail.Size = new System.Drawing.Size(197, 26);
			this.txtStudentEmail.TabIndex = 22;
			// 
			// txtStudentContact
			// 
			this.txtStudentContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStudentContact.Location = new System.Drawing.Point(536, 56);
			this.txtStudentContact.Name = "txtStudentContact";
			this.txtStudentContact.Size = new System.Drawing.Size(197, 26);
			this.txtStudentContact.TabIndex = 21;
			// 
			// txtDepartment
			// 
			this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDepartment.Location = new System.Drawing.Point(150, 110);
			this.txtDepartment.Name = "txtDepartment";
			this.txtDepartment.Size = new System.Drawing.Size(197, 26);
			this.txtDepartment.TabIndex = 20;
			// 
			// txtEnrollment
			// 
			this.txtEnrollment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEnrollment.Location = new System.Drawing.Point(150, 61);
			this.txtEnrollment.Name = "txtEnrollment";
			this.txtEnrollment.Size = new System.Drawing.Size(197, 26);
			this.txtEnrollment.TabIndex = 19;
			// 
			// txtStudentName
			// 
			this.txtStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtStudentName.Location = new System.Drawing.Point(150, 18);
			this.txtStudentName.Name = "txtStudentName";
			this.txtStudentName.Size = new System.Drawing.Size(197, 26);
			this.txtStudentName.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(414, 114);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(83, 15);
			this.label7.TabIndex = 17;
			this.label7.Text = "Student Email";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(414, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 15);
			this.label6.TabIndex = 16;
			this.label6.Text = "StudentContact";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(412, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 15);
			this.label5.TabIndex = 15;
			this.label5.Text = "Student Semester";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "Department";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "Enrollment Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Student Name";
			// 
			// viewStudentinformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(800, 612);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.txtSearchEnrollmentNumber);
			this.Controls.Add(this.lblEnrollmentNumber);
			this.Controls.Add(this.viewData1);
			this.Controls.Add(this.btnRefresh1);
			this.Controls.Add(this.panel1);
			this.IsMdiContainer = true;
			this.Name = "viewStudentinformation";
			this.Text = "viewStudentinformation";
			((System.ComponentModel.ISupportInitialize)(this.viewData1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtSearchEnrollmentNumber;
		private System.Windows.Forms.Label lblEnrollmentNumber;
		private System.Windows.Forms.DataGridView viewData1;
		private System.Windows.Forms.Button btnRefresh1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox txtStudentEmail;
		private System.Windows.Forms.TextBox txtStudentContact;
		private System.Windows.Forms.TextBox txtDepartment;
		private System.Windows.Forms.TextBox txtEnrollment;
		private System.Windows.Forms.TextBox txtStudentName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtStudentSemester;
		private System.Windows.Forms.Label label8;
	}
}