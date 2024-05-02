using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ecommerce_website_signin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void messageBox(string sms)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Showalert", "alert('" + sms + "')", true);
    }

    protected void BtnSignin_Click(object sender, EventArgs e)
    {
        try
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-L5B8JV8\\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True"))
            {
                con.Open();

                string query = "SELECT * FROM Signuptable WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Session["Username"] = txtUserName.Text;
                            messageBox("Login Successful");
                            Response.Redirect("Checkout1.aspx");
                        }
                        else
                        {
                            messageBox("Invalid username or password");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions here
            messageBox("An error occurred: " + ex.Message);
        }
        finally
        {
            // Clear sensitive data
            txtPassword.Text = "";
        }
    }



}