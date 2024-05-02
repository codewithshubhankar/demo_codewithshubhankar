using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class Ecommerce_website_login_form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string password = txtPassword.Text.Trim();

        // Validate the user's credentials
        if (ValidateUser(email, password))
        {
            // Redirect the user to the desired page after successful login
            Response.Redirect("~/Ecommerce-website/Default.aspx");
        }
        else      
        {
            // Display error message if login fails
            Response.Write("<script>alert('Invalid email or password. Please try again.');</script>");
        }
    }

    private bool ValidateUser(string email, string password)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbms"].ConnectionString;

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users2 WHERE Email = @Email AND Password = @Password", con))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                return count > 0;
            }
        }
    }
}
