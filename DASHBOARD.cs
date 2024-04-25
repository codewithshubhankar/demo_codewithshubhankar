using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
	public partial class DASHBOARD : Form
	{
		public DASHBOARD()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if( MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes ) 		
			{
				
				Application.Exit();
			}

			
		}

		private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddBook ab = new AddBook();
			ab.Show();
		}

		private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ViewBook vb = new ViewBook();
			vb.Show();
		}

		private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Add_Student ast = new Add_Student();
			ast.Show();
		}

		private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			viewStudentinformation vsi = new viewStudentinformation();
			vsi.Show();
		}

		private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			IssueBooks ie = new IssueBooks();
			ie.Show();
		}

		private void returnsBookToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ReturnBooks rb = new ReturnBooks();
			rb.Show();
		}

		private void completeBookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CompleteBookDetails cbd = new CompleteBookDetails();
			cbd.Show();
		}
	}
}
