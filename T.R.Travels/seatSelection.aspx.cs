using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class seatSelection : System.Web.UI.Page
{
    public string seatID="";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void s1(object sender, EventArgs e)
    {
        A1.ImageUrl = "~/images/Green.jpg";
        seatID += "A1, ";
    }

    protected void s2(object sender, EventArgs e)
    {
        B1.ImageUrl = "~/images/Green.jpg";
        seatID += "B1, ";
    }


}