using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void btnReg_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into Users values('" + txtUsername.Text + "', '" + txtPassword.Text + "', GETDATE(), '03/06/2017', 1, GETDATE(), '" + txtEmail.Text + "');", con);

        cmd.ExecuteNonQuery();

        con.Close();

        Response.Redirect("Login.aspx");

    }
}