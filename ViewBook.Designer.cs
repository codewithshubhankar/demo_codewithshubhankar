namespace LIBRARY_MANAGEMENT_SYSTEM
{
	partial class ViewBook
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.BookPurchaseDate = new System.Windows.Forms.DateTimePicker();
			this.txtBookQuantity = new System.Windows.Forms.TextBox();
			this.txtBookPrice = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtBookPublication = new System.Windows.Forms.TextBox();
			this.txtBookAuthorName = new System.Windows.Forms.TextBox();
			this.txtBookNam = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBookName = new System.Windows.Forms.TextBox();
			this.lblBookName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.viewData = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewData)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			// BookPurchaseDate
			// 
			this.BookPurchaseDate.Location = new System.Drawing.Point(536, 21);
			this.BookPurchaseDate.Name = "BookPurchaseDate";
			this.BookPurchaseDate.Size = new System.Drawing.Size(197, 20);
			this.BookPurchaseDate.TabIndex = 23;
			// 
			// txtBookQuantity
			// 
			this.txtBookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBookQuantity.Location = new System.Drawing.Point(536, 103);
			this.txtBookQuantity.Name = "txtBookQuantity";
			this.txtBookQuantity.Size = new System.Drawing.Size(197, 26);
			this.txtBookQuantity.TabIndex = 22;
			// 
			// txtBookPrice
			// 
			this.txtBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBookPrice.Location = new System.Drawing.Point(536, 56);
			this.txtBookPrice.Name = "txtBookPrice";
			this.txtBookPrice.Size = new System.Drawing.Size(197, 26);
			this.txtBookPrice.TabIndex = 21;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel2.Controls.Add(this.btnCancel);
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnUpdate);
			this.panel2.Controls.Add(this.BookPurchaseDate);
			this.panel2.Controls.Add(this.txtBookQuantity);
			this.panel2.Controls.Add(this.txtBookPrice);
			this.panel2.Controls.Add(this.txtBookPublication);
			this.panel2.Controls.Add(this.txtBookAuthorName);
			this.panel2.Controls.Add(this.txtBookNam);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(14, 341);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(782, 208);
			this.panel2.TabIndex = 11;
			// 
			// txtBookPublication
			// 
			this.txtBookPublication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBookPublication.Location = new System.Drawing.Point(150, 110);
			this.txtBookPublication.Name = "txtBookPublication";
			this.txtBookPublication.Size = new System.Drawing.Size(197, 26);
			this.txtBookPublication.TabIndex = 20;
			// 
			// txtBookAuthorName
			// 
			this.txtBookAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBookAuthorName.Location = new System.Drawing.Point(150, 61);
			this.txtBookAuthorName.Name = "txtBookAuthorName";
			this.txtBookAuthorName.Size = new System.Drawing.Size(197, 26);
			this.txtBookAuthorName.TabIndex = 19;
			// 
			// txtBookNam
			// 
			this.txtBookNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBookNam.Location = new System.Drawing.Point(150, 18);
			this.txtBookNam.Name = "txtBookNam";
			this.txtBookNam.Size = new System.Drawing.Size(197, 26);
			this.txtBookNam.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(414, 114);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 15);
			this.label7.TabIndex = 17;
			this.label7.Text = "Book Quantity";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(414, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 15);
			this.label6.TabIndex = 16;
			this.label6.Text = "Book Price";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(412, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 15);
			this.label5.TabIndex = 15;
			this.label5.Text = "Book Purchase Date";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "Book Publication";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 63);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "Book Author Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Book Name";
			// 
			// txtBookName
			// 
			this.txtBookName.Location = new System.Drawing.Point(294, 92);
			this.txtBookName.Name = "txtBookName";
			this.txtBookName.Size = new System.Drawing.Size(197, 20);
			this.txtBookName.TabIndex = 8;
			this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
			// 
			// lblBookName
			// 
			this.lblBookName.AutoSize = true;
			this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBookName.Location = new System.Drawing.Point(187, 92);
			this.lblBookName.Name = "lblBookName";
			this.lblBookName.Size = new System.Drawing.Size(101, 20);
			this.lblBookName.TabIndex = 7;
			this.lblBookName.Text = "Book Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(413, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "View Books";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(319, -9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(115, 95);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// viewData
			// 
			this.viewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewData.Location = new System.Drawing.Point(14, 118);
			this.viewData.Name = "viewData";
			this.viewData.Size = new System.Drawing.Size(782, 217);
			this.viewData.TabIndex = 10;
			this.viewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewData_CellClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefresh.Location = new System.Drawing.Point(497, 89);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(82, 23);
			this.btnRefresh.TabIndex = 9;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(4, 7);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 79);
			this.panel1.TabIndex = 6;
			// 
			// ViewBook
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(800, 557);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.txtBookName);
			this.Controls.Add(this.lblBookName);
			this.Controls.Add(this.viewData);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.panel1);
			this.IsMdiContainer = true;
			this.Name = "ViewBook";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ViewBook";
			this.Load += new System.EventHandler(this.ViewBook_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewData)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DateTimePicker BookPurchaseDate;
		private System.Windows.Forms.TextBox txtBookQuantity;
		private System.Windows.Forms.TextBox txtBookPrice;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtBookPublication;
		private System.Windows.Forms.TextBox txtBookAuthorName;
		private System.Windows.Forms.TextBox txtBookNam;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBookName;
		private System.Windows.Forms.Label lblBookName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView viewData;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Panel panel1;
	}
}