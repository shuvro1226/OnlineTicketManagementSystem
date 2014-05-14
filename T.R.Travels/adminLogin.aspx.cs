using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class adminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string GetConnectionString()
    {
        return System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        Session["operatorid"] = username.Text;
        SqlConnection con = new SqlConnection(GetConnectionString());
        string sql = "SELECT * FROM adminoperator WHERE id = @ID and password = @Password";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@ID",username.Text);
        cmd.Parameters.AddWithValue("@Password",password.Text);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            if (username.Text == "shuvro1226" || username.Text == "demolish")
            {
                Response.Redirect("adminPage.aspx");
            }
            else
            {
                Response.Redirect("operatorPage.aspx");
            }
        }
        else
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
        }
    }
}