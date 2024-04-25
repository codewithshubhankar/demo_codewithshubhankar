namespace LIBRARY_MANAGEMENT_SYSTEM
{
	partial class DASHBOARD
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DASHBOARD));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewStudentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.issueBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.returnsBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.completeBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBooksToolStripMenuItem,
            this.returnsBookToolStripMenuItem,
            this.completeBookDetailsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 58);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// booksToolStripMenuItem
			// 
			this.booksToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
			this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBookToolStripMenuItem,
            this.viewBookToolStripMenuItem});
			this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
			this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
			this.booksToolStripMenuItem.Size = new System.Drawing.Size(101, 54);
			this.booksToolStripMenuItem.Text = "Books";
			// 
			// addNewBookToolStripMenuItem
			// 
			this.addNewBookToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
			this.addNewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBookToolStripMenuItem.Image")));
			this.addNewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
			this.addNewBookToolStripMenuItem.Size = new System.Drawing.Size(260, 102);
			this.addNewBookToolStripMenuItem.Text = "Add &New &Book";
			this.addNewBookToolStripMenuItem.Click += new System.EventHandler(this.addNewBookToolStripMenuItem_Click);
			// 
			// viewBookToolStripMenuItem
			// 
			this.viewBookToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
			this.viewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookToolStripMenuItem.Image")));
			this.viewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
			this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(260, 102);
			this.viewBookToolStripMenuItem.Text = "View Book";
			this.viewBookToolStripMenuItem.Click += new System.EventHandler(this.viewBookToolStripMenuItem_Click);
			// 
			// studentToolStripMenuItem
			// 
			this.studentToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
			this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentInfoToolStripMenuItem});
			this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
			this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
			this.studentToolStripMenuItem.Size = new System.Drawing.Size(110, 54);
			this.studentToolStripMenuItem.Text = "Student";
			// 
			// addStudentToolStripMenuItem
			// 
			this.addStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStripMenuItem.Image")));
			this.addStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
			this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(264, 106);
			this.addStudentToolStripMenuItem.Text = "Add Student";
			this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
			// 
			// viewStudentInfoToolStripMenuItem
			// 
			this.viewStudentInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStudentInfoToolStripMenuItem.Image")));
			this.viewStudentInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.viewStudentInfoToolStripMenuItem.Name = "viewStudentInfoToolStripMenuItem";
			this.viewStudentInfoToolStripMenuItem.Size = new System.Drawing.Size(264, 106);
			this.viewStudentInfoToolStripMenuItem.Text = "View Student Info";
			this.viewStudentInfoToolStripMenuItem.Click += new System.EventHandler(this.viewStudentInfoToolStripMenuItem_Click);
			// 
			// issueBooksToolStripMenuItem
			// 
			this.issueBooksToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
			this.issueBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueBooksToolStripMenuItem.Image")));
			this.issueBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
			this.issueBooksToolStripMenuItem.Size = new System.Drawing.Size(130, 54);
			this.issueBooksToolStripMenuItem.Text = "Issue Books";
			this.issueBooksToolStripMenuItem.Click += new System.EventHandler(this.issueBooksToolStripMenuItem_Click);
			// 
			// returnsBookToolStripMenuItem
			// 
			this.returnsBookToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
			this.returnsBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnsBookToolStripMenuItem.Image")));
			this.returnsBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.returnsBookToolStripMenuItem.Name = "returnsBookToolStripMenuItem";
			this.returnsBookToolStripMenuItem.Size = new System.Drawing.Size(139, 54);
			this.returnsBookToolStripMenuItem.Text = "Returns Book";
			this.returnsBookToolStripMenuItem.Click += new System.EventHandler(this.returnsBookToolStripMenuItem_Click);
			// 
			// completeBookDetailsToolStripMenuItem
			// 
			this.completeBookDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Wheat;
			this.completeBookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("completeBookDetailsToolStripMenuItem.Image")));
			this.completeBookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
			this.completeBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(188, 54);
			this.completeBookDetailsToolStripMenuItem.Text = "Complete Book details";
			this.completeBookDetailsToolStripMenuItem.Click += new System.EventHandler(this.completeBookDetailsToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(88, 54);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// DASHBOARD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(800, 473);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "DASHBOARD";
			this.Text = "DASHBOARD";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem issueBooksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem returnsBookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem completeBookDetailsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewStudentInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
	}
}