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
	public partial class AddBook : Form
	{
		public AddBook()
		{
			InitializeComponent();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (txtBookName.Text != "" && txtBookAuthorName.Text != "" && txtBookPublication.Text != "" && txtBookPrice.Text != "" && txtBookQuantity.Text != "")
			{
				string bname = txtBookName.Text;
				string bauthor = txtBookAuthorName.Text;
				string publication = txtBookPublication.Text;
				string pDate = BookPurchaseDate.Text;
				Int64 price = Int64.Parse(txtBookPrice.Text);
				Int64 quan = Int64.Parse(txtBookQuantity.Text);

				SqlConnection con = new SqlConnection();
				con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

				SqlCommand cmd = new SqlCommand();
				cmd.Connection = con;

				con.Open();

				cmd.CommandText = "INSERT INTO Addbook (bname, bauthor, bPubl, bPDate, bPrice, bquan) VALUES ('" + bname + "','" + bauthor +
					"','" + publication + "','" + pDate + "'," + price + "," + quan + ")";

				cmd.ExecuteNonQuery();

				con.Close();

				MessageBox.Show("Book Added.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtBookName.Clear();
				txtBookAuthorName.Clear();
				txtBookPublication.Clear();
				txtBookPrice.Clear();
				txtBookQuantity.Clear();
			}
			else
			{
				MessageBox.Show("Empty Field Not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will DELETE your Unsaved DATA.", "Are you Sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{ 
			   this.Close();
			}
			txtBookName.Clear();
			txtBookAuthorName.Clear();
			txtBookPublication.Clear();
			txtBookPrice.Clear();
			txtBookQuantity.Clear();
		} 
	}

}



