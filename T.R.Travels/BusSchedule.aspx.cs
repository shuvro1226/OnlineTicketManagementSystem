using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BusSchedule : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.HeaderStyle.Height = 40;
        GridView1.Columns[0].HeaderStyle.Width = 120;
        GridView1.Columns[1].HeaderStyle.Width = 120;
        GridView1.Columns[2].HeaderStyle.Width = 120;
        GridView1.Columns[3].HeaderStyle.Width = 120;
        GridView1.Columns[4].HeaderStyle.Width = 150;
        GridView1.Columns[5].HeaderStyle.Width = 100;
        GridView1.Columns[6].HeaderStyle.Width = 100;
    }

    protected void RowCreate(object sender, GridViewRowEventArgs e)
    {

    }
}