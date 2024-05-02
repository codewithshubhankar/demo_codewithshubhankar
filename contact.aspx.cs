using System;
using System.Data.SqlClient;

public partial class Ecommerce_website_contact : System.Web.UI.Page
{
    protected void btnSend_Click(object sender, EventArgs e)
    {
        // Read form data
        string name = txtName.Text;
        string email = txtEmail.Text;
        string phone = txtPhone.Text;
        string message = txtMessage.Text;

        // Get connection string from configuration file
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbms"].ConnectionString;

        // Use a SqlConnection object without passing the connection string in the constructor
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Specify the connection string in the SqlConnection object

            string query = "INSERT INTO ContactMessages (Name, Email, Phone, Message) VALUES (@Name, @Email, @Phone, @Message)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Message", message);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    // Data inserted successfully
                    lblMessage.Text = "Your message has been sent successfully.";
                    lblMessage.CssClass = "text-success";
                }
                else
                {
                    // Failed to insert data
                    lblMessage.Text = "Failed to send message. Please try again later.";
                    lblMessage.CssClass = "text-danger";
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                lblMessage.Text = "An error occurred: " + ex.Message;
                lblMessage.CssClass = "text-danger";
            }
            finally
            {
                // Close the connection
                connection.Close();
            }
        }
    }

}
