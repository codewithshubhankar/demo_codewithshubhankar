using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
	public partial class ReturnBooks : Form
	{
		public ReturnBooks()
		{
			InitializeComponent();
		}

		private void btnSearchStudent_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtEnrollmentNo.Text))
			{
				string enrollmentId = txtEnrollmentNo.Text;

				using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True"))
				{
					con.Open();

					using (SqlCommand cmd = new SqlCommand("SELECT * FROM IRBook WHERE st_enroll = @st_enroll", con))
					{
						cmd.Parameters.AddWithValue("@st_enroll", enrollmentId);

						using (SqlDataAdapter da = new SqlDataAdapter(cmd))
						{
							DataSet ds = new DataSet();
							da.Fill(ds);

							if (ds.Tables[0].Rows.Count != 0)
							{
								DisplayDataInDataGridView(ds.Tables[0]);
							}
							else
							{
								MessageBox.Show("Invalid ID or No Book Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
					}
				}
			}
		}

		private void DisplayDataInDataGridView(DataTable dataTable)
		{
			// Assuming viewData1 is a DataGridView
			viewData1.DataSource = dataTable;
		}

		private void ReturnBooks_Load(object sender, EventArgs e)
		{
			panel1.Visible = false;
			txtEnrollmentNo.Clear();
		}

		string bname;
		string bdate;
		Int64 rowid;

		private void viewData1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			panel1.Visible = true;

			if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && viewData1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
			{
				rowid = Int64.Parse(viewData1.Rows[e.RowIndex].Cells[0].Value.ToString());
				bname = viewData1.Rows[e.RowIndex].Cells[7].Value?.ToString();
				bdate = viewData1.Rows[e.RowIndex].Cells[8].Value?.ToString();
			}
			txtBookName.Text = bname;
			txtBookIssueDate.Text = bdate;
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection();
			con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			con.Open();
			cmd.CommandText = "update IRBook set book_return_date = '" + dateTimePicker1.Text + "' where st_enroll = '" + txtEnrollmentNo.Text + "' and id=" + rowid + "";
			cmd.ExecuteNonQuery();
			con.Close();

			MessageBox.Show("Return Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

			ReturnBooks_Load(this, null);
		}

		private void txtEnrollmentNo_TextChanged(object sender, EventArgs e)
		{
			if(txtEnrollmentNo.Text == "")
			{
				panel1.Visible= false;
				viewData1.DataSource = null;
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtEnrollmentNo.Clear();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			panel1.Visible = false;
		}
	}
}



