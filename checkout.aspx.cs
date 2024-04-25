using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public partial class checkout : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Populate dropdown list with countries
        }
    }

   

    protected void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        // Retrieve form data
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string email = txtEmail.Text;
        string mobileNo = txtMobileNo.Text;
        //string addressLine1 = txtAddressLine1.Text;
        //string addressLine2 = txtAddressLine2.Text;
        //string country = DropDownList1.SelectedValue;
        string city = txtCity.Text;
        string state = txtState.Text;
        string zipCode = txtZipCode.Text;

        // Retrieve shipping address data if different
        string shippingFirstName = txtShippingFirstName.Text;
        string shippingLastName = txtShippingLastName.Text;
        string shippingEmail = txtShippingEmail.Text;
        string shippingMobileNo = txtShippingMobileNo.Text;
        //string shippingAddressLine1 = txtShippingAddressLine1.Text;
        //string shippingAddressLine2 = txtShippingAddressLine2.Text;
        string shippingCountry = ddlShippingCountry.SelectedValue;
        string shippingCity = txtShippingCity.Text;
        string shippingState = txtShippingState.Text;
        string shippingZIPCode = txtShippingZIPCode.Text;

        // Calculate total amount (example)
        decimal totalAmount = 160.00m;

        // Retrieve selected payment method
        string paymentMethod = GetSelectedPaymentMethod();

        // Save checkout info to database
        SaveCheckoutInfo(firstName, lastName, email, mobileNo,city, state, zipCode,
            shippingFirstName, shippingLastName, shippingEmail, shippingMobileNo,
            shippingCountry, shippingCity, shippingState, shippingZIPCode, totalAmount, paymentMethod);

        // Redirect to confirmation page or display success message
        Response.Redirect("OrderConfirmation.aspx");
    }

    private void SaveCheckoutInfo(string firstName, string lastName, string email, string mobileNo, string city, string state, string zipCode, string shippingFirstName, string shippingLastName, string shippingEmail, string shippingMobileNo, string shippingCountry, string shippingCity, string shippingState, string shippingZIPCode, decimal totalAmount, string paymentMethod)
    {
        throw new NotImplementedException();
    }

    //private void PopulateCountries()
    //{
    //    // Populate countries dropdown list (example)
    //    DropDownList1.Items.Add(new ListItem("United States", "US"));
    //    DropDownList1.Items.Add(new ListItem("Afghanistan", "AF"));
    //    DropDownList1.Items.Add(new ListItem("Albania", "AL"));
    //    DropDownList1.Items.Add(new ListItem("Algeria", "DZ"));
    //    // Add more countries as needed
    //}

    private string GetSelectedPaymentMethod()
    {
        // Determine selected payment method (example)
        if (rbPaypal.Checked)
        {
            return "Paypal";
        }
        else if (rbDirectCheck.Checked)
        {
            return "Direct Check";
        }
        else if (rbBankTransfer.Checked)
        {
            return "Bank Transfer";
        }
        else
        {
            return string.Empty; // No payment method selected
        }
    }

    private void SaveCheckoutInfo(string firstName, string lastName, string email, string mobileNo, string addressLine1,
        string addressLine2, string country, string city, string state, string zipCode, string shippingFirstName,
        string shippingLastName, string shippingEmail, string shippingMobileNo, string shippingAddressLine1,
        string shippingAddressLine2, string shippingCountry, string shippingCity, string shippingState,
        string shippingZIPCode, decimal totalAmount, string paymentMethod)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["dbms"].ConnectionString;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand("INSERT INTO CheckoutInfo (FirstName, LastName, Email, MobileNo, AddressLine1, AddressLine2, " +
                "Country, City, State, ZIPCode, ShippingFirstName, ShippingLastName, ShippingEmail, ShippingMobileNo, ShippingAddressLine1, " +
                "ShippingAddressLine2, ShippingCountry, ShippingCity, ShippingState, ShippingZIPCode, TotalAmount, PaymentMethod) " +
                "VALUES (@FirstName, @LastName, @Email, @MobileNo, @AddressLine1, @AddressLine2, @Country, @City, @State, @ZIPCode, " +
                "@ShippingFirstName, @ShippingLastName, @ShippingEmail, @ShippingMobileNo, @ShippingAddressLine1, @ShippingAddressLine2, " +
                "@ShippingCountry, @ShippingCity, @ShippingState, @ShippingZIPCode, @TotalAmount, @PaymentMethod)", connection);

            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@MobileNo", mobileNo);
            command.Parameters.AddWithValue("@AddressLine1", addressLine1);
            command.Parameters.AddWithValue("@AddressLine2", addressLine2);
            command.Parameters.AddWithValue("@Country", country);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@State", state);
            command.Parameters.AddWithValue("@ZIPCode", zipCode);
            command.Parameters.AddWithValue("@ShippingFirstName", shippingFirstName);
            command.Parameters.AddWithValue("@ShippingLastName", shippingLastName);
            command.Parameters.AddWithValue("@ShippingEmail", shippingEmail);
            command.Parameters.AddWithValue("@ShippingMobileNo", shippingMobileNo);
            command.Parameters.AddWithValue("@ShippingAddressLine1", shippingAddressLine1);
            command.Parameters.AddWithValue("@ShippingAddressLine2", shippingAddressLine2);
            command.Parameters.AddWithValue("@ShippingCountry", shippingCountry);
            command.Parameters.AddWithValue("@ShippingCity", shippingCity);
            command.Parameters.AddWithValue("@ShippingState", shippingState);
            command.Parameters.AddWithValue("@ShippingZIPCode", shippingZIPCode);
            command.Parameters.AddWithValue("@TotalAmount", totalAmount);
            command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
