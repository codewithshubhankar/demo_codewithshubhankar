using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class Ecommerce_website_profile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Check if user is authenticated and session variables are set
            if (Session["Username"] != null && Session["ProfileImage"] != null)
            {
                Label1.Text = Session["Username"].ToString();
                Image1.ImageUrl = Session["ProfileImage"].ToString();
                // Load data when page first loads
            }
            else
            {
                //Response.Redirect("~/AdminDashboard/LoginPage.aspx");
            }
        }
    }


    //protected void FetchUserDetails()
    //{
    //    string userId = ""; 
    //    string connectionString = ConfigurationManager.ConnectionStrings["dbms"].ConnectionString;

    //    using (SqlConnection con = new SqlConnection(connectionString))
    //    {
    //        string query = "SELECT UserName, Email FROM Users2 WHERE UserId = @UserId";
    //        SqlCommand cmd = new SqlCommand(query, con);
    //        cmd.Parameters.AddWithValue("@UserId", userId);

    //        try
    //        {
    //            con.Open();
    //            SqlDataReader reader = cmd.ExecuteReader();
    //            if (reader.Read())
    //            {
    //                lblUserName.Text = reader["UserName"].ToString();
    //                lblUserEmail.Text = reader["Email"].ToString();
    //            }
    //            reader.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            // Handle any exceptions
    //            // You can log the error, display an error message, etc.
    //        }
    //    }
    //}

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
       
    }
}
