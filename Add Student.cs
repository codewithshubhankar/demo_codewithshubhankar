using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
	public partial class Add_Student : Form
	{
		public Add_Student()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				this.Close();
			}

		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtStudentName.Clear();
			txtEnrollmentNumber.Clear();
			txtDepartment.Clear();
			txtStudentSemester.Clear();
			txtStudentContact.Clear();
			//txtStudentEmail.Clear();
			txtStudentEmail.Text = "";
		}

		private void btnSaveInfo_Click(object sender, EventArgs e)
		{
			try
			{
				string name = txtStudentName.Text;
				string enroll = txtEnrollmentNumber.Text;
				string dep = txtDepartment.Text;
				string stusem = txtStudentSemester.Text;
				Int64 stuContact = Int64.Parse(txtStudentContact.Text);
				string email = txtStudentEmail.Text;

				using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True"))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand())
					{
						cmd.Connection = con;
						cmd.CommandText = "INSERT INTO NewStudent (sname, enroll, dep, stsem, contact, stuemail) VALUES (@sname, @enroll, @dep, @stsem, @contact, @stuemail)";
						cmd.Parameters.AddWithValue("@sname", name);
						cmd.Parameters.AddWithValue("@enroll", enroll);
						cmd.Parameters.AddWithValue("@dep", dep);
						cmd.Parameters.AddWithValue("@stsem", stusem);
						cmd.Parameters.AddWithValue("@contact", stuContact);
						cmd.Parameters.AddWithValue("@stuemail", email);

						cmd.ExecuteNonQuery();
					}

					con.Close();
				}

				MessageBox.Show("Data Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please fill Empty Fields: " , "suggest", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}
