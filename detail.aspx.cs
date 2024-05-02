using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Configuration;



public partial class Ecommerce_website_detail : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-L5B8JV8\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True");

    string Sub;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Sub = Request.QueryString["SubCatName"].ToString();
            BindRep();
            BindMorerpt();
        }
    }

    private void BindRep()
    {
        try
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM ProductsAdd WHERE SubCatName='" + Sub+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Repeater1.DataSource = dt;
            Repeater1.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.Message);
        }
    }
    
    private void BindMorerpt()
    {
        try
        {
            SqlCommand cmd = new SqlCommand("SELECT Top 5 * from ProductsAdd", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            moreRepeater.DataSource = dt;
            moreRepeater.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write("Error: " + ex.Message);
        }
    }
}