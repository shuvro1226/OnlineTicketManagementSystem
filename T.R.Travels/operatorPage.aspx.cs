using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class operatorPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string GetConnectionString()
    {
        return System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    }

    protected void Search_Passenger(object sender, EventArgs e)
    {
        string pnr = TextBox1.Text;
        SqlConnection con = new SqlConnection(GetConnectionString());
        string sql = "SELECT PNR,c_name,c_phone,destination,p_time,totalseat,seat_num,amount,p_date FROM passengerinfo WHERE PNR ='"+ pnr +"'";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.ExecuteNonQuery();

        SqlDataAdapter da = new SqlDataAdapter(cmd);

        DataSet ds = new DataSet();

        da.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void rowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.Cells[0].Text = "PNR";
            e.Row.Cells[1].Text = "Customer Name";
            e.Row.Cells[2].Text = "Contact Info";
            e.Row.Cells[3].Text = "Destination";
            e.Row.Cells[4].Text = "Time";
            e.Row.Cells[5].Text = "Seats";
            e.Row.Cells[6].Text = "Seat No.";
            e.Row.Cells[7].Text = "Total Amount";
            e.Row.Cells[8].Text = "Depart Date";
        }
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
        Response.Redirect("OperatorPayment.aspx");
    }

    protected void Index_Changed(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedItem.ToString() == "Dhaka")
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