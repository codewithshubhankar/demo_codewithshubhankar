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
	public partial class ViewBook : Form
	{
		public ViewBook()
		{
			InitializeComponent();
		}

		private void ViewBook_Load(object sender, EventArgs e)
		{
			panel2.Visible = false;
			SqlConnection con = new SqlConnection();
			con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;
			cmd.CommandText = "SELECT * FROM Addbook";

			SqlDataAdapter da = new SqlDataAdapter();
			DataSet ds = new DataSet();
			da.SelectCommand = cmd;
			da.Fill(ds);


			viewData.DataSource = ds.Tables[0];
		}
		int bid;
		Int64 rowid;
		private void viewData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0 && e.RowIndex < viewData.Rows.Count)
				{
					object cellValue = viewData.Rows[e.RowIndex].Cells[0].Value;

					if (cellValue != null && int.TryParse(cellValue.ToString(), out bid))
					{
						panel2.Visible = true;

						SqlConnection con = new SqlConnection();
						con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

						SqlCommand cmd = new SqlCommand();
						cmd.Connection = con;
						cmd.CommandText = "SELECT * FROM Addbook WHERE bid = @bid";
						cmd.Parameters.AddWithValue("@bid", bid);

						SqlDataAdapter da = new SqlDataAdapter();
						DataSet ds = new DataSet();
						da.SelectCommand = cmd;
						da.Fill(ds);

						if (ds.Tables[0].Rows.Count > 0)
						{
							rowid = Convert.ToInt64(ds.Tables[0].Rows[0][0]);

							txtBookNam.Text = ds.Tables[0].Rows[0][1].ToString();
							txtBookAuthorName.Text = ds.Tables[0].Rows[0][2].ToString();
							txtBookPublication.Text = ds.Tables[0].Rows[0][3].ToString();
							BookPurchaseDate.Text = ds.Tables[0].Rows[0][4].ToString();
							txtBookPrice.Text = ds.Tables[0].Rows[0][5].ToString();
							txtBookQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
						}
						else
						{
							
							MessageBox.Show("Selected row not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						
						MessageBox.Show("Invalid bid value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Are you sure you want to Cancel?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			
			if (result == DialogResult.Yes)
			{
				panel2.Visible = false;
				
			}
		}

		private void txtBookName_TextChanged(object sender, EventArgs e)
		{
			if (txtBookName.Text != "")
			{
				SqlConnection con = new SqlConnection();
				con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

				SqlCommand cmd = new SqlCommand();
				cmd.Connection = con;
				cmd.CommandText = "SELECT * FROM Addbook WHERE bname LIKE @BookName";
				cmd.Parameters.AddWithValue("@BookName", txtBookName.Text + "%");

				SqlDataAdapter da = new SqlDataAdapter();
				DataSet ds = new DataSet();
				da.SelectCommand = cmd;
				da.Fill(ds);


				viewData.DataSource = ds.Tables[0];
			}

			else
			{
				SqlConnection con = new SqlConnection();
				con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

				SqlCommand cmd = new SqlCommand();
				cmd.Connection = con;
				cmd.CommandText = "SELECT * FROM Addbook";

				SqlDataAdapter da = new SqlDataAdapter();
				DataSet ds = new DataSet();
				da.SelectCommand = cmd;
				da.Fill(ds);


				viewData.DataSource = ds.Tables[0];
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			txtBookName.Clear();
			panel2.Visible = false;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			try
			{
				string bname = txtBookNam.Text;
				string bauthor = txtBookAuthorName.Text;
				string publication = txtBookPublication.Text;
				string pdate = BookPurchaseDate.Text;
				Int64 price = Int64.Parse(txtBookPrice.Text);
				Int64 quan = Int64.Parse(txtBookQuantity.Text);

				SqlConnection con = new SqlConnection();
				con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

				SqlCommand cmd = new SqlCommand();
				cmd.Connection = con;
				cmd.CommandText = "UPDATE Addbook SET bname = @bname, bAuthor = @bauthor, bPubl = @publication, bPDate = @pdate, bPrice = @price, bQuan = @quan WHERE bid = @rowid";

				
				cmd.Parameters.AddWithValue("@bname", bname);
				cmd.Parameters.AddWithValue("@bauthor", bauthor);
				cmd.Parameters.AddWithValue("@publication", publication);
				cmd.Parameters.AddWithValue("@pdate", pdate);
				cmd.Parameters.AddWithValue("@price", price);
				cmd.Parameters.AddWithValue("@quan", quan);
				cmd.Parameters.AddWithValue("@rowid", rowid); // Use the rowid you retrieved in the CellClick event

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

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (rowid != 0)
				{
					SqlConnection con = new SqlConnection();
					con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

					SqlCommand cmd = new SqlCommand();
					cmd.Connection = con;
					cmd.CommandText = "DELETE FROM Addbook WHERE bid = @rowid";

					cmd.Parameters.AddWithValue("@rowid", rowid);

					con.Open();
					cmd.ExecuteNonQuery();
					con.Close();

					MessageBox.Show("Data Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);

					
					
				}
				else
				{
					MessageBox.Show("No row selected for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	}
}

