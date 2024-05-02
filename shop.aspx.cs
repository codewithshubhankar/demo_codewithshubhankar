using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Ecommerce_website_shop : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCategories();
            getProductDetail();
            //show();
        }
    }
    //public void show()
    //{
    //    try
    //    {
    //        SqlCommand cmd = new SqlCommand("SELECT * FROM Notices", con);
    //        SqlDataAdapter da = new SqlDataAdapter(cmd);
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);
    //        if (dt.Rows.Count > 0)
    //        {
    //            Repeater1.DataSource = dt;
    //            Repeater1.DataBind();
    //        }
    //        else
    //        {
    //            Repeater1.DataSource = null;
    //            Repeater1.DataBind();
    //        }

    //    }
    //    catch (Exception ex)
    //    {
    //        messagebox("failes" + ex.Message);
    //    }


    //}


    //private void messagebox(string sms)
    //{
    //    if (!string.IsNullOrEmpty(sms))
    //    {
    //        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('" + sms + "')", true);
    //    }
    //}

    string Id, Pid;
    private void BindCategories()
    {
        DataTable categoriesTable = GetCategoriesFromDatabase(); // Retrieve categories from the database

        Repeater1.DataSource = categoriesTable;
        Repeater1.DataBind();
    }

    private DataTable GetCategoriesFromDatabase()
    {
        // Connection string to your database
        string connectionString = @"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True";

        // Query to retrieve categories from the database
        string query = "SELECT Image1, SubCatName,Price FROM ProductsAdd";

        // Create a DataTable to hold the categories data
        DataTable categoriesTable = new DataTable();

        // Using block ensures that resources are properly released
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create a SqlCommand object to execute the query
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Open the database connection
                connection.Open();

                // Create a SqlDataAdapter to fill the DataTable with the query result
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Fill the DataTable with the data retrieved from the database
                adapter.Fill(categoriesTable);
            }
        }

        return categoriesTable;
    }

    private void MessageBox(string msg)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "Showalert", "alert('" + msg + "')", true);
    }


    private void BindRepeater1()
    {
        try
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductsAdd WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", Id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Repeater1.DataSource = dt;
                Repeater1.DataBind();
            }
            else
            {
                Repeater1.DataSource = null;
                Repeater1.DataBind();
            }
        }
        catch (Exception ex)
        {
            MessageBox(ex.Message);
        }
        finally
        {
            con.Close();
        }
    }


   

    String SubCatName, price, imgne, desc,TotalPrice;
    int qty;


    private void getProductDetail()
    {
        using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True"))
        {
            SqlCommand command = new SqlCommand("select * from ProductsAdd where SubCatName=@SubCatName", connection);
            command.Parameters.AddWithValue("@SubCatName", Id);

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    // Assign values to the variables
                    Id = dt.Rows[0]["ID"].ToString();
                    imgne = dt.Rows[0]["Image1"].ToString();
                    SubCatName = dt.Rows[0]["SubCatName"].ToString();
                    desc = dt.Rows[0]["Description"].ToString();
                    price = dt.Rows[0]["Price"].ToString();
                    qty = Convert.ToInt32(dt.Rows[0]["Quantity"]); // Assuming Quantity is the column name
                    TotalPrice = (Convert.ToDecimal(price) * qty).ToString(); // Calculate TotalPrice by multiplying Price and Quantity
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
        }
    }




    protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "AddToCart")
        {
            Id = e.CommandArgument.ToString();
            getProductDetail();

            if (Context.Session["cartitem"] == null)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[7] {
                new DataColumn("ID"),
                new DataColumn("Image1"),
                new DataColumn("SubCatName"),
                new DataColumn("Description"),
                new DataColumn("Quantity"),
                new DataColumn("Price"),
                new DataColumn("TotalPrice")


            });
                dt.Rows.Add(Id, imgne, SubCatName, desc, qty, price,TotalPrice);
                Context.Session["cartitem"] = dt;
            }
            else
            {
                DataTable dt = (DataTable)Context.Session["cartitem"];

                bool itemExists = false;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["SubCatName"].ToString() == SubCatName && row["Description"].ToString() == desc && row["Price"].ToString() == price)
                    {
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    DataRow newRow = dt.NewRow();
                    newRow["ID"] = Id;
                    newRow["Image1"] = imgne;
                    newRow["SubCatName"] = SubCatName; // Fixed the column name

                    newRow["Description"] = desc;
                    newRow["Quantity"] = qty;
                    newRow["Price"] = price;
                    newRow["TotalPrice"] = TotalPrice;
                    dt.Rows.Add(newRow);
                    Context.Session["cartitem"] = dt;

                    // Display a success message
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Item added successfully');", true);
                }
                else
                {
                    // Display a message indicating the item already exists in the cart
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Item already exists in the cart');", true);
                }
            }
        }
    }



    protected void Repeater2_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "AddToCart")
        {
            Id = e.CommandArgument.ToString();
            getProductDetail();

            if (Context.Session["cartitem"] == null)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[7] {
                new DataColumn("ID"),
                new DataColumn("Image1"),
                new DataColumn("SubCatName"),
                new DataColumn("Description"),
                new DataColumn("Quantity"),
                new DataColumn("Price"),
                new DataColumn("TotalPrice"),
            });
                dt.Rows.Add(Id, imgne, SubCatName, desc, qty, price,TotalPrice);
                Context.Session["cartitem"] = dt;
            }
            else
            {
                DataTable dt = (DataTable)Context.Session["cartitem"];

                bool itemExists = false;
                foreach (DataRow row in dt.Rows)
                {
                    if (row["SubCatName"].ToString() == SubCatName && row["Description"].ToString() == desc && row["Price"].ToString() == price)
                    {
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    DataRow newRow = dt.NewRow();
                    newRow["ID"] = Id;
                    newRow["Image1"] = imgne;
                    newRow["SubCatName"] = SubCatName; 
                    newRow["Description"] = desc;
                    newRow["Quantity"] = qty;
                    newRow["Price"] = price;
                    newRow["TotalPrice"] = TotalPrice;
                    dt.Rows.Add(newRow);
                    Context.Session["cartitem"] = dt;
                }
            }
        }
    }



}

