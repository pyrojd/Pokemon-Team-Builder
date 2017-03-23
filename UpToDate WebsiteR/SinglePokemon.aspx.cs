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

        int HpEv = int.Parse(hpev.Text);
        int AtkEv = int.Parse(atkev.Text);
        int DefEv = int.Parse(defev.Text);
        int SpAtkEv = int.Parse(spatkev.Text);
        int SpDefEv = int.Parse(spdefev.Text);
        int SpdEv = int.Parse(spdev.Text);
        int HpIv = int.Parse(hpiv.Text);
        int AtkIv = int.Parse(atkiv.Text);
        int DefIv = int.Parse(defiv.Text);
        int SpAtkIv = int.Parse(spatkiv.Text);
        int SpDefIv = int.Parse(spdefiv.Text);
        int SpdIv = int.Parse(spdiv.Text);


        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");

        SqlCommand cmd = new SqlCommand("Insert Into SavedPokemon (ID, NickName, Gender, HP_EV, ATK_EV, DEF_EV, SP_ATK_EV, SP_DEF_EV, SPD_EV, HP_IV, ATK_IV, DEF_IV, SP_ATK_IV, SP_DEF_IV, SPD_IV, Nature_ID, Ability_ID, Item_ID, Move_1, Move_2, Move_3, Move_4, In_Party, Users_ID)" + 
            "Values(" + Pokemon.SelectedValue + ",'" + NickName.Text + "' ," + Gender.SelectedValue + ","
            + HpEv + "," + AtkEv + "," + DefEv + "," + SpAtkEv + "," + SpDefEv + "," + SpdEv + "," 
            + HpIv + "," + AtkIv + "," + DefEv + "," + SpAtkIv + "," + SpDefIv + "," + SpdIv + "," 
            + Nature.SelectedValue + "," + Ability.SelectedValue + "," + Item.SelectedValue + "," + Attack1.SelectedValue + "," + Attack2.SelectedValue +
            "," + Attack3.SelectedValue + "," + Attack4.SelectedValue + ",'" + false + "'," + Session["ID"] + ");", con);

        con.Open();
        
        

        cmd.ExecuteNonQuery();

        con.Close();

        Response.Redirect("Account.aspx");
    }

    protected void DeleteButton(object sender, EventArgs e)
    {

    }
}

/*SqlCommand cmd = new SqlCommand("Insert Into SavedPokemon Values(" + Pokemon + "," + NickName + "," + Gender + "," + Request.Form["hpev"] +
             "," + Request.Form["atkev"] + "," + Request.Form["defev"] + "," + Request.Form["spatkev"] + "," + Request.Form["spdefev"] + "," + Request.Form["spdev"] +
             Request.Form["hpiv"] + "," + Request.Form["atkiv"] + "," + Request.Form["defiv"] + "," + Request.Form["spatkiv"] + "," + Request.Form["spdefiv"] + "," +
             Request.Form["spdiv"] + "," + Nature + "," + Ability + "," + Item + "," + Attack1 + "," + Attack2 + "," + Attack3 + "," + Attack4 + "," + "False" + "," +
             "null" + "," + Session["ID"] + ");", con); */