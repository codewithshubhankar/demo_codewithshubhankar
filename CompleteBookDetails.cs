using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
	public partial class CompleteBookDetails : Form
	{
		public CompleteBookDetails()
		{
			InitializeComponent();
		}

		private void CompleteBookDetails_Load(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True"))
				{
					con.Open();

					try
					{
						using (SqlCommand cmdNull = new SqlCommand("SELECT * FROM IRBook WHERE book_return_date IS NULL", con))
						{
							SqlDataAdapter daNull = new SqlDataAdapter(cmdNull);
							DataSet dsNull = new DataSet();
							daNull.Fill(dsNull);
							viewData1.DataSource = dsNull.Tables[0];
						}
					}
					catch (Exception exNull)
					{
						MessageBox.Show("An error occurred while retrieving books with NULL return date: " + exNull.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

					try
					{
						using (SqlCommand cmdNotNull = new SqlCommand("SELECT * FROM IRBook WHERE book_return_date IS NOT NULL", con))
						{
							SqlDataAdapter daNotNull = new SqlDataAdapter(cmdNotNull);
							DataSet dsNotNull = new DataSet();
							daNotNull.Fill(dsNotNull);
							viewData2.DataSource = dsNotNull.Tables[0];
						}
					}
					catch (Exception exNotNull)
					{
						MessageBox.Show("An error occurred while retrieving books with NOT NULL return date: " + exNotNull.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
