using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Text;

public partial class OperatorPayment : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataReader rea;

    public string GetConnectionString()
    {
        return System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        seattable.Visible = false;
        ibnext.Visible = false;
        cardimage.Visible = false;
        paychkpnl.Visible = false;
        cmpltpanel.Visible = false;
        Label12.Visible = false;
        btnSave.Visible = false;

        string from = (string)Session["From"].ToString();
        string to = (string)Session["To"].ToString();
        string psngr_to = (string)Session["P_dest"].ToString();
        string type = (string)Session["Type"].ToString();
        string op_id = (string)Session["operatorid"].ToString();
        if (from == "Dhaka" && (to == "Chittagong" || to == "Coxs Bazar") && type == "AC")
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT busid,date,departure,tprice FROM buses WHERE leave='Dhaka' and reach='Coxs Bazar' and type='A/C'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else if (to == "Dhaka" && (from == "Chittagong" || from == "Coxs Bazar") && type == "AC")
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT busid,date,departure,tprice FROM buses WHERE reach='Dhaka' and leave='Coxs Bazar' and type='A/C'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else if (from == "Dhaka" && (to == "Chittagong" || to == "Coxs Bazar") && type == "NON AC")
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT busid,date,departure,tprice FROM buses WHERE leave='Dhaka' and Reach='Coxs Bazar' and type='NON-A/C'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else if (to == "Dhaka" && (from == "Chittagong" || from == "Coxs Bazar") && type == "NON AC")
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT busid,date,departure,tprice FROM buses WHERE reach='Dhaka' and leave='Coxs Bazar' and type='NON-A/C'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else if (from == "Dhaka" && (to == "Naogaon" || to == "Bogra" || to == "Rangpur") && type == "AC")
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT busid,date,departure,tprice FROM buses WHERE leave='Dhaka' and Reach='Rangpur' and type='A/C'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else if (to == "Dhaka" && (from == "Naogaon" || from == "Bogra" || from == "Rangpur") && type == "AC")
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT busid,date,departure,tprice FROM buses WHERE reach='Dhaka' and leave='Rangpur' and type='A/C'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else if (from == "Dhaka" && (to == "Naogaon" || to == "Bogra" || to == "Rangpur") && type == "NON AC")
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT busid,date,departure,tprice FROM buses WHERE leave='Dhaka' and Reach='Rangpur' and type='NON-A/C'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        else if (to == "Dhaka" && (from == "Naogaon" || from == "Bogra" || from == "Rangpur") && type == "NON AC")
        {
            SqlConnection con = new SqlConnection(GetConnectionString());
            string sql = "SELECT busid,date,departure,tprice FROM buses WHERE reach='Dhaka' and leave='Rangpur' and type='NON-A/C'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

    }

    protected void Changed(object sender, EventArgs e)
    {
        GridViewRow row = GridView1.SelectedRow;
        string id = row.Cells[1].Text;
        string date = row.Cells[2].Text;
        string time = row.Cells[3].Text;
        string price = row.Cells[4].Text;
        string to = (string)Session["To"].ToString();
        Session["BusID"] = id;
        Session["Date"] = date;
        Session["Time"] = time;
        seattable.Visible = true;
        for (int j = 1; j <= 31; j++)
        {
            string s = "s" + j;

            ImageButton img = (ImageButton)pnl1.FindControl(s.ToString());
            img.ImageUrl = "~/Images/available_seat_img.gif";
        }

        string sql = "Select * from bus_States where ((Bus_no = '" + id + "') and (depart_date = '" + date + "') and (depart_Time ='" + time + "') and (destin_Station='" + to + "'))";
        con = new SqlConnection(GetConnectionString());
        cmd = new SqlCommand(sql, con);
        con.Open();
        cmd.Connection = con;
        cmd.CommandText = sql;
        rea = cmd.ExecuteReader();
        while (rea.Read())
        {
            for (int j = 1; j <= 31; j++)
            {
                string s = "s" + j;
                if (rea[s.ToString()].ToString() == "b")
                {
                    ImageButton img = (ImageButton)pnl1.FindControl(s.ToString());
                    img.ImageUrl = "~/images/booked_seat_img.gif";
                    img.Enabled = false;

                }

            }
        }
    }

    protected void Changing(object sender, EventArgs e)
    {

    }

    protected void rowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.Cells[0].Text = "Select";
            e.Row.Cells[1].Text = "Bus Name";
            e.Row.Cells[2].Text = "Departure Date";
            e.Row.Cells[3].Text = "Departure Time";
            e.Row.Cells[4].Text = "Ticket Price";
        }
    }

    protected void s1click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s1.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s1.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s1", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("A4-", "");

        }
        else if (s1.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s1.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s1.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "A4-";
        }
    }
    protected void s2click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s2.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s2.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s2", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("A3-", "");
        }
        else if (s2.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s2.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s2.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "A3-";

        }
    }
    protected void s6click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s6.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s6.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s6", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("B4-", "");
        }
        else if (s6.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s6.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s6.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "B4-";

        }
    }
    protected void s7click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s7.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s1.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s7", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("C4-", "");

        }
        else if (s7.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s7.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s7.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "C4-";

        }
    }
    protected void s12click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s12.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s12.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s12", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("D4-", "");

        }
        else if (s12.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s12.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s12.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "D4-";

        }
    }
    protected void s13click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s13.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s13.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s13", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("E4-", "");

        }
        else if (s13.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s13.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s13.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "E4-";

        }
    }
    protected void s18click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s18.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s18.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s18", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("F4-", "");

        }
        else if (s18.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s18.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s18.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "F4-";

        }
    }
    protected void s19click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s19.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s19.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s19", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("G4-", "");

        }
        else if (s19.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s19.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s19.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "G4-";

        }
    }
    protected void s24click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s24.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s24.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s24", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("H4-", "");

        }
        else if (s24.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s24.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s24.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "H4-";

        }
    }
    protected void s25click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s25.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s25.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s25", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("I4-", "");

        }
        else if (s25.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s25.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s25.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "I4-";

        }
    }
    protected void s31click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s31.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s31.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s31", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("J4-", "");
        }
        else if (s31.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s31.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s31.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "J4-";

        }
    }
    protected void s3click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s3.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s3.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s3", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("A1-", "");
        }
        else if (s3.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s3.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s3.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "A1-";

        }
    }
    protected void s4click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s4.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s4.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s4", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("B1-", "");
        }
        else if (s4.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s4.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s4.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "B1-";

        }
    }
    protected void s5click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s5.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s5.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s5", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("B3-", "");
        }
        else if (s5.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s5.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s5.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "B3-";

        }
    }
    protected void s8click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s8.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s8.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s8", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("C3-", "");
        }
        else if (s8.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s8.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s8.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "C3-";

        }
    }
    protected void s9click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s9.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s9.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s9", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("C1-", "");
        }
        else if (s9.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s9.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s9.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "C1-";

        }
    }

    protected void s10click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s10.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s10.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s10", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("D1-", "");
        }
        else if (s10.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s10.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s10.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "D1-";

        }
    }
    protected void s11click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s11.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s11.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s11", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("D3-", "");
        }
        else if (s11.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s11.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s11.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "D3-";

        }
    }
    protected void s14click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s14.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s14.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s14", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("E3-", "");
        }
        else if (s14.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s14.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s14.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "E3-";

        }
    }
    protected void s15click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s15.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s15.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s15", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("E1-", "");
        }
        else if (s15.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s15.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s15.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "E1-";

        }
    }
    protected void s16click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s16.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s16.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s16", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("F1-", "");
        }
        else if (s16.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s16.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s16.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "F1-";

        }
    }
    protected void s17click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s17.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s17.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s17", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("F3-", "");
        }
        else if (s17.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s17.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s17.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "F3-";

        }
    }
    protected void s20click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s20.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s20.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s20", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("G3-", "");
        }
        else if (s20.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s20.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s20.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "G3-";

        }
    }
    protected void s21click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s21.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s21.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s21", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("G1-", "");
        }
        else if (s21.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s21.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s21.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "G1-";

        }
    }
    protected void s22click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s22.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s22.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s22", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("H1-", "");
        }
        else if (s22.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s22.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s22.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "H1-";

        }
    }

    protected void s23click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s23.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s23.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s23", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("H3-", "");
        }
        else if (s23.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s23.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s23.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "H3-";

        }
    }
    protected void s26click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s26.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s26.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s26", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("I3-", "");
        }
        else if (s26.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s26.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s26.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "I3-";

        }
    }
    protected void s27click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s27.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s27.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s27", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("I1-", "");
        }
        else if (s27.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s27.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s27.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "I1-";

        }

    }
    protected void s28click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s28.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s28.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s28", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("J1-", "");
        }
        else if (s28.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s28.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s28.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "J1-";

        }
    }
    protected void s29click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s29.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s29.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s29", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("J2-", "");
        }
        else if (s29.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s29.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s29.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "J2-";

        }
    }
    protected void s30click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s30.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s30.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s30", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("J3-", "");
        }
        else if (s30.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s30.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s30.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "J3-";

        }
    }

    protected void s32click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s32.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s32.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s32", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("A2-", "");
        }
        else if (s32.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s32.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s32.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "A2-";

        }

    }
    protected void s33click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s33.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s33.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s33", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("B2-", "");
        }
        else if (s33.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s33.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s33.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "B2-";

        }

    }
    protected void s34click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s34.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s34.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s34", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("C2-", "");
        }
        else if (s34.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s34.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s34.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "C2-";

        }

    }
    protected void s35click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s35.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s35.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s35", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("D2-", "");
        }
        else if (s35.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s35.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s35.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "D2-";

        }

    }
    protected void s36click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s36.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s36.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s36", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("E2-", "");
        }
        else if (s36.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s36.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s36.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "E2-";

        }

    }
    protected void s37click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s37.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s37.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s37", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("F2-", "");
        }
        else if (s37.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s37.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s37.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "F2-";

        }

    }
    protected void s38click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s38.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s38.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s38", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("G2-", "");
        }
        else if (s38.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s38.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s38.ID.ToString();
            cheatSeatNumber.Text = "G2";

        }

    }
    protected void s39click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s39.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s39.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s39", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("H2-", "");
        }
        else if (s39.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s39.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s39.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "H2-";

        }

    }
    protected void s40click(object sender, ImageClickEventArgs e)
    {
        ibnext.Visible = true;
        if (s40.ImageUrl == "~/Images/selected_seat_img.png")
        {
            seattable.Visible = true;
            s40.ImageUrl = "~/Images/available_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.Replace("s40", "");
            cheatSeatNumber.Text = cheatSeatNumber.Text.Replace("I2-", "");
        }
        else if (s40.ImageUrl == "~/Images/available_seat_img.png")
        {
            seattable.Visible = true;
            s40.ImageUrl = "~/Images/selected_seat_img.png";
            txtseatnumber.Text = txtseatnumber.Text.ToString() + "," + s40.ID.ToString();
            cheatSeatNumber.Text = cheatSeatNumber.Text.ToString() + "I2-";

        }

    }


    protected void ibnext_Click(object sender, EventArgs e)
    {
        string Busid = Session["BusID"].ToString();
        string Departure = Session["Time"].ToString();
        string Date = Session["Date"].ToString();

        //Response.Redirect("Statuscheck.aspx");
        string strsql;
        strsql = "Select * from buses where ((departure ='" + Departure + "') and (reach = '" + Session["To"].ToString() + "'))";
        con = new SqlConnection(GetConnectionString());
        cmd = new SqlCommand();

        con.Open();
        cmd.Connection = con;
        cmd.CommandText = strsql;
        rea = cmd.ExecuteReader();
        if (rea.HasRows == true)
        {
            while (rea.Read())
            {
                litrent.Text = rea.GetValue(3).ToString();
                litbusnumber.Text = rea.GetValue(1).ToString();
            }
        }

        rea.Close();
        con.Close();

        string[] str = txtseatnumber.Text.Split('s');
        // string[] str = txtseatnumber.Text.Split('s');
        int len = str.Length - 1;
        littotalseat.Text = len.ToString();
        int z = len * int.Parse(litrent.Text.ToString());
        littotalrent.Text = z.ToString();

        Random rnd = new Random();
        Random rnd1 = new Random();

        litpnr.Text = rnd.Next(50000).ToString() + rnd1.Next(548775).ToString();
        if (len == 0)
        {
            pnl2.Visible = false;
            cardimage.Visible = false;
            Response.Redirect("seatStatus.aspx");

        }
        else
        {
            pnl2.Visible = true;
            cardimage.Visible = true;
            ibnext.Visible = false;

        }

    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        cmpltpanel.Visible = true;
        string Departure = Session["Time"].ToString();
        string Date = Session["Date"].ToString();

        Response.Cookies["destination"].Value = Session["To"].ToString();
        Response.Cookies["pnr"].Value = litpnr.Text.ToString();
        Response.Cookies["name"].Value = txtname.Text.ToString();
        Response.Cookies["ph"].Value = txtphone.Text.ToString();
        Response.Cookies["jodate"].Value = Date;
        Response.Cookies["jotime"].Value = Departure;
        Response.Cookies["seatnum"].Value = txtseatnumber.Text.ToString();
        Response.Cookies["totalseat"].Value = littotalseat.Text.ToString();
        Response.Cookies["rent"].Value = littotalrent.Text.ToString();
        Response.Cookies["busnumber"].Value = litbusnumber.Text.ToString();
        //Response.Redirect("Default.aspx");

    }



    public void DataInsert(string PNR, string c_name, string c_phone, string destination, string c_from, string p_time, string totalseat, string seat_num, string amount, string p_date)
    {
        SqlConnection con = new SqlConnection(GetConnectionString());
        string sql = "INSERT INTO passengerinfo(PNR,c_name,c_phone,destination,c_from,p_time,totalseat,seat_num,amount,p_date)" + "VALUES(@PNR,@C_name,@C_phone,@Destination,@C_from,@P_time,@Totalseat,@Seat_num,@Amount,@P_date)";
        try
        {

            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter[] para = new SqlParameter[13];

            para[0] = new SqlParameter("@PNR", SqlDbType.VarChar, 15);
            para[0].Value = PNR;
            cmd.Parameters.Add(para[0]);
            para[1] = new SqlParameter("@C_name", SqlDbType.VarChar, 50);
            para[1].Value = c_name;
            cmd.Parameters.Add(para[1]);
            para[2] = new SqlParameter("@C_phone", SqlDbType.VarChar, 50);
            para[2].Value = c_phone;
            cmd.Parameters.Add(para[2]);
            para[3] = new SqlParameter("@Destination", SqlDbType.VarChar, 50);
            para[3].Value = destination;
            cmd.Parameters.Add(para[3]);
            para[4] = new SqlParameter("@C_from", SqlDbType.VarChar, 50);
            para[4].Value = c_from;
            cmd.Parameters.Add(para[4]);
            para[5] = new SqlParameter("@P_time", SqlDbType.VarChar, 20);
            para[5].Value = p_time;
            cmd.Parameters.Add(para[5]);
            para[6] = new SqlParameter("@Totalseat", SqlDbType.VarChar, 20);
            para[6].Value = totalseat;
            cmd.Parameters.Add(para[6]);
            para[7] = new SqlParameter("@Seat_num", SqlDbType.VarChar, 50);
            para[7].Value = seat_num;
            cmd.Parameters.Add(para[7]);
            para[8] = new SqlParameter("@Amount", SqlDbType.VarChar, 50);
            para[8].Value = amount;
            cmd.Parameters.Add(para[8]);
            para[9] = new SqlParameter("@P_date", SqlDbType.VarChar, 50);
            para[9].Value = p_date;
            cmd.Parameters.Add(para[9]);



            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();

        }

        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Insert Error";
            msg += ex.Message;
            throw new Exception(msg);
        }

        finally
        {
            // con.Close();
        }
    }

    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        if (OpRadioBtn.Checked == true && txtname.Text.Trim().Length != 0 && txtphone.Text.Trim().Length != 0)
        {
            paychkpnl.Visible = true;
            cardimage.Visible = false;
            lblError.Text = " ";
        }

    }
    protected void checkButton_Click(object sender, EventArgs e)
    {
        if (OpRadioBtn.Checked == true)
        {
            paychkpnl.Visible = false;
            Label12.Visible = true;
            btnSave.Visible = true;
            string Busid = Session["BusID"].ToString();
            string Departure = Session["Time"].ToString();
            string Date = Session["Date"].ToString();
            string ope_id = Session["operatorid"].ToString();
            string[] forsave = txtseatnumber.Text.Split(',');
            DataInsert(litpnr.Text.ToString(), txtname.Text.ToString(), txtphone.Text.ToString(), Session["P_dest"].ToString(), Session["From"].ToString(), Session["Time"].ToString(), littotalseat.Text.ToString(), txtseatnumber.Text.ToString(), littotalrent.Text.ToString(), Session["Date"].ToString());

            SqlCommand cmd;
            SqlConnection con;

            string sqladd1 = "INSERT into operatorpay (id,PNR,Amount) values('" + ope_id + "','" + litpnr.Text.ToString()
                 + "','" + littotalrent.Text.ToString() + "')";

            con = new SqlConnection(GetConnectionString());
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqladd1;
            cmd.ExecuteNonQuery();





            SqlCommand cmd6;
            SqlConnection con6;

            string strsql = "select * from Bus_States where((depart_date='" + Date
                             + "') and (depart_time= '" + Departure
                             + "') and (destin_station= '" + Session["To"].ToString()
                             + "'))";

            con6 = new SqlConnection(GetConnectionString());
            cmd6 = new SqlCommand();
            con6.Open();
            cmd6.Connection = con6;
            cmd6.CommandText = strsql;
            rea = cmd6.ExecuteReader();

            if (rea.Read())
            {
                for (int j = 1; j <= forsave.Length - 1; j++)
                {

                    string strsql1 = "Update bus_States set " + forsave[j].ToString() + " = 'b'  where ((depart_Date='" + Date + "') and(depart_Time='" + Departure + "')and (destin_Station= '" + Session["To"].ToString() + "'))";
                    SqlCommand cmd1 = new SqlCommand();
                    SqlConnection con1 = new SqlConnection(GetConnectionString());
                    con1.Open();
                    cmd1.Connection = con1;
                    cmd1.CommandText = strsql1;
                    cmd1.ExecuteNonQuery();

                }

            }

            else
            {
                string sqladd = "INSERT into bus_States (Bus_no,depart_Date,depart_Time,destin_Station) values('" + Busid + "','" + Date
                 + "','" + Departure
                 + "','" + Session["To"].ToString() + "')";
                con.Close();
                con = new SqlConnection(GetConnectionString());
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = sqladd;
                cmd.ExecuteNonQuery();
                for (int j = 1; j <= forsave.Length - 1; j++)
                {

                    string strsql1 = "Update bus_States set " + forsave[j].ToString() + " = 'b'  where ((depart_Date='" + Date + "') and(depart_Time='" + Departure + "')and (destin_Station= '" + Session["To"].ToString() + "'))";
                    SqlCommand cmd1 = new SqlCommand();
                    SqlConnection con1 = new SqlConnection(GetConnectionString());
                    con1.Open();
                    cmd1.Connection = con1;
                    cmd1.CommandText = strsql1;
                    cmd1.ExecuteNonQuery();

                }

            }

            busnolitrel.Text = litbusnumber.Text.ToString();
            Literal1.Text = litpnr.Text.ToString();
            Literal2.Text = txtname.Text.ToString();
            Literal3.Text = txtphone.Text.ToString();
            Literal4.Text = Session["Date"].ToString();
            Literal5.Text = Session["From"].ToString();
            Literal6.Text = Session["P_dest"].ToString();
            Literal7.Text = txtseatnumber.Text.ToString();
            Literal8.Text = Session["Time"].ToString();
            finalamount.Text = littotalrent.Text.ToString();


        }



    }



    public static void ClearControls(Control Parent)
    {
        if (Parent is TextBox)
        {
            (Parent as TextBox).Text = string.Empty;
        }
        else
        {
            foreach (Control c in Parent.Controls)
                ClearControls(c);
        }
    }
    protected void export_Button_Click(object sender, EventArgs e)
    {
        string filename = "Pdf" + DateTime.Now.Ticks + ".pdf";
        Response.Clear();
        GeneratePdf("", filename, true, "");
        Response.ContentType = "application/pdf";
        Response.AddHeader("content-disposition", "attachment; filename=" + filename);
        Response.Flush();
        Response.End();
    }

    public void GeneratePdf(string path, string filename, bool download, string text)
    {
        var document = new Document();
        try
        {
            if (download)
            {
                PdfWriter.GetInstance(document, Response.OutputStream);
            }
            else
            {
                PdfWriter.GetInstance(document, new FileStream(path + filename, FileMode.Create));
            }
            StringBuilder strB = new StringBuilder();
            document.Open();

            if (text.Length.Equals(0))
            {
                using (StringWriter swriter = new StringWriter(strB))
                {
                    using (HtmlTextWriter htWriter = new HtmlTextWriter(swriter))
                    {
                        Table1.RenderControl(htWriter);
                    }
                }
            }
            else
            {
                strB.Append(text);
            }
            using (TextReader tReader = new StringReader(strB.ToString()))
            {
                List<IElement> list = HTMLWorker.ParseToList(tReader, new StyleSheet());
                foreach (IElement elm in list)
                {
                    document.Add(elm);
                }
            }
        }

        catch (Exception e)
        {
            e.ToString();
        }
        finally
        {
            document.Close();
        }
    }
}