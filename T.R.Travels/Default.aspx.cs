using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string oradb = "Data Source=ORCL;User Id=c##shuvro;Password=admin;";
        OracleConnection con = new OracleConnection(oradb);
        OracleCommand cmd;

        string sql = "select * from bustype";
        cmd = new OracleCommand(sql, con);        
        DataSet ds = new DataSet();
        OracleDataAdapter da = new OracleDataAdapter(cmd);
        con.Open();
        da.Fill(ds);
        con.Close();
        DropDownList3.DataSource = ds;
        DropDownList3.DataTextField = "Name";
        DropDownList3.DataValueField = "Id";
        DropDownList3.DataBind();

        string sql2 = "select * from districts";
        cmd = new OracleCommand(sql2, con);
        ds = new DataSet();
        da = new OracleDataAdapter(cmd);
        con.Open();
        da.Fill(ds);
        con.Close();
        DropDownList1.DataSource = ds;
        DropDownList1.DataTextField = "Name";
        DropDownList1.DataValueField = "Id";
        DropDownList1.DataBind();
        DropDownList2.DataSource = ds;
        DropDownList2.DataTextField = "Name";
        DropDownList2.DataValueField = "Id";
        DropDownList2.DataBind();
    }

    public string GetConnectionString()
    {
        return System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    }

    protected void Search_Bus(object sender, EventArgs e)
    {
        Session["From"] = DropDownList1.SelectedItem.ToString();
        string destination = DropDownList2.SelectedItem.ToString();
        Session["P_dest"] = DropDownList2.SelectedItem.ToString();
        Session["Type"] = DropDownList3.SelectedItem.ToString();
        if (destination == "Bogra" || destination == "Naogaon" || destination == "Rangpur")
        {
            destination = "Rangpur";
        }
        else if (destination == "Chittagong" || destination == "Coxs Bazar")
        {
            destination = "Coxs Bazar";
        }
        Session["To"] = destination;
        Response.Redirect("seatStatus.aspx");
    }

    protected void Index_Changed(object sender, EventArgs e)
    {
        if(DropDownList1.SelectedItem.ToString() == "Dhaka")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Bogra");
            DropDownList2.Items.Add("Naogaon");
            DropDownList2.Items.Add("Rangpur");
            DropDownList2.Items.Add("Chittagong");
            DropDownList2.Items.Add("Coxs Bazar");
        }
        else if (DropDownList1.SelectedItem.ToString() == "Bogra")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Dhaka");
        }
        else if (DropDownList1.SelectedItem.ToString() == "Naogaon")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Dhaka");
        }
        else if (DropDownList1.SelectedItem.ToString() == "Rangpur")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Dhaka");
        }
        else if (DropDownList1.SelectedItem.ToString() == "Chittagong")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Dhaka");
        }
        else if (DropDownList1.SelectedItem.ToString() == "Coxs Bazar")
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("Dhaka");
        }
    }
}