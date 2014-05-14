using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class searchBus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        Session["Type"] = RadioButtonList1.SelectedItem.ToString();
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

    }
}