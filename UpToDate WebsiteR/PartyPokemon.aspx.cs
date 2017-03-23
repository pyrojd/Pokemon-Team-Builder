using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

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
        
        int HpEv1 = int.Parse(hpev1.Text);
        int AtkEv1 = int.Parse(atkev1.Text);
        int DefEv1 = int.Parse(defev1.Text);
        int SpAtkEv1 = int.Parse(spatkev1.Text);
        int SpDefEv1 = int.Parse(spdefev1.Text);
        int SpdEv1 = int.Parse(spdev1.Text);
        int HpIv1 = int.Parse(hpiv1.Text);
        int AtkIv1 = int.Parse(atkiv1.Text);
        int DefIv1 = int.Parse(defiv1.Text);
        int SpAtkIv1 = int.Parse(spatkiv1.Text);
        int SpDefIv1 = int.Parse(spdefiv1.Text);
        int SpdIv1 = int.Parse(spdiv1.Text);
        
        int HpEv2 = int.Parse(hpev2.Text);
        int AtkEv2 = int.Parse(atkev2.Text);
        int DefEv2 = int.Parse(defev2.Text);
        int SpAtkEv2 = int.Parse(spatkev2.Text);
        int SpDefEv2 = int.Parse(spdefev2.Text);
        int SpdEv2 = int.Parse(spdev2.Text);
        int HpIv2 = int.Parse(hpiv2.Text);
        int AtkIv2 = int.Parse(atkiv2.Text);
        int DefIv2 = int.Parse(defiv2.Text);
        int SpAtkIv2 = int.Parse(spatkiv2.Text);
        int SpDefIv2 = int.Parse(spdefiv2.Text);
        int SpdIv2 = int.Parse(spdiv2.Text);
        
        int HpEv3 = int.Parse(hpev3.Text);
        int AtkEv3 = int.Parse(atkev3.Text);
        int DefEv3 = int.Parse(defev3.Text);
        int SpAtkEv3 = int.Parse(spatkev3.Text);
        int SpDefEv3 = int.Parse(spdefev3.Text);
        int SpdEv3 = int.Parse(spdev3.Text);
        int HpIv3 = int.Parse(hpiv3.Text);
        int AtkIv3 = int.Parse(atkiv3.Text);
        int DefIv3 = int.Parse(defiv3.Text);
        int SpAtkIv3 = int.Parse(spatkiv3.Text);
        int SpDefIv3 = int.Parse(spdefiv3.Text);
        int SpdIv3 = int.Parse(spdiv3.Text);

        int HpEv4 = int.Parse(hpev4.Text);
        int AtkEv4 = int.Parse(atkev4.Text);
        int DefEv4 = int.Parse(defev4.Text);
        int SpAtkEv4 = int.Parse(spatkev4.Text);
        int SpDefEv4 = int.Parse(spdefev4.Text);
        int SpdEv4 = int.Parse(spdev4.Text);
        int HpIv4 = int.Parse(hpiv4.Text);
        int AtkIv4 = int.Parse(atkiv4.Text);
        int DefIv4 = int.Parse(defiv4.Text);
        int SpAtkIv4 = int.Parse(spatkiv4.Text);
        int SpDefIv4 = int.Parse(spdefiv4.Text);
        int SpdIv4 = int.Parse(spdiv4.Text);

        int HpEv5 = int.Parse(hpev5.Text);
        int AtkEv5 = int.Parse(atkev5.Text);
        int DefEv5 = int.Parse(defev5.Text);
        int SpAtkEv5 = int.Parse(spatkev5.Text);
        int SpDefEv5 = int.Parse(spdefev5.Text);
        int SpdEv5 = int.Parse(spdev5.Text);
        int HpIv5 = int.Parse(hpiv5.Text);
        int AtkIv5 = int.Parse(atkiv5.Text);
        int DefIv5 = int.Parse(defiv5.Text);
        int SpAtkIv5 = int.Parse(spatkiv5.Text);
        int SpDefIv5 = int.Parse(spdefiv5.Text);
        int SpdIv5 = int.Parse(spdiv5.Text);

        int HpEv6 = int.Parse(hpev6.Text);
        int AtkEv6 = int.Parse(atkev6.Text);
        int DefEv6 = int.Parse(defev6.Text);
        int SpAtkEv6 = int.Parse(spatkev6.Text);
        int SpDefEv6 = int.Parse(spdefev6.Text);
        int SpdEv6 = int.Parse(spdev6.Text);
        int HpIv6 = int.Parse(hpiv6.Text);
        int AtkIv6 = int.Parse(atkiv6.Text);
        int DefIv6 = int.Parse(defiv6.Text);
        int SpAtkIv6 = int.Parse(spatkiv6.Text);
        int SpDefIv6 = int.Parse(spdefiv6.Text);
        int SpdIv6 = int.Parse(spdiv6.Text);


        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");

        SqlCommand cmd = new SqlCommand("Insert Into SavedPokemon (ID, NickName, Gender, HP_EV, ATK_EV, DEF_EV, SP_ATK_EV, SP_DEF_EV, SPD_EV, HP_IV, ATK_IV, DEF_IV, SP_ATK_IV, SP_DEF_IV, SPD_IV, Nature_ID, Ability_ID, Item_ID, Move_1, Move_2, Move_3, Move_4, In_Party, Users_ID, Team_Name)" +
           "Values(" + Pokemon1.SelectedValue + ",'" + NickName1.Text + "' ," + Gender1.SelectedValue + ","
           + HpEv1 + "," + AtkEv1 + "," + DefEv1 + "," + SpAtkEv1 + "," + SpDefEv1 + "," + SpdEv1 + ","
           + HpIv1 + "," + AtkIv1 + "," + DefEv1 + "," + SpAtkIv1 + "," + SpDefIv1 + "," + SpdIv1 + ","
           + Nature1.SelectedValue + "," + Ability1.SelectedValue + "," + Item1.SelectedValue + "," + Attack1_1.SelectedValue + "," + Attack2_1.SelectedValue +
           "," + Attack3_1.SelectedValue + "," + Attack4_1.SelectedValue + ",'" + false + "'," + Session["ID"] + ",'" + TeamName.Text + "')," +
           
           "(" + Pokemon2.SelectedValue + ",'" + NickName2.Text + "' ," + Gender2.SelectedValue + ","
           + HpEv2 + "," + AtkEv2 + "," + DefEv2 + "," + SpAtkEv2 + "," + SpDefEv2 + "," + SpdEv2 + ","
           + HpIv2 + "," + AtkIv2 + "," + DefEv2 + "," + SpAtkIv2 + "," + SpDefIv2 + "," + SpdIv2 + ","
           + Nature2.SelectedValue + "," + Ability2.SelectedValue + "," + Item2.SelectedValue + "," + Attack1_2.SelectedValue + "," + Attack2_2.SelectedValue +
           "," + Attack3_2.SelectedValue + "," + Attack4_2.SelectedValue + ",'" + false + "'," + Session["ID"] + ",'" + TeamName.Text + "')," +


           "(" + Pokemon3.SelectedValue + ",'" + NickName3.Text + "' ," + Gender3.SelectedValue + ","
           + HpEv3 + "," + AtkEv3 + "," + DefEv3 + "," + SpAtkEv3 + "," + SpDefEv3+ "," + SpdEv3 + ","
           + HpIv3 + "," + AtkIv3 + "," + DefEv3 + "," + SpAtkIv3 + "," + SpDefIv3+ "," + SpdIv3 + ","
           + Nature3.SelectedValue + "," + Ability3.SelectedValue + "," + Item3.SelectedValue + "," + Attack1_3.SelectedValue + "," + Attack2_3.SelectedValue +
           "," + Attack3_3.SelectedValue + "," + Attack4_3.SelectedValue + ",'" + false + "'," + Session["ID"] + ",'" + TeamName.Text + "')," +

           "(" + Pokemon4.SelectedValue + ",'" + NickName4.Text + "' ," + Gender4.SelectedValue + ","
           + HpEv4 + "," + AtkEv4 + "," + DefEv4 + "," + SpAtkEv4 + "," + SpDefEv4 + "," + SpdEv4 + ","
           + HpIv4 + "," + AtkIv4 + "," + DefEv4 + "," + SpAtkIv4 + "," + SpDefIv4 + "," + SpdIv4 + ","
           + Nature4.SelectedValue + "," + Ability4.SelectedValue + "," + Item4.SelectedValue + "," + Attack1_4.SelectedValue + "," + Attack2_4.SelectedValue +
           "," + Attack3_4.SelectedValue + "," + Attack4_4.SelectedValue + ",'" + false + "'," + Session["ID"] + ",'" + TeamName.Text + "')," +

           "(" + Pokemon5.SelectedValue + ",'" + NickName5.Text + "' ," + Gender5.SelectedValue + ","
           + HpEv5 + "," + AtkEv5 + "," + DefEv5 + "," + SpAtkEv5 + "," + SpDefEv5 + "," + SpdEv5 + ","
           + HpIv5 + "," + AtkIv5 + "," + DefEv5 + "," + SpAtkIv5 + "," + SpDefIv5 + "," + SpdIv5 + ","
           + Nature5.SelectedValue + "," + Ability5.SelectedValue + "," + Item5.SelectedValue + "," + Attack1_5.SelectedValue + "," + Attack2_5.SelectedValue +
           "," + Attack3_3.SelectedValue + "," + Attack4_3.SelectedValue + ",'" + false + "'," + Session["ID"] + ",'" + TeamName.Text + "')," +

           "(" + Pokemon6.SelectedValue + ",'" + NickName6.Text + "' ," + Gender6.SelectedValue + ","
           + HpEv6 + "," + AtkEv6 + "," + DefEv6 + "," + SpAtkEv6 + "," + SpDefEv6 + "," + SpdEv6 + ","
           + HpIv6 + "," + AtkIv6 + "," + DefEv6 + "," + SpAtkIv6 + "," + SpDefIv6 + "," + SpdIv6 + ","
           + Nature6.SelectedValue + "," + Ability6.SelectedValue + "," + Item6.SelectedValue + "," + Attack1_6.SelectedValue + "," + Attack2_6.SelectedValue +
           "," + Attack3_6.SelectedValue + "," + Attack4_6.SelectedValue + ",'" + false + "'," + Session["ID"] + ",'" + TeamName.Text + "');", con);
           
        con.Open();


        cmd.ExecuteNonQuery();

        con.Close();

        Response.Redirect("Account.aspx");
    }

    protected void DeleteButton(object sender, EventArgs e)
    {

    }
}