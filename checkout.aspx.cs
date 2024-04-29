using System;
using System.Data;
using System.Data.SqlClient;

public partial class checkout : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Load initial data or perform any necessary tasks when the page loads for the first time
        }
    }

    protected void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        string connectionString = @"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True";

        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string email = txtEmail.Text;
        string mobileNo = txtMobileNo.Text;
        string address1 = txtAddress1.Text;
        string address2 = txtAddress2.Text;
        string country = ddlCountry.SelectedValue;
        string city = txtCity.Text;
        string state = txtState.Text;
        string zipCode = txtZipCode.Text;

        // Assuming you have an Orders table with appropriate fields
        string query = "INSERT INTO Orders (FirstName, LastName, Email, MobileNo, Address1, Address2, Country, City, State, ZipCode) " +
                       "VALUES (@FirstName, @LastName, @Email, @MobileNo, @Address1, @Address2, @Country, @City, @State, @ZipCode)";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@MobileNo", mobileNo);
                command.Parameters.AddWithValue("@Address1", address1);
                command.Parameters.AddWithValue("@Address2", address2);
                command.Parameters.AddWithValue("@Country", country);
                command.Parameters.AddWithValue("@City", city);
                command.Parameters.AddWithValue("@State", state);
                command.Parameters.AddWithValue("@ZipCode", zipCode);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Order placed successfully, you can redirect to a thank you page or show a success message
                        Response.Redirect("ThankYou.aspx");
                    }
                    else
                    {
                        // Failed to place order, handle accordingly
                        // You can display an error message or redirect to an error page
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, display an error message or log it
                }
            }
        }
    }
}
