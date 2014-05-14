using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Oracle.DataAccess.Client;

public partial class schedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string oradb = "Data Source=ORCL;User Id=c##shuvro;Password=admin;";
        OracleConnection con = new OracleConnection(oradb);
        OracleCommand cmd;

        string sql = "select * from buses";
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