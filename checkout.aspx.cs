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

public partial class Ecommerce_website_checkout : System.Web.UI.Page
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
            con.Open();

            // Insert into CheckoutTable
            SqlCommand cmd = new SqlCommand("INSERT INTO CheckoutTable(First_Name,Last_Name,Company_Name,Address,Apartment,State,Postal,Email_Address,Phone,Order_Notes,SubCatName,OfferPrice,Discount,Total) VALUES (@First_Name,@Last_Name,@Company_Name,@Address,@Apartment,@State,@Postal,@Email_Address,@Phone,@Order_Notes,@SubCatName,@OfferPrice,@Discount,@Total)", con);
            cmd.Parameters.Add("@First_Name", SqlDbType.VarChar).Value = c_fname.Text;
            cmd.Parameters.Add("@Last_Name", SqlDbType.VarChar).Value = c_lname.Text;
            cmd.Parameters.Add("@Company_Name", SqlDbType.VarChar).Value = c_companyname.Text;
            cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = c_address.Text;
            cmd.Parameters.Add("@Apartment", SqlDbType.VarChar).Value = apartment.Text;
            cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = c_state_country.Text;
            cmd.Parameters.Add("@Postal", SqlDbType.VarChar).Value = c_postal_zip.Text;
            cmd.Parameters.Add("@Email_Address", SqlDbType.VarChar).Value = c_email_address.Text;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = c_phone.Text;
            cmd.Parameters.Add("@Order_Notes", SqlDbType.VarChar).Value = c_order_notes.Text;
            cmd.Parameters.Add("@SubCatName", SqlDbType.VarChar).Value = lblSubCatName.Text;
            cmd.Parameters.Add("@OfferPrice", SqlDbType.Decimal).Value = Convert.ToDecimal(lblSubtotal.Text);
            cmd.Parameters.Add("@Discount", SqlDbType.Decimal).Value = Convert.ToDecimal(lbldiscount.Text);
            cmd.Parameters.Add("@Total", SqlDbType.Decimal).Value = Convert.ToDecimal(lblTotal.Text);
            cmd.ExecuteNonQuery();

            MessageBox("DATA SAVED");
        }
        catch (Exception )
        {
            // Handle exceptions
        }
        finally
        {
            con.Close();
        }

    }
}
