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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = Single.Text;
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35  ;Integrated Security=true");
        dbConnection.Open();
        SqlCommand sqlCommand = new SqlCommand("select * from SavedPokemon where NickName = @name" ,dbConnection);
        sqlCommand.Parameters.Add("@name", SqlDbType.VarChar, 15).Value = s;
        if(s == "Select a Pokémon")
        {
            Label1.Text = ("Please Select a Pokémon.");
        }


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string p = Party.Text;
        SqlConnection dbConnection = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35  ;Integrated Security=true");
        dbConnection.Open();
        SqlCommand sqlCommand = new SqlCommand("select * from SavedPokemon where NickName = @name", dbConnection);
        sqlCommand.Parameters.Add("@name", SqlDbType.VarChar, 15).Value = p;
        if (p == "Select a Team")
        {
            Label1.Text = ("Please Select a Team.");
        }
    }
}