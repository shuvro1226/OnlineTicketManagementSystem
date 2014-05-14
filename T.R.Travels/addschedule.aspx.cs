using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addschedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        databound();
    }

    protected void Add_Brand(object sender, EventArgs e)
    {
        string oradb = "Data Source=ORCL;User Id=c##shuvro;Password=admin;";
        OracleConnection con = new OracleConnection(oradb);
        OracleCommand cmd;

        string sql = "Insert into brands (name) values ('"+ TextBox1.Text +"')";
        con.Open();
        cmd = new OracleCommand(sql, con);
        cmd.ExecuteNonQuery();
        con.Close();
        databound();
    }

    protected void databound()
    {
        string oradb = "Data Source=ORCL;User Id=c##shuvro;Password=admin;";
        OracleConnection con = new OracleConnection(oradb);
        OracleCommand cmd;

        string sql = "select * from brands";
        cmd = new OracleCommand(sql, con);
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter(cmd);
        con.Open();
        da.Fill(ds);
        con.Close();
        Repeater1.DataSource = ds;
        Repeater1.DataBind();
    }
}