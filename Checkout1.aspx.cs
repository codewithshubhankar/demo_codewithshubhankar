using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;

public partial class Ecommerce_website_Checkout1 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True");


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCartData();
        }
    }



    private void MessageBox(string msg)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Showalert", "alert('" + msg + "')", true);
    }

    private void BindCartData()
    {
        DataTable cartItems = (DataTable)Session["cartitem"];
        if (cartItems != null && cartItems.Rows.Count > 0)
        {
            //Repeater1.DataSource = cartItems;
            //Repeater1.DataBind();


            double subtotal = CalculateSubtotal(cartItems);
            lblSubtotal.Text = subtotal.ToString(); // Display subtotal

            double discount = CalculateDiscount(subtotal); // Calculate discount based on subtotal
            lbldiscount.Text = discount.ToString(); // Display discount

            double total = subtotal - discount; // Subtract discount from subtotal to get total

            lblTotal.Text = total.ToString(); // Display total


            int quantity = CalculateQuantity(cartItems);
            lblQuantity.Text = quantity.ToString(); // Display total quantity of items



            string SubCatName = string.Join(", ", cartItems.AsEnumerable().Select(row => row.Field<string>("SubCatName")));

            lblSubCatName.Text = SubCatName; // Display concatenated product names
        }
        else
        {

            lblSubCatName.Text = "";
            lblSubtotal.Text = "0.00"; // Display 0 as subtotal when cart is empty
            lbldiscount.Text = "0.00"; // Display 0 as discount when cart is empty
            lblTotal.Text = "0.00"; // Display 0 as total when cart is empty
            lblQuantity.Text = ""; // Display 0 as quantity when cart is empty
        }
    }


    private int CalculateQuantity(DataTable cartItems)
    {
        int quantity = 0;
        foreach (DataRow row in cartItems.Rows)
        {
            int itemQuantity = Convert.ToInt32(row["Quantity"]);
            quantity += itemQuantity;
        }
        return quantity;
    }
    private double CalculateDiscount(double subtotal)
    {
        if (subtotal > 100)
        {
            return subtotal * 0.03; // 10% discount
        }
        else
        {
            return 0; // No discount
        }

    }

    private double CalculateSubtotal(DataTable cartItems)
    {
        double subtotal = 0;
        foreach (DataRow row in cartItems.Rows)
        {
            subtotal += Convert.ToDouble(row["TotalPrice"]);
        }
        return subtotal;
    }

    int id;


    protected void ddlPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnPrintBill_Click(object sender, EventArgs e)
    {
        // Generate PDF bill
        GeneratePDFBill();
    }


    private void GeneratePDFBill()
    {
        using (MemoryStream memoryStream = new MemoryStream())
        {
            try
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);

                doc.Open();

                PdfPTable table = new PdfPTable(2);

                string connectionString = @"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True";
                string query = "SELECT First_Name,Last_Name, Company_Name,Address,Apartment,State,Postal,Email_Address,Phone,Order_Notes,SubCatName,OfferPrice,Discount,Total ,Quantity FROM CheckoutTable where Id=Id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add data to PDF table                       
                        table.AddCell(reader["First_Name"].ToString());
                        table.AddCell(reader["Last_Name"].ToString());
                        table.AddCell(reader["Company_Name"].ToString());
                        table.AddCell(reader["Address"].ToString());
                        table.AddCell(reader["Apartment"].ToString());
                        table.AddCell(reader["State"].ToString());
                        table.AddCell(reader["Postal"].ToString());
                        table.AddCell(reader["Email_Address"].ToString());
                        table.AddCell(reader["Phone"].ToString());
                        table.AddCell(reader["Order_Notes"].ToString());
                        table.AddCell(reader["SubCatName"].ToString());
                        table.AddCell(reader["OfferPrice"].ToString());
                        table.AddCell(reader["Discount"].ToString());
                        table.AddCell(reader["Total"].ToString());
                        table.AddCell(reader["Quantity"].ToString());

                    }
                }

                doc.Add(table);

                doc.Close();

                Response.Clear();
                Response.ContentType = "application/pdf";
                Response.AddHeader("Content-Disposition", "attachment; filename=Bill.pdf");
                Response.Cache.SetCacheability(HttpCacheability.NoCache);

                Response.BinaryWrite(memoryStream.ToArray());
            }
            catch (Exception ex)
            {
                Response.Write("An error occurred: " + ex.Message);
            }
            finally
            {
                memoryStream.Dispose();
                Response.End();
            }
        }
    }






    protected void btnPlaceOrder_Click1(object sender, EventArgs e)
    {
        try
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(c_fname.Text) || string.IsNullOrWhiteSpace(c_lname.Text) ||
                string.IsNullOrWhiteSpace(c_address.Text) || string.IsNullOrWhiteSpace(c_state_country.Text) ||
                string.IsNullOrWhiteSpace(c_postal_zip.Text) || string.IsNullOrWhiteSpace(c_email_address.Text) ||
                string.IsNullOrWhiteSpace(c_phone.Text))
            {
                // Display an error message if any required field is empty
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Please fill in all required fields.');", true);
                return;
            }

            // Establish connection to the database
            string connectionString = ConfigurationManager.ConnectionStrings["dbms"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Define SQL query to insert order details into the CheckoutTable
                string query = @"INSERT INTO CheckoutTable
                        (First_Name, Last_Name, Company_Name, Address, Apartment, State, Postal, Email_Address, Phone, Order_Notes, SubCatName, OfferPrice, Discount, Total, Quantity)
                        VALUES
                        (@First_Name, @Last_Name, @Company_Name, @Address, @Apartment, @State, @Postal, @Email_Address, @Phone, @Order_Notes, @SubCatName, @OfferPrice, @Discount, @Total, @Quantity)";
                // Create a SQL command with parameters
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@First_Name", c_fname.Text);
                    cmd.Parameters.AddWithValue("@Last_Name", c_lname.Text);
                    cmd.Parameters.AddWithValue("@Company_Name", string.IsNullOrWhiteSpace(c_companyname.Text) ? (object)DBNull.Value : c_companyname.Text);
                    cmd.Parameters.AddWithValue("@Address", c_address.Text);
                    cmd.Parameters.AddWithValue("@Apartment", string.IsNullOrWhiteSpace(apartment.Text) ? (object)DBNull.Value : apartment.Text);
                    cmd.Parameters.AddWithValue("@State", c_state_country.Text);
                    cmd.Parameters.AddWithValue("@Postal", c_postal_zip.Text);
                    cmd.Parameters.AddWithValue("@Email_Address", c_email_address.Text);
                    cmd.Parameters.AddWithValue("@Phone", c_phone.Text);
                    cmd.Parameters.AddWithValue("@Order_Notes", string.IsNullOrWhiteSpace(c_order_notes.Text) ? (object)DBNull.Value : c_order_notes.Text);
                    cmd.Parameters.AddWithValue("@SubCatName", lblSubCatName.Text);
                    cmd.Parameters.AddWithValue("@OfferPrice", Convert.ToDecimal(lblSubtotal.Text));
                    cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(lbldiscount.Text));
                    cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(lblTotal.Text));
                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(lblQuantity.Text));

                    // Execute the SQL command
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        // Order placed successfully
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Order placed successfully!');", true);
                    }
                    else
                    {
                        // Failed to place order
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Failed to place order. Please try again later.');", true);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('An error occurred: " + ex.Message + "');", true);
        }
    }
}
//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.IO;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

//public partial class Ecommerce_website_Checkout1 : System.Web.UI.Page
//{

//    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True");

//    protected void Page_Load(object sender, EventArgs e)
//    {
//        if (!IsPostBack)
//        {
//            BindCartData();
//        }
//    }


//    private void MessageBox(string msg)
//    {
//        ScriptManager.RegisterStartupScript(this, GetType(), "Showalert", "alert('" + msg + "')", true);
//    }
//    private void BindCartData()
//    {
//        DataTable cartItems = (DataTable)Session["cartitem"];
//        if (cartItems != null && cartItems.Rows.Count > 0)
//        {
//            double subtotal = CalculateSubtotal(cartItems);
//            lblSubtotal.Text = subtotal.ToString("0.00");

//            double discount = CalculateDiscount(subtotal);
//            lbldiscount.Text = discount.ToString("0.00");

//            double total = subtotal - discount;
//            lblTotal.Text = total.ToString("0.00");

//            int quantity = CalculateQuantity(cartItems);
//            lblQuantity.Text = quantity.ToString();

//            string subCatNames = string.Join(", ", cartItems.AsEnumerable().Select(row => row.Field<string>("SubCatName")));
//            lblSubCatName.Text = subCatNames;
//        }
//        else
//        {
//            ClearLabels();
//        }
//    }

//    private void ClearLabels()
//    {
//        lblSubCatName.Text = "";
//        lblSubtotal.Text = "0.00";
//        lbldiscount.Text = "0.00";
//        lblTotal.Text = "0.00";
//        lblQuantity.Text = "";
//    }

//    private int CalculateQuantity(DataTable cartItems)
//    {
//        int quantity = 0;
//        foreach (DataRow row in cartItems.Rows)
//        {
//            quantity += Convert.ToInt32(row["Quantity"]);
//        }
//        return quantity;
//    }

//    private double CalculateDiscount(double subtotal)
//    {
//        return subtotal > 100 ? subtotal * 0.03 : 0;
//    }

//    private double CalculateSubtotal(DataTable cartItems)
//    {
//        double subtotal = 0;
//        foreach (DataRow row in cartItems.Rows)
//        {
//            subtotal += Convert.ToDouble(row["TotalPrice"]);
//        }
//        return subtotal;
//    }

//    protected void btnPrintBill_Click(object sender, EventArgs e)
//    {
//        GeneratePDFBill();
//    }

//    private void GeneratePDFBill()
//    {
//        using (MemoryStream memoryStream = new MemoryStream())
//        {
//            try
//            {
//                Document doc = new Document();
//                PdfWriter writer = PdfWriter.GetInstance(doc, memoryStream);
//                doc.Open();

//                PdfPTable table = new PdfPTable(2);
//                table.AddCell("Field");
//                table.AddCell("Value");

//                table.AddCell("First Name");
//                table.AddCell(c_fname.Text);
//                table.AddCell("Last Name");
//                table.AddCell(c_lname.Text);

//                doc.Add(table);
//                doc.Close();

//                Response.Clear();
//                Response.ContentType = "application/pdf";
//                Response.AddHeader("Content-Disposition", "attachment; filename=Bill.pdf");
//                Response.Cache.SetCacheability(HttpCacheability.NoCache);
//                Response.BinaryWrite(memoryStream.ToArray());
//            }
//            catch (Exception ex)
//            {
//                MessageBox("An error occurred: " + ex.Message);
//            }
//        }
//    }


//    protected void btnPlaceOrder_Click1(object sender, EventArgs e)
//    {
//        try
//        {
//            string connectionString = @"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True";
//            using (SqlConnection con = new SqlConnection(connectionString))
//            {
//                con.Open();
//                string query = @"INSERT INTO CheckoutTable
//                            (First_Name, Last_Name, Company_Name, Address, Apartment, State, Postal, Email_Address, Phone, Order_Notes, SubCatName, OfferPrice, Discount, Total, Quantity)
//                            VALUES
//                            (@First_Name, @Last_Name, @Company_Name, @Address, @Apartment, @State, @Postal, @Email_Address, @Phone, @Order_Notes, @SubCatName, @OfferPrice, @Discount, @Total, @Quantity)";
//                using (SqlCommand cmd = new SqlCommand(query, con))
//                {
//                    cmd.Parameters.AddWithValue("@First_Name", c_fname.Text);
//                    cmd.Parameters.AddWithValue("@Last_Name", c_lname.Text);
//                    cmd.Parameters.AddWithValue("@Company_Name", c_companyname.Text);
//                    cmd.Parameters.AddWithValue("@Address", c_address.Text);
//                    cmd.Parameters.AddWithValue("@Apartment", apartment.Text);
//                    cmd.Parameters.AddWithValue("@State", c_state_country.Text);
//                    cmd.Parameters.AddWithValue("@Postal", c_postal_zip.Text);
//                    cmd.Parameters.AddWithValue("@Email_Address", c_email_address.Text);
//                    cmd.Parameters.AddWithValue("@Phone", c_phone.Text);
//                    cmd.Parameters.AddWithValue("@Order_Notes", c_order_notes.Text);
//                    cmd.Parameters.AddWithValue("@SubCatName", lblSubCatName.Text);
//                    cmd.Parameters.AddWithValue("@OfferPrice", Convert.ToDecimal(lblSubtotal.Text));
//                    cmd.Parameters.AddWithValue("@Discount", Convert.ToDecimal(lbldiscount.Text));
//                    cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(lblTotal.Text));
//                    cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(lblQuantity.Text));

//                    int rowsAffected = cmd.ExecuteNonQuery();
//                    if (rowsAffected > 0)
//                    {
//                        // Order placed successfully
//                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Order placed successfully!');", true);
//                    }
//                    else
//                    {
//                        // Failed to place order
//                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Failed to place order. Please try again later.');", true);
//                    }
//                }
//            }
//        }
//        catch (Exception ex)
//        {
//            // Handle exceptions
//            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('An error occurred: " + ex.Message + "');", true);
//        }
//    }
//}


