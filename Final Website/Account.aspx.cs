using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["UserName"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                UserName.Text = Session["UserName"].ToString();
                Password.Text = Session["password"].ToString();
                SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35  ;Integrated Security=true");
                con.Open();

                SqlCommand cmd = new SqlCommand("Select Users_Email From Users Where Users_ID = " + Session["ID"] + ";", con);

                string email = cmd.ExecuteScalar().ToString();

                con.Close();

                Email.Text = email;

            }
        }
        Session["SavedPoke"] = null;
        Session["SavedTeam"] = null;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = Single.Text;
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35  ;Integrated Security=true");
        dbConnection.Open();
        SqlCommand sqlCommand = new SqlCommand("select * from SavedPokemon where NickName = @name" ,dbConnection);
        sqlCommand.Parameters.Add("@name", SqlDbType.VarChar, 15).Value = s;
        if (s == "")
        {
            Label1.Text = ("Please Select a Pokémon.");
        }
        else
        {
            Session["SavedPoke"] = Single.SelectedValue;
            Response.Redirect("SinglePokemon.aspx");
        }


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string p = Party.SelectedValue;
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35  ;Integrated Security=true");
        dbConnection.Open();
        SqlCommand sqlCommand = new SqlCommand("select * from SavedPokemon where NickName = @name", dbConnection);
        sqlCommand.Parameters.Add("@name", SqlDbType.VarChar, 15).Value = p;
        if (p == "")
        {
            Label1.Text = ("Please Select a Team.");
        }
        else
        {
            Session["SavedTeam"] = Party.SelectedValue;
            Response.Redirect("PartyPokemon.aspx");
        }
    }

    protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }

    protected void LogOut(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Login.aspx");
    }

    protected void UpdateAccount(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35  ;Integrated Security=true");
        con.Open();

        SqlCommand cmd2 = new SqlCommand("UPDATE Users SET Users_Name = '" + UserName.Text + "', Users_Pass = '" + Password.Text + "', Users_Email = '" + Email.Text + "' WHERE Users_ID = " + Session["ID"] + ";", con);

        cmd2.ExecuteNonQuery();

        con.Close();
    }
}