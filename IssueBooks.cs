using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
	public partial class IssueBooks : Form
	{
		public IssueBooks()
		{
			InitializeComponent();
		}

		private void IssueBooks_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection con = new SqlConnection();
				con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

				con.Open();

				SqlCommand cmd = new SqlCommand("SELECT bname FROM Addbook", con);
				SqlDataReader sdr = cmd.ExecuteReader();

				while (sdr.Read())
				{
					for (int i = 0; i < sdr.FieldCount; i++)
					{
						comboBox1.Items.Add(sdr.GetString(i));
					}
				}

				sdr.Close();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		int count;
		private void btnSearchStudent_Click(object sender, EventArgs e)
		{
			if (txtEnrollment.Text != "")
			{
				string eid = txtEnrollment.Text;

				using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True"))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand("SELECT * FROM NewStudent WHERE enroll = @enroll", con))
					{
						cmd.Parameters.AddWithValue("@enroll", eid);

						using (SqlDataAdapter da = new SqlDataAdapter(cmd))
						{
							DataSet ds = new DataSet();
							da.Fill(ds);


							//--------------------------------------------------------------

							using (SqlCommand cmd1 = new SqlCommand("SELECT count(st_enroll) FROM IRBook WHERE st_enroll = @st_enroll AND book_return_date IS NULL", con))
							{
								cmd1.Parameters.AddWithValue("@st_enroll", eid);

								using (SqlDataAdapter da1 = new SqlDataAdapter(cmd1))
								{
									DataSet ds1 = new DataSet();
									da1.Fill(ds1);
									count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());
								}
							}



							if (ds.Tables[0].Rows.Count != 0)
							{
								txtStudentName.Text = ds.Tables[0].Rows[0][1].ToString();
								txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
								txtStudentSemester.Text = ds.Tables[0].Rows[0][4].ToString();
								txtStudentContact.Text = ds.Tables[0].Rows[0][5].ToString();
								txtStudentEmail.Text = ds.Tables[0].Rows[0][6].ToString();

							}
							else
							{
								txtStudentName.Clear();
								txtDepartment.Clear();
								txtStudentSemester.Clear();
								txtStudentContact.Clear();
								txtStudentEmail.Clear();
								MessageBox.Show("Invalid Enrollment No", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

							}

						}
					}
				}
			}
		}

		private void btnIssueBook_Click(object sender, EventArgs e)
		{
			if (txtStudentName.Text != "")
			{
				if (comboBox1.SelectedIndex != -1 && count <= 2)
				{
					string st_enroll = txtEnrollment.Text;
					string st_name = txtStudentName.Text;
					string st_dep = txtDepartment.Text;
					string st_sem = txtStudentSemester.Text;
					Int64 contact = Int64.Parse(txtStudentContact.Text);
					string stu_email = txtStudentEmail.Text;
					string bookName = comboBox1.Text;
					string bookIssueDate = dateTimePicker1.Text;
					string bookReturnDate = "";



					string eid = txtEnrollment.Text;
					SqlConnection con = new SqlConnection();
					con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

					SqlCommand cmd = new SqlCommand();
					cmd.Connection = con;
					con.Open();
					

					cmd.CommandText = "INSERT INTO IRBook (st_enroll, st_name, st_dep, st_sem, contact, stu_email, book_name, book_issue_date, book_return_date) " +
						"VALUES (@st_enroll, @st_name, @st_dep, @st_sem, @contact, @stu_email, @book_name, @book_issue_date, @book_return_date)";

					cmd.Parameters.AddWithValue("@st_enroll", st_enroll);
					cmd.Parameters.AddWithValue("@st_name", st_name);
					cmd.Parameters.AddWithValue("@st_dep", st_dep);
					cmd.Parameters.AddWithValue("@st_sem", st_sem);
					cmd.Parameters.AddWithValue("@contact", contact);
					cmd.Parameters.AddWithValue("@stu_email", stu_email);
					cmd.Parameters.AddWithValue("@book_name", bookName);
					cmd.Parameters.AddWithValue("@book_issue_date", bookIssueDate);
					cmd.Parameters.AddWithValue("@book_return_date", bookReturnDate);

					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("Book Issued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Selected Book. OR Maximum number of Books Has Been Issued", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Enter valid Enrollment No ","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			
			txtEnrollment.Clear();
			

			
		}

		private void btnExit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				this.Close();
			}
		}

		private void txtEnrollment_TextChanged(object sender, EventArgs e)
		{
			if(txtEnrollment.Text == "")
			{
				txtStudentName.Clear();
				txtDepartment.Clear();
				txtStudentSemester.Clear();
				txtStudentContact.Clear();
				txtStudentEmail.Clear();
			}
		}
	}
}












