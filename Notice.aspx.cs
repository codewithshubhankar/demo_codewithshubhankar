using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ecommerce_website_Notice : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-L5B8JV8\\MSSQLSERVER02;Initial Catalog=FashionAdda;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            show();
        }

    }

    private void messagebox(string sms)
    {
        if (!string.IsNullOrEmpty(sms))
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('" + sms + "')", true);
        }
    }

    public void show()
    {
        try
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Notices", con);
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
            messagebox("failes" + ex.Message);
        }

    }

}