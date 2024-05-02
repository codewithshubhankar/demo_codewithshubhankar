using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;

public partial class Ecommerce_website_cart5 : System.Web.UI.Page
{


    int ID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Bind the Repeater with sample data
            BindRepeater();

            BindCartData();



        }
    }

    private void MessageBox(string msg)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Showalert", "alert('" + msg + "')", true);
    }

    //double subTotal = 0;
    //private void BindRepeater()
    //{
    //    if (Session["cartitem"] != null)
    //    {
    //        DataTable dt = (DataTable)Session["cartitem"];
    //        if (dt.Rows.Count > 0)
    //        {
    //            foreach (DataRow dr in dt.Rows)
    //            {
    //                subTotal += double.Parse(dr["Price"].ToString());

    //            }

    //            Repeater1.DataSource = dt;
    //            Repeater1.DataBind();
    //        }
    //        else
    //        {

    //        }

    //    }
    //}
    double subTotal = 0;

    private void BindRepeater()
    {
        if (Session["cartitem"] != null)
        {
            DataTable dt = Session["cartitem"] as DataTable;

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    double price = 0;
                    if (double.TryParse(dr["Price"].ToString(), out price))
                    {
                        subTotal += price;
                    }
                }

                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
        }
        else
        {
            // Handle case where cartitem session is null or empty
            // For example, display a message indicating an empty cart
        }
    }

    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "RemoveFromCart")
        {
            // Get the index of the item to remove
            int rowIndex = e.Item.ItemIndex;

            // Retrieve the DataTable from the session
            DataTable dt = (DataTable)Session["cartitem"];

            // Remove the DataRow at the specified index
            dt.Rows.RemoveAt(rowIndex);

            // Update the session with the modified DataTable
            Session["cartitem"] = dt;

            // Rebind the Repeater to reflect the changes
            BindRepeater();
        }
    }

    //protected void rptParent_ItemDataBound(object sender, RepeaterItemEventArgs e)
    //{
    //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
    //    {
    //        // Access the data item bound to the Repeater item
    //        DataRowView drv = e.Item.DataItem as DataRowView;

    //        if (drv != null)
    //        {
    //            // Access controls within the Repeater ItemTemplate
    //            Label lblSubtotal = (Label)e.Item.FindControl("lblSubtotal");
    //            Label lblTotal = (Label)e.Item.FindControl("lblTotal");

    //            // Populate the controls with data
    //            lblSubtotal.Text = "₹" + drv["Subtotal"].ToString();
    //            lblTotal.Text = "₹" + drv["Total"].ToString();
    //        }
    //    }
    //}


    //private void BindCartTotals()
    //{
    //    string connectionString = @"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True";

    //    try
    //    {
    //        using (SqlConnection connection = new SqlConnection(connectionString))
    //        {
    //            string query = "SELECT SUM(Price * Quantity) AS Subtotal FROM ProductsAdd";

    //            using (SqlCommand command = new SqlCommand(query, connection))
    //            {
    //                connection.Open();
    //                SqlDataReader reader = command.ExecuteReader();

    //                if (reader.Read())
    //                {
    //                    decimal subtotal = Convert.ToDecimal(reader["Subtotal"]);
    //                    //lblSubtotal.Text = "₹" + subtotal.ToString("0.00");

    //                    // You need to calculate total based on subtotal, add taxes, shipping charges, etc.
    //                    double total = CalculateTotal(subtotal);
    //                    //lblTotal.Text = "₹" + total.ToString("0.00");
    //                }

    //                reader.Close();
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        // Handle any exceptions here, such as displaying an error message.
    //        // For now, let's just print the exception message to the console.
    //        Console.WriteLine("An error occurred: " + ex.Message);
    //    }
    //}

    //// Method to calculate total based on subtotal
    //private double CalculateTotal(decimal subtotal)
    //{
    //    // Example: adding 10% tax to the subtotal
    //    double taxRate = 0.10;
    //    double total = (double)subtotal * (1 + taxRate);

    //    // You can add more calculations here, such as shipping charges.

    //    return total;
    //}


    //private void BindRepeater1()
    //{
    //    if (Session["cartitem"] != null)
    //    {
    //        DataTable dt = (DataTable)Session["cartitem"];
    //        if (dt.Rows.Count > 0)
    //        {
    //            foreach (DataRow dr in dt.Rows)
    //            {
    //                subTotal += double.Parse(dr["TotalPrice"].ToString());

    //            }

    //            Repeater1.DataSource = dt;
    //            Repeater1.DataBind();
    //        }
    //        else
    //        {

    //        }

    //    }
    //}




    private void BindCartData()
    {
        DataTable cartItems = (DataTable)Session["cartitem"];
        if (cartItems != null && cartItems.Rows.Count > 0)
        {
            Repeater1.DataSource = cartItems;
            Repeater1.DataBind();

            double subtotal = CalculateSubtotal(cartItems);
            lblSubtotal.Text = subtotal.ToString(); // Display subtotal

            double discount = CalculateDiscount(subtotal); // Calculate discount based on subtotal
            lbldiscount.Text = discount.ToString(); // Display discount

            // Calculate total (add shipping, taxes, etc., if applicable)
            double total = subtotal - discount; // Subtract discount from subtotal to get total
            lblTotal.Text = total.ToString(); // Display total
        }
        else
        {
            // Handle empty cart
            // You might want to display a message or redirect to a different page
            lblSubtotal.Text = "0.00"; // Display 0 as subtotal when cart is empty
            lbldiscount.Text = "0.00"; // Display 0 as discount when cart is empty
            lblTotal.Text = "0.00"; // Display 0 as total when cart is empty
        }
    }

    private double CalculateDiscount(double subtotal)
    {
        if (subtotal > 100)
        {
            return subtotal * 0.03; // 3% discount
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



    [WebMethod]
    public static int GetAvailableQuantity(int productId)
    {
        Console.WriteLine(productId + " hiii");
        int availableQuantity = 0;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["dbms"].ConnectionString;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT Quantity FROM ProductsAdd WHERE ID = @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", productId);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    availableQuantity = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {

            }
        }
        return availableQuantity;
    }

    //protected void rptParent_ItemDataBound(object sender, RepeaterItemEventArgs e)
    //{
    //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
    //    {
    //        Label lblSubtotal = (Label)e.Item.FindControl("lblSubtotal");
    //        Label lblTotal = (Label)e.Item.FindControl("lblTotal");

    //        DataRowView drv = (DataRowView)e.Item.DataItem;
    //        decimal price = Convert.ToDecimal(drv["Price"]);
    //        int quantity = Convert.ToInt32(drv["Quantity"]);
    //        decimal subtotal = price * quantity;
    //        decimal total = subtotal; 

    //        lblSubtotal.Text = subtotal.ToString("C"); 
    //        lblTotal.Text = total.ToString("C");
    //    }
    //}



    //protected void rptParent_ItemDataBound(object sender, RepeaterItemEventArgs e)
    //{
    //    if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
    //    {
    //        Label lblSubtotal = (Label)e.Item.FindControl("lblSubtotal");
    //        Label lblTotal = (Label)e.Item.FindControl("lblTotal");

    //        DataRowView drv = (DataRowView)e.Item.DataItem;
    //        decimal price = Convert.ToDecimal(drv["Price"]);
    //        int quantity = Convert.ToInt32(drv["Quantity"]);
    //        decimal subtotal = price * quantity;
    //        decimal total = subtotal;

    //        lblSubtotal.Text = subtotal.ToString("C");
    //        lblTotal.Text = total.ToString("C");
    //    }
    //}

    //private DataTable GetCartItemsFromDatabase()
    //{
    //    DataTable dt = new DataTable();

    //    string connectionString = @"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True"; // Replace with your connection string
    //    using (SqlConnection connection = new SqlConnection(connectionString))
    //    {
    //        string query = "SELECT Subtotal, Price, Quantity FROM cartitem";
    //        using (SqlCommand command = new SqlCommand(query, connection))
    //        {
    //            connection.Open();
    //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
    //            {
    //                adapter.Fill(dt);
    //            }
    //        }
    //    }
    //    return dt;
    //}

    //private DataTable GetCartItemsFromDatabase()
    //{
    //    DataTable dt = new DataTable();

    //    string connectionString = @"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True"; // Replace with your connection string
    //    using (SqlConnection connection = new SqlConnection(connectionString))
    //    {
    //        string query = "SELECT Price, Quantity FROM ProductsAdd"; 
    //        using (SqlCommand command = new SqlCommand(query, connection))
    //        {
    //            connection.Open();
    //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
    //            {
    //                adapter.Fill(dt);
    //            }
    //        }
    //    }
    //    return dt;
    //}

    //decimal total = 0;
    //protected void RptrShoppingCart_ItemDataBound(object sender, RepeaterItemEventArgs e)
    //{
    //    DataRow dr = function.GetDataRow("SELECT Product.DiscountedPrice FROM ShoppingCart AS SC INNER JOIN Product AS P ON SC.ProductID = P.ID WHERE SC.UserID = '" + Session["UserID"] + "'");

    //    DataRowView item = e.Item.DataItem as DataRowView;

    //    if (Convert.ToDecimal(dr["DiscountedPrice"]) > 0) // This means if it is a discounted price
    //    {
    //        total += Convert.ToDecimal(item["DiscountedPrice"]) * Convert.ToDecimal(item["Piece"]);
    //    }
    //    else
    //    {
    //        total += Convert.ToDecimal(item["NormalPrice"]) * Convert.ToDecimal(item["Piece"]);
    //    }
    //    LblShoppingCartTotal.Text = string.Format("{0:C}", total);
    //}
    protected void btnUpdateTotal_Click(object sender, EventArgs e)
    {
        decimal totalPrice = 0;
        foreach (RepeaterItem item in Repeater1.Items)
        {
            Label lblPrice = (Label)item.FindControl("Price");
            TextBox lblQty = (TextBox)item.FindControl("lblQty");

            decimal price = Convert.ToDecimal(lblPrice.Text);
            int quantity = Convert.ToInt32(lblQty.Text);

            totalPrice += price * quantity;
        }

        
        Response.Write("Total price updated successfully.");
    }
}