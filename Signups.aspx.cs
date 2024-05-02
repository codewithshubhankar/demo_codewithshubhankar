using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Ecommerce_website_Signups : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-L5B8JV8\\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private void messageBox(string sms)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Showalert", "alert('" + sms + "')", true);
    }

    protected void BtnSignup_Click(object sender, EventArgs e)
    {
        try
        {
            string connectionString = "Data Source=DESKTOP-L5B8JV8\\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Signuptable(Name, Email, Gender, Mobile, Locality, City, State, Pincode, UserName, Password, Full_Address, Date) VALUES(@Name, @Email, @Gender, @Mobile, @Locality, @City, @State, @Pincode, @UserName, @Password, @Full_Address, GETDATE())", con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue); // Use SelectedValue instead of Text for dropdowns
                    cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);
                    cmd.Parameters.AddWithValue("@Locality", txtLocality.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@State", txtState.Text);
                    cmd.Parameters.AddWithValue("@Pincode", txtPincode.Text);
                    cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@Full_Address", txtFullAddress.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        messageBox("Sign up successful");
                    }
                    else
                    {
                        messageBox("Sign up failed");
                    }
                }
            }
        }
        catch (SqlException ex)
        {
            messageBox("Sign up failed due to a database error: " + ex.Message);
        }
        catch (Exception ex)
        {
            messageBox("Sign up failed: " + ex.Message);
        }
    }

}
