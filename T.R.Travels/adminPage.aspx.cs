using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class adminPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.HeaderStyle.Height = 40;
    }

    public string GetConnectionString()
    {
        return System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
    }

    protected void Add_Operator(object sender, EventArgs e)
    {
        DataInsert(name.Text, oid.Text, password.Text);
        ClearControls(Page);
    }

    public void DataInsert(string name, string id, string password)
    {
        SqlConnection con = new SqlConnection(GetConnectionString());
        string sql = "INSERT INTO adminoperator(name,id,password)" + "VALUES(@Name,@ID,@Password)";
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlParameter[] para = new SqlParameter[3];

            para[0] = new SqlParameter("@Name", SqlDbType.VarChar, 100);
            para[0].Value = name;
            cmd.Parameters.Add(para[0]);
            para[1] = new SqlParameter("@ID", SqlDbType.VarChar, 20);
            para[1].Value = id;
            cmd.Parameters.Add(para[1]);
            para[2] = new SqlParameter("@Password", SqlDbType.VarChar, 25);
            para[2].Value = password;
            cmd.Parameters.Add(para[2]);

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();  //Executes a Transact-SQL statement against the connection and returns the number of rows affected
            Label4.Text = "Operator '" + id + "' is added successfully.";
        }

        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Insert Error";
            msg += ex.Message;
            throw new Exception(msg);
        }

        finally
        {
            con.Close();
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

    protected void OnDeleting(object sender, SqlDataSourceCommandEventArgs e)
    {
        if(!CheckBox1.Checked)
        {
            e.Cancel = true;
            Label4.Text = "Command canceled as the CheckBox was not checked";
        }
    }

    protected void OnDeleted(object sender, SqlDataSourceStatusEventArgs e)
    {
        Label4.Text = "Operator is removed prom duty";
    }

    protected void rowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header)
        {
            e.Row.Cells[0].Text = "Delete";
            e.Row.Cells[1].Text = "Operator Name";
            e.Row.Cells[2].Text = "Operator ID";
            e.Row.Cells[3].Text = "Password";
        }
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Cells[0].Height = 30;
            e.Row.Cells[0].Width = 80;
            e.Row.Cells[0].HorizontalAlign = HorizontalAlign.Center;
            e.Row.Cells[1].Width = 120;
            e.Row.Cells[1].HorizontalAlign = HorizontalAlign.Center;
            e.Row.Cells[2].Width = 150;
            e.Row.Cells[2].HorizontalAlign = HorizontalAlign.Center;
            e.Row.Cells[3].Width = 120;
            e.Row.Cells[3].HorizontalAlign = HorizontalAlign.Center;
        }
    }
}