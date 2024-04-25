namespace LIBRARY_MANAGEMENT_SYSTEM
{
	partial class ReturnBooks
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnSearchStudent = new System.Windows.Forms.Button();
			this.txtEnrollmentNo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.txtBookIssueDate = new System.Windows.Forms.TextBox();
			this.viewData1 = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewData1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Controls.Add(this.btnExit);
			this.panel2.Controls.Add(this.btnRefresh);
			this.panel2.Controls.Add(this.btnSearchStudent);
			this.panel2.Controls.Add(this.txtEnrollmentNo);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Location = new System.Drawing.Point(12, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(247, 289);
			this.panel2.TabIndex = 3;
			// 
			// btnExit
			// 
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(158, 206);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Location = new System.Drawing.Point(58, 206);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(75, 23);
			this.btnRefresh.TabIndex = 4;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnSearchStudent
			// 
			this.btnSearchStudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSearchStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSearchStudent.Location = new System.Drawing.Point(95, 144);
			this.btnSearchStudent.Name = "btnSearchStudent";
			this.btnSearchStudent.Size = new System.Drawing.Size(104, 23);
			this.btnSearchStudent.TabIndex = 3;
			this.btnSearchStudent.Text = "Search Student";
			this.btnSearchStudent.UseVisualStyleBackColor = true;
			this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
			// 
			// txtEnrollmentNo
			// 
			this.txtEnrollmentNo.Location = new System.Drawing.Point(82, 109);
			this.txtEnrollmentNo.Name = "txtEnrollmentNo";
			this.txtEnrollmentNo.Size = new System.Drawing.Size(133, 20);
			this.txtEnrollmentNo.TabIndex = 2;
			this.txtEnrollmentNo.TextChanged += new System.EventHandler(this.txtEnrollmentNo_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(79, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(136, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Enrollment NO";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(112, 26);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(74, 58);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.panel1.Controls.Add(this.txtBookIssueDate);
			this.panel1.Controls.Add(this.txtBookName);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnReturn);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.Location = new System.Drawing.Point(264, 307);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(780, 262);
			this.panel1.TabIndex = 6;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Location = new System.Drawing.Point(633, 158);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 47;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnReturn
			// 
			this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReturn.Location = new System.Drawing.Point(633, 128);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(75, 23);
			this.btnReturn.TabIndex = 46;
			this.btnReturn.Text = "Return";
			this.btnReturn.UseVisualStyleBackColor = true;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(418, 161);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(197, 22);
			this.dateTimePicker1.TabIndex = 45;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(294, 166);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 15);
			this.label1.TabIndex = 44;
			this.label1.Text = "Book Return  Date";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(294, 133);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 15);
			this.label9.TabIndex = 41;
			this.label9.Text = "Book Issue Date";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(296, 92);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 15);
			this.label8.TabIndex = 40;
			this.label8.Text = "Book Name";
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(418, 86);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(197, 22);
			this.txtBookName.TabIndex = 48;
			// 
			// txtBookIssueDate
			// 
			this.txtBookIssueDate.Location = new System.Drawing.Point(418, 128);
			this.txtBookIssueDate.Name = "txtBookIssueDate";
			this.txtBookIssueDate.Size = new System.Drawing.Size(197, 22);
			this.txtBookIssueDate.TabIndex = 49;
			// 
			// viewData1
			// 
			this.viewData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewData1.Location = new System.Drawing.Point(264, 12);
			this.viewData1.Name = "viewData1";
			this.viewData1.Size = new System.Drawing.Size(787, 289);
			this.viewData1.TabIndex = 32;
			this.viewData1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewData1_CellClick);
			// 
			// ReturnBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(1073, 299);
			this.Controls.Add(this.viewData1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "ReturnBooks";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReturnBooks";
			this.Load += new System.EventHandler(this.ReturnBooks_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewData1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnSearchStudent;
		private System.Windows.Forms.TextBox txtEnrollmentNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBookIssueDate;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.DataGridView viewData1;
	}
}