using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
	public partial class viewStudentinformation : Form
	{
		private SqlConnection con;

		public viewStudentinformation()
		{
			InitializeComponent();
		}

		private void txtSearchEnrollmentNumber_TextChanged(object sender, EventArgs e)
		{
			if (txtSearchEnrollmentNumber.Text != "")
			{
				label1.Visible = false;
				Image image = Image.FromFile("C:\\Users\\kshub\\Downloads\\Liberay Management System Icon and Images (3)\\Liberay Management System\\search1.gif");
				pictureBox1.Image = image;

				SqlConnection con = new SqlConnection();
				con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = con;

				cmd.CommandText = "SELECT * FROM NewStudent where enroll  LIKE '"+txtSearchEnrollmentNumber.Text+"%'";
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				da.Fill(ds);
				viewData1.DataSource = ds.Tables[0];
			}
			else
			{
				label1.Visible = true;
				Image image = Image.FromFile("C:\\Users\\kshub\\Downloads\\Liberay Management System Icon and Images (3)\\Liberay Management System\\search.gif");
				pictureBox1.Image = image;
				SqlConnection con = new SqlConnection();
				con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = con;

				cmd.CommandText = "SELECT * FROM NewStudent";

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();
				da.SelectCommand = cmd;
				da.Fill(ds);

				viewData1.DataSource = ds.Tables[0];
			}
		}
		int bid;
		int stuid;

		private void viewStudentinformation_Load(object sender, EventArgs e)
		{
			label1.Visible = false;
			Image image = Image.FromFile("C:\\Users\\kshub\\Downloads\\Liberay Management System Icon and Images (3)\\Liberay Management System\\search1.gif");
			pictureBox1.Image = image;

			SqlConnection con = new SqlConnection();
			con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;

			cmd.CommandText = "SELECT * FROM NewStudent";

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			da.SelectCommand = cmd;
			da.Fill(ds);

			viewData1.DataSource = ds.Tables[0];

		}
		
		Int64 rowid;

		private void viewData1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0 && e.RowIndex < viewData1.Rows.Count)
				{
					object cellValue = viewData1.Rows[e.RowIndex].Cells[0].Value;

					if (cellValue != null && int.TryParse(cellValue.ToString(), out stuid))
					{
						panel1.Visible = true;

						using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True"))
						{
							con.Open();

							using (SqlCommand cmd = new SqlCommand())
							{
								cmd.Connection = con;
								cmd.CommandText = "SELECT * FROM NewStudent WHERE stuid = @bid";
								cmd.Parameters.AddWithValue("@bid", stuid);

								using (SqlDataAdapter da = new SqlDataAdapter(cmd))
								{
									DataSet ds = new DataSet();
									da.Fill(ds);

									if (ds.Tables[0].Rows.Count > 0)
									{
										rowid = Convert.ToInt64(ds.Tables[0].Rows[0][0]);

										txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
										txtEnrollment.Text = ds.Tables[0].Rows[0][2].ToString();
										txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
										txtStudentSemester.Text = ds.Tables[0].Rows[0][4].ToString();
										txtStudentContact.Text = ds.Tables[0].Rows[0][5].ToString();
										txtStudentEmail.Text = ds.Tables[0].Rows[0][6].ToString();
									}
									else
									{
										MessageBox.Show("Selected row not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
							}

							con.Close();
						}
					}
					else
					{
						MessageBox.Show("Invalid stuid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string sname = txtStudentName.Text;
				string enroll = txtEnrollment.Text;
				string dep = txtDepartment.Text;
				string sem = txtStudentSemester.Text;
				Int64 contact = Int64.Parse(txtStudentContact.Text);
				string stuemail = txtStudentEmail.Text;

				SqlConnection con = new SqlConnection();
				con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

				SqlCommand cmd = new SqlCommand();
				cmd.Connection = con;
				cmd.CommandText = "UPDATE NewStudent SET sname = @sname, enroll = @enroll, dep = @dep, stsem = @stsem, contact = @contact, stuemail = @stuemail WHERE stuid = @rowid";

				cmd.Parameters.AddWithValue("@sname", sname);
				cmd.Parameters.AddWithValue("@enroll", enroll);
				cmd.Parameters.AddWithValue("@dep", dep);
				cmd.Parameters.AddWithValue("@stsem", sem);
				cmd.Parameters.AddWithValue("@contact", contact);
				cmd.Parameters.AddWithValue("@stuemail", stuemail);
				cmd.Parameters.AddWithValue("@rowid", rowid);

				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
				

				MessageBox.Show("Data Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		private void btnRefresh1_Click(object sender, EventArgs e)
		{
			txtStudentName.Clear();
			panel2.Visible = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to Cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


			if (result == DialogResult.Yes)
			{
				panel2.Visible = false;

			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result == DialogResult.Yes)
				{
					SqlConnection con = new SqlConnection();
					con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

					SqlCommand cmd = new SqlCommand();
					cmd.Connection = con;
					cmd.CommandText = "DELETE FROM NewStudent WHERE stuid = @rowid";
					cmd.Parameters.AddWithValue("@rowid", rowid);

					con.Open();
					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("Data Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					
					txtStudentName.Clear();
					panel2.Visible = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}



	


