using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_MANAGEMENT_SYSTEM
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		

		private void txtUsername_MouseClick(object sender, MouseEventArgs e)
		{
			if (txtUsername.Text == "Username")
			{
				txtUsername.Clear();
			}
		}

		private void txtPassword_MouseClick(object sender, MouseEventArgs e)
		{
			if (txtPassword.Text == "Password")
			{
				txtPassword.Clear();
				txtPassword.PasswordChar = '*';
			}
		}

		private void Instagram_MouseClick(object sender, MouseEventArgs e)
		{
			string url = "https://www.instagram.com/shubhanka1/";

			
			Process.Start(url);
		}

		private void Facebook_MouseClick(object sender, MouseEventArgs e)
		{
			string url = "https://www.facebook.com/CSDTITSOLUTION";
			Process.Start(url);
		}

		private void YouTube_MouseClick(object sender, MouseEventArgs e)
		{
			string url = "https://www.youtube.com/@csdtitsolutionpvtltd";
			Process.Start(url);
		}

		private void btnLOGIN_Click(object sender, EventArgs e)
		{
		
			SqlConnection con = new SqlConnection();
			con.ConnectionString = "Data Source=DESKTOP-VC6IO7L;Initial Catalog=Management;Integrated Security=True";

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = con;

			cmd.CommandText = "SELECT * FROM loginT WHERE Username = @Username AND Password = @password";
			cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
			cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			try
			{
				con.Open();
				da.Fill(ds);

				if (ds.Tables[0].Rows.Count > 0)
				{
					this.Hide();
					DASHBOARD DS = new DASHBOARD();
					DS.Show();
					MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				
				MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				con.Close();
			}


		}
	}
}
