using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PartyPokemon : System.Web.UI.Page
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

    }

    protected void DeleteButton(object sender, EventArgs e)
    {

    }
}