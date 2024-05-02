using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ecommerce_website_MasterPage : System.Web.UI.MasterPage
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbms"].ConnectionString);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCategories();

            if(Session["cartitem"]!= null)
                {
                    DataTable dt = (DataTable)Session["cartitem"];
                    if (dt.Rows.Count > 0)
                    {
                        lblCartCount.Text = dt.Rows.Count.ToString();
                    }
                    else
                    {
                        lblCartCount.Text = 0.ToString();
                    }
                }
        }

       


    }
    private void MessageBox(string message)
    {
        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('" + message + "');", true);
    }


    private void BindCategories()
    {
        try
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblCategory", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                rptParent.DataSource = dt;
                rptParent.DataBind();
            }
            else
            {
                rptParent.DataSource = null;
                rptParent.DataBind();
            }


        }
        catch (Exception ex)
        {
            ShowMessage("Failed: " + ex.Message);
        }
    }

    protected void rptParent_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
        {
            Label lblCatId = (Label)e.Item.FindControl("lblCatId");
            Repeater rptChild = (Repeater)e.Item.FindControl("rptChild");

            SqlCommand cmd = new SqlCommand("select * from tblSubCategory where MainCatID = '" + lblCatId.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                rptChild.DataSource = dt;
                rptChild.DataBind();
            }
            else
            {
                rptChild.DataSource = null;
                rptChild.DataBind();
            }

        }

    }

    private void BindSubCategories(int categoryId, Repeater rptSubCategories)
    {
        try
        {
            if (con == null)
            {
                ShowMessage("Connection is not initialized.");
                return;
            }

            if (rptSubCategories == null)
            {
                ShowMessage("Repeater control is not initialized.");
                return;
            }

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblSubCategory WHERE MainCatID = @MainCatID", con))
            {
                cmd.Parameters.AddWithValue("@MainCatID", categoryId);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        rptSubCategories.DataSource = dt;
                        rptSubCategories.DataBind();
                    }
                    else
                    {
                        // No need to set DataSource to null
                        rptSubCategories.DataBind();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            ShowMessage("Failed: " + ex.Message);
        }
    }


    protected string GetActiveClass(int ItemIndex)
    {
        if(ItemIndex == 0)
        {
            return "active";

        }
        else
        {
            return "";
        }
    }



    private void ShowMessage(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('" + message + "')", true);
        }
    }
}