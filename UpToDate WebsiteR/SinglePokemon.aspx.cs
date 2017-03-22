using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class SinglePokemon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Redirect("Login.aspx");
        }
    }

    protected void SaveButton(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");

        SqlCommand cmd = new SqlCommand("Insert Into SavedPokemon Values(" + "';", con);

        con.Open();

        cmd.ExecuteScalar();

        con.Close();
    }

    protected void DeleteButton(object sender, EventArgs e)
    {

    }
}