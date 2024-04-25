namespace LIBRARY_MANAGEMENT_SYSTEM
{
	partial class CompleteBookDetails
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
			this.label1 = new System.Windows.Forms.Label();
			this.viewData1 = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.viewData2 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.viewData1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewData2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(494, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Issue Books";
			// 
			// viewData1
			// 
			this.viewData1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewData1.Location = new System.Drawing.Point(4, 38);
			this.viewData1.Name = "viewData1";
			this.viewData1.Size = new System.Drawing.Size(1010, 188);
			this.viewData1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(494, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 26);
			this.label2.TabIndex = 4;
			this.label2.Text = "Returned Books";
			// 
			// viewData2
			// 
			this.viewData2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewData2.Location = new System.Drawing.Point(4, 270);
			this.viewData2.Name = "viewData2";
			this.viewData2.Size = new System.Drawing.Size(1010, 188);
			this.viewData2.TabIndex = 5;
			// 
			// CompleteBookDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Wheat;
			this.ClientSize = new System.Drawing.Size(1026, 460);
			this.Controls.Add(this.viewData2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.viewData1);
			this.Controls.Add(this.label1);
			this.Name = "CompleteBookDetails";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CompleteBookDetails";
			this.Load += new System.EventHandler(this.CompleteBookDetails_Load);
			((System.ComponentModel.ISupportInitialize)(this.viewData1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewData2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView viewData1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView viewData2;
	}
}