using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Ecommerce_website_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-L5B8JV8\\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindRepeater();
            //Bindrptpro();


        }
        
    }

    private void MessageBox(string msg)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('" + msg + "');", true);
    }



    public void BindRepeater()
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Repeater3", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Repeater3.DataSource = dt;
                Repeater3.DataBind();
            }
            else
            {
                Repeater3.DataSource = null;
                Repeater3.DataBind();
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


    //int Id;
    //private void Bindrptpro()
    //{
    //    try
    //    {
    //        SqlCommand cmd = new SqlCommand("SELECT * FROM ProductsAdd WHERE ID=@ID", con);
    //        cmd.Parameters.AddWithValue("@ID", Id);
    //        SqlDataAdapter da = new SqlDataAdapter(cmd);
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);

    //        if (dt.Rows.Count > 0)
    //        {
    //            Repeater4.DataSource = dt;
    //            Repeater4.DataBind();
    //        }
    //        else
    //        {
    //            Repeater4.DataSource = null;
    //            Repeater4.DataBind();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox(ex.Message);
    //    }
    //    finally
    //    {
    //        con.Close();
    //    }
    //}




}