using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        if (Session["SavedTeam"] == null)
        {

        }
        else if(!IsPostBack)
        {
            TeamPokemon();
        }

    }

    protected void SaveButton(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");

        con.Open();

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

        SqlCommand cmd = new SqlCommand("Insert Into SavedPokemon (ID, NickName, Gender, HP_EV, ATK_EV, DEF_EV, SP_ATK_EV, SP_DEF_EV, SPD_EV, HP_IV, ATK_IV, DEF_IV, SP_ATK_IV, SP_DEF_IV, SPD_IV, Nature_ID, Ability_ID, Item_ID, Move_1, Move_2, Move_3, Move_4, In_Party, Users_ID, Team_Name)" +
           "Values(" + Pokemon1.SelectedValue + ",'" + NickName1.Text + "' ," + Gender1.SelectedValue + ","
           + HpEv1 + "," + AtkEv1 + "," + DefEv1 + "," + SpAtkEv1 + "," + SpDefEv1 + "," + SpdEv1 + ","
           + HpIv1 + "," + AtkIv1 + "," + DefEv1 + "," + SpAtkIv1 + "," + SpDefIv1 + "," + SpdIv1 + ","
           + Nature1.SelectedValue + "," + Ability1.SelectedValue + "," + Item1.SelectedValue + "," + Attack1_1.SelectedValue + "," + Attack2_1.SelectedValue +
           "," + Attack3_1.SelectedValue + "," + Attack4_1.SelectedValue + ",'" + true + "'," + Session["ID"] + ",'" + TeamName.Text + "');", con);

        cmd.ExecuteNonQuery();

        if (NickName2.Text != "")
        { 
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

            SqlCommand cmd2 = new SqlCommand("Insert Into SavedPokemon (ID, NickName, Gender, HP_EV, ATK_EV, DEF_EV, SP_ATK_EV, SP_DEF_EV, SPD_EV, HP_IV, ATK_IV, DEF_IV, SP_ATK_IV, SP_DEF_IV, SPD_IV, Nature_ID, Ability_ID, Item_ID, Move_1, Move_2, Move_3, Move_4, In_Party, Users_ID, Team_Name)" +
                "Values(" + Pokemon2.SelectedValue + ",'" + NickName2.Text + "' ," + Gender2.SelectedValue + ","
                + HpEv2 + "," + AtkEv2 + "," + DefEv2 + "," + SpAtkEv2 + "," + SpDefEv2 + "," + SpdEv2 + ","
                + HpIv2 + "," + AtkIv2 + "," + DefEv2 + "," + SpAtkIv2 + "," + SpDefIv2 + "," + SpdIv2 + ","
                + Nature2.SelectedValue + "," + Ability2.SelectedValue + "," + Item2.SelectedValue + "," + Attack1_2.SelectedValue + "," + Attack2_2.SelectedValue +
                "," + Attack3_2.SelectedValue + "," + Attack4_2.SelectedValue + ",'" + true + "'," + Session["ID"] + ",'" + TeamName.Text + "');", con);

            cmd2.ExecuteNonQuery();
        }

        if (NickName3.Text != "")
        {
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

            SqlCommand cmd3 = new SqlCommand("Insert Into SavedPokemon (ID, NickName, Gender, HP_EV, ATK_EV, DEF_EV, SP_ATK_EV, SP_DEF_EV, SPD_EV, HP_IV, ATK_IV, DEF_IV, SP_ATK_IV, SP_DEF_IV, SPD_IV, Nature_ID, Ability_ID, Item_ID, Move_1, Move_2, Move_3, Move_4, In_Party, Users_ID, Team_Name)" +
                "Values(" + Pokemon3.SelectedValue + ",'" + NickName3.Text + "' ," + Gender3.SelectedValue + ","
                + HpEv3 + "," + AtkEv3 + "," + DefEv3 + "," + SpAtkEv3 + "," + SpDefEv3 + "," + SpdEv3 + ","
                + HpIv3 + "," + AtkIv3 + "," + DefEv3 + "," + SpAtkIv3 + "," + SpDefIv3 + "," + SpdIv3 + ","
                + Nature3.SelectedValue + "," + Ability3.SelectedValue + "," + Item3.SelectedValue + "," + Attack1_3.SelectedValue + "," + Attack2_3.SelectedValue +
                "," + Attack3_3.SelectedValue + "," + Attack4_3.SelectedValue + ",'" + true + "'," + Session["ID"] + ",'" + TeamName.Text + "');", con);

            cmd3.ExecuteNonQuery();
        }

        if (NickName4.Text != "")
        {
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

            SqlCommand cmd4 = new SqlCommand("Insert Into SavedPokemon (ID, NickName, Gender, HP_EV, ATK_EV, DEF_EV, SP_ATK_EV, SP_DEF_EV, SPD_EV, HP_IV, ATK_IV, DEF_IV, SP_ATK_IV, SP_DEF_IV, SPD_IV, Nature_ID, Ability_ID, Item_ID, Move_1, Move_2, Move_3, Move_4, In_Party, Users_ID, Team_Name)" +
                "Values(" + Pokemon4.SelectedValue + ",'" + NickName4.Text + "' ," + Gender4.SelectedValue + ","
                + HpEv4 + "," + AtkEv4 + "," + DefEv4 + "," + SpAtkEv4 + "," + SpDefEv4 + "," + SpdEv4 + ","
                + HpIv4 + "," + AtkIv4 + "," + DefEv4 + "," + SpAtkIv4 + "," + SpDefIv4 + "," + SpdIv4 + ","
                + Nature4.SelectedValue + "," + Ability4.SelectedValue + "," + Item4.SelectedValue + "," + Attack1_4.SelectedValue + "," + Attack2_4.SelectedValue +
                "," + Attack3_4.SelectedValue + "," + Attack4_4.SelectedValue + ",'" + true + "'," + Session["ID"] + ",'" + TeamName.Text + "');", con);

            cmd4.ExecuteNonQuery();
        }
        if (NickName5.Text != "")
        {
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

            SqlCommand cmd5 = new SqlCommand("Insert Into SavedPokemon (ID, NickName, Gender, HP_EV, ATK_EV, DEF_EV, SP_ATK_EV, SP_DEF_EV, SPD_EV, HP_IV, ATK_IV, DEF_IV, SP_ATK_IV, SP_DEF_IV, SPD_IV, Nature_ID, Ability_ID, Item_ID, Move_1, Move_2, Move_3, Move_4, In_Party, Users_ID, Team_Name)" +
                "Values(" + Pokemon5.SelectedValue + ",'" + NickName5.Text + "' ," + Gender5.SelectedValue + ","
                + HpEv5 + "," + AtkEv5 + "," + DefEv5 + "," + SpAtkEv5 + "," + SpDefEv5 + "," + SpdEv5 + ","
                + HpIv5 + "," + AtkIv5 + "," + DefEv5 + "," + SpAtkIv5 + "," + SpDefIv5 + "," + SpdIv5 + ","
                + Nature5.SelectedValue + "," + Ability5.SelectedValue + "," + Item5.SelectedValue + "," + Attack1_5.SelectedValue + "," + Attack2_5.SelectedValue +
                "," + Attack3_3.SelectedValue + "," + Attack4_3.SelectedValue + ",'" + true + "'," + Session["ID"] + ",'" + TeamName.Text + "');", con);

            cmd5.ExecuteNonQuery();
        }
        if (NickName6.Text != "")
        {
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

            SqlCommand cmd6 = new SqlCommand("Insert Into SavedPokemon (ID, NickName, Gender, HP_EV, ATK_EV, DEF_EV, SP_ATK_EV, SP_DEF_EV, SPD_EV, HP_IV, ATK_IV, DEF_IV, SP_ATK_IV, SP_DEF_IV, SPD_IV, Nature_ID, Ability_ID, Item_ID, Move_1, Move_2, Move_3, Move_4, In_Party, Users_ID, Team_Name)" +
                "Values(" + Pokemon6.SelectedValue + ",'" + NickName6.Text + "' ," + Gender6.SelectedValue + ","
                + HpEv6 + "," + AtkEv6 + "," + DefEv6 + "," + SpAtkEv6 + "," + SpDefEv6 + "," + SpdEv6 + ","
                + HpIv6 + "," + AtkIv6 + "," + DefEv6 + "," + SpAtkIv6 + "," + SpDefIv6 + "," + SpdIv6 + ","
                + Nature6.SelectedValue + "," + Ability6.SelectedValue + "," + Item6.SelectedValue + "," + Attack1_6.SelectedValue + "," + Attack2_6.SelectedValue +
                "," + Attack3_6.SelectedValue + "," + Attack4_6.SelectedValue + ",'" + true + "'," + Session["ID"] + ",'" + TeamName.Text + "');", con);

            cmd6.ExecuteNonQuery();
        }        

        con.Close();

        Response.Redirect("Account.aspx");
    }

    protected void DeleteButton(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");

        con.Open();

        SqlCommand delete = new SqlCommand("Delete from dbo.SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "';", con);

        delete.ExecuteNonQuery();

        con.Close();
        Response.Redirect("Account.aspx");

    }

    protected void TeamPokemon()
    {
        Session["Pokemon1"] = null;
        Session["Pokemon2"] = null;
        Session["Pokemon3"] = null;
        Session["Pokemon4"] = null;
        Session["Pokemon5"] = null;
        Session["Pokemon6"] = null;


        //poke1
        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");
        con.Open();

        SqlCommand session1 = new SqlCommand("Select PDB_ID from SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        string poke1 = session1.ExecuteScalar().ToString();
        Session["Pokemon1"] = poke1;

        SqlCommand cmd1 = new SqlCommand("Select NickName From SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        NickName1.Text = cmd1.ExecuteScalar().ToString();

        SqlCommand cmd2 = new SqlCommand("Select ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        Pokemon1.SelectedValue = cmd2.ExecuteScalar().ToString();

        SqlCommand cmd3 = new SqlCommand("Select Gender From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        Gender1.SelectedValue = cmd3.ExecuteScalar().ToString();

        SqlCommand cmd4 = new SqlCommand("Select HP_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        hpev1.Text = cmd4.ExecuteScalar().ToString();

        SqlCommand cmd5 = new SqlCommand("Select HP_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        hpiv1.Text = cmd5.ExecuteScalar().ToString();

        SqlCommand cmd6 = new SqlCommand("Select ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        atkev1.Text = cmd6.ExecuteScalar().ToString();

        SqlCommand cmd7 = new SqlCommand("Select ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        atkiv1.Text = cmd7.ExecuteScalar().ToString();

        SqlCommand cmd8 = new SqlCommand("Select DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        defev1.Text = cmd8.ExecuteScalar().ToString();

        SqlCommand cmd9 = new SqlCommand("Select DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        defiv1.Text = cmd9.ExecuteScalar().ToString();

        SqlCommand cmd10 = new SqlCommand("Select SP_ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        spatkev1.Text = cmd10.ExecuteScalar().ToString();

        SqlCommand cmd11 = new SqlCommand("Select SP_ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        spatkiv1.Text = cmd11.ExecuteScalar().ToString();

        SqlCommand cmd12 = new SqlCommand("Select SP_DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        spdefev1.Text = cmd12.ExecuteScalar().ToString();

        SqlCommand cmd13 = new SqlCommand("Select SP_DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        spdefiv1.Text = cmd13.ExecuteScalar().ToString();

        SqlCommand cmd14 = new SqlCommand("Select SPD_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        spdev1.Text = cmd14.ExecuteScalar().ToString();

        SqlCommand cmd15 = new SqlCommand("Select SPD_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        spdiv1.Text = cmd15.ExecuteScalar().ToString();

        SqlCommand cmd16 = new SqlCommand("Select Nature_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        Nature1.SelectedValue = cmd16.ExecuteScalar().ToString();

        SqlCommand cmd17 = new SqlCommand("Select Ability_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        Ability1.SelectedValue = cmd17.ExecuteScalar().ToString();

        SqlCommand cmd18 = new SqlCommand("Select Item_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        Item1.SelectedValue = cmd18.ExecuteScalar().ToString();

        SqlCommand cmd19 = new SqlCommand("Select Move_1 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        Attack1_1.SelectedValue = cmd19.ExecuteScalar().ToString();

        SqlCommand cmd20 = new SqlCommand("Select Move_2 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        Attack2_1.SelectedValue = cmd20.ExecuteScalar().ToString();

        SqlCommand cmd21 = new SqlCommand("Select Move_3 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        Attack3_1.SelectedValue = cmd21.ExecuteScalar().ToString();

        SqlCommand cmd22 = new SqlCommand("Select Move_4 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' ;", con);
        Attack4_1.SelectedValue = cmd22.ExecuteScalar().ToString();


        //poke2
        SqlCommand session2 = new SqlCommand("Select PDB_ID from SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID > " + Session["Pokemon1"] + " ;", con);
        string poke2 = session2.ExecuteScalar().ToString();
        Session["Pokemon2"] = poke2;
        if (Session["Pokemon2"] != null || (String)Session["Pokemon2"] != "") {
            SqlCommand cmd23 = new SqlCommand("Select NickName From SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            NickName2.Text = cmd23.ExecuteScalar().ToString();

            SqlCommand cmd24 = new SqlCommand("Select ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            Pokemon2.SelectedValue = cmd24.ExecuteScalar().ToString();

            SqlCommand cmd25 = new SqlCommand("Select Gender From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            Gender2.SelectedValue = cmd25.ExecuteScalar().ToString();

            SqlCommand cmd26 = new SqlCommand("Select HP_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            hpev2.Text = cmd26.ExecuteScalar().ToString();

            SqlCommand cmd27 = new SqlCommand("Select HP_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            hpiv2.Text = cmd27.ExecuteScalar().ToString();

            SqlCommand cmd28 = new SqlCommand("Select ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            atkev2.Text = cmd28.ExecuteScalar().ToString();

            SqlCommand cmd29 = new SqlCommand("Select ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            atkiv2.Text = cmd29.ExecuteScalar().ToString();

            SqlCommand cmd30 = new SqlCommand("Select DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            defev2.Text = cmd30.ExecuteScalar().ToString();

            SqlCommand cmd31 = new SqlCommand("Select DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            defiv2.Text = cmd31.ExecuteScalar().ToString();

            SqlCommand cmd32 = new SqlCommand("Select SP_ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            spatkev2.Text = cmd32.ExecuteScalar().ToString();

            SqlCommand cmd33 = new SqlCommand("Select SP_ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            spatkiv2.Text = cmd33.ExecuteScalar().ToString();

            SqlCommand cmd34 = new SqlCommand("Select SP_DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            spdefev2.Text = cmd34.ExecuteScalar().ToString();

            SqlCommand cmd35 = new SqlCommand("Select SP_DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            spdefiv2.Text = cmd35.ExecuteScalar().ToString();

            SqlCommand cmd36 = new SqlCommand("Select SPD_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            spdev2.Text = cmd36.ExecuteScalar().ToString();

            SqlCommand cmd37 = new SqlCommand("Select SPD_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            spdiv2.Text = cmd37.ExecuteScalar().ToString();

            SqlCommand cmd38 = new SqlCommand("Select Nature_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            Nature2.SelectedValue = cmd38.ExecuteScalar().ToString();

            SqlCommand cmd39 = new SqlCommand("Select Ability_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            Ability2.SelectedValue = cmd39.ExecuteScalar().ToString();

            SqlCommand cmd40 = new SqlCommand("Select Item_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            Item2.SelectedValue = cmd40.ExecuteScalar().ToString();

            SqlCommand cmd41 = new SqlCommand("Select Move_1 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            Attack1_2.SelectedValue = cmd41.ExecuteScalar().ToString();

            SqlCommand cmd42 = new SqlCommand("Select Move_2 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            Attack2_2.SelectedValue = cmd42.ExecuteScalar().ToString();

            SqlCommand cmd43 = new SqlCommand("Select Move_3 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            Attack3_2.SelectedValue = cmd43.ExecuteScalar().ToString();

            SqlCommand cmd44 = new SqlCommand("Select Move_4 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " ;", con);
            Attack4_2.SelectedValue = cmd44.ExecuteScalar().ToString();
        }

        //poke3
        SqlCommand session3 = new SqlCommand("Select PDB_ID from SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID > " + Session["Pokemon2"] + " ; ", con);
        string poke3 = session3.ExecuteScalar().ToString();
        Session["Pokemon3"] = poke3;

        if (Session["Pokemon3"] != null || (string)Session["Pokemon3"] != "") {
            SqlCommand cmd45 = new SqlCommand("Select NickName From SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            NickName3.Text = cmd45.ExecuteScalar().ToString();

            SqlCommand cmd46 = new SqlCommand("Select ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            Pokemon3.SelectedValue = cmd46.ExecuteScalar().ToString();

            SqlCommand cmd47 = new SqlCommand("Select Gender From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            Gender3.SelectedValue = cmd47.ExecuteScalar().ToString();

            SqlCommand cmd48 = new SqlCommand("Select HP_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            hpev3.Text = cmd48.ExecuteScalar().ToString();

            SqlCommand cmd49 = new SqlCommand("Select HP_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            hpiv3.Text = cmd49.ExecuteScalar().ToString();

            SqlCommand cmd50 = new SqlCommand("Select ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            atkev3.Text = cmd50.ExecuteScalar().ToString();

            SqlCommand cmd51 = new SqlCommand("Select ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            atkiv3.Text = cmd51.ExecuteScalar().ToString();

            SqlCommand cmd52 = new SqlCommand("Select DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            defev3.Text = cmd52.ExecuteScalar().ToString();

            SqlCommand cmd53 = new SqlCommand("Select DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            defiv3.Text = cmd53.ExecuteScalar().ToString();

            SqlCommand cmd54 = new SqlCommand("Select SP_ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            spatkev3.Text = cmd54.ExecuteScalar().ToString();

            SqlCommand cmd55 = new SqlCommand("Select SP_ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            spatkiv3.Text = cmd55.ExecuteScalar().ToString();

            SqlCommand cmd56 = new SqlCommand("Select SP_DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            spdefev3.Text = cmd56.ExecuteScalar().ToString();

            SqlCommand cmd57 = new SqlCommand("Select SP_DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            spdefiv3.Text = cmd57.ExecuteScalar().ToString();

            SqlCommand cmd58 = new SqlCommand("Select SPD_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            spdev3.Text = cmd58.ExecuteScalar().ToString();

            SqlCommand cmd59 = new SqlCommand("Select SPD_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            spdiv3.Text = cmd59.ExecuteScalar().ToString();

            SqlCommand cmd60 = new SqlCommand("Select Nature_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            Nature3.SelectedValue = cmd60.ExecuteScalar().ToString();

            SqlCommand cmd61 = new SqlCommand("Select Ability_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            Ability3.SelectedValue = cmd61.ExecuteScalar().ToString();

            SqlCommand cmd62 = new SqlCommand("Select Item_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            Item3.SelectedValue = cmd62.ExecuteScalar().ToString();

            SqlCommand cmd63 = new SqlCommand("Select Move_1 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            Attack1_3.SelectedValue = cmd63.ExecuteScalar().ToString();

            SqlCommand cmd64 = new SqlCommand("Select Move_2 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            Attack2_3.SelectedValue = cmd64.ExecuteScalar().ToString();

            SqlCommand cmd65 = new SqlCommand("Select Move_3 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            Attack3_3.SelectedValue = cmd65.ExecuteScalar().ToString();

            SqlCommand cmd66 = new SqlCommand("Select Move_4 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + ";", con);
            Attack4_3.SelectedValue = cmd66.ExecuteScalar().ToString();
        }
        //poke4
        SqlCommand session4 = new SqlCommand("Select PDB_ID from SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID > " + Session["Pokemon3"] + " ;", con);
        string poke4 = session4.ExecuteScalar().ToString();
        Session["Pokemon4"] = poke4;

        if (Session["Pokemon4"] != null || (string)Session["Pokemon4"] != "") {
            SqlCommand cmd67 = new SqlCommand("Select NickName From SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            NickName4.Text = cmd67.ExecuteScalar().ToString();

            SqlCommand cmd68 = new SqlCommand("Select ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            Pokemon4.SelectedValue = cmd68.ExecuteScalar().ToString();

            SqlCommand cmd69 = new SqlCommand("Select Gender From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            Gender4.SelectedValue = cmd69.ExecuteScalar().ToString();

            SqlCommand cmd70 = new SqlCommand("Select HP_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            hpev4.Text = cmd70.ExecuteScalar().ToString();

            SqlCommand cmd71 = new SqlCommand("Select HP_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            hpiv4.Text = cmd71.ExecuteScalar().ToString();

            SqlCommand cmd72 = new SqlCommand("Select ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            atkev4.Text = cmd72.ExecuteScalar().ToString();

            SqlCommand cmd73 = new SqlCommand("Select ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            atkiv4.Text = cmd73.ExecuteScalar().ToString();

            SqlCommand cmd74 = new SqlCommand("Select DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            defev4.Text = cmd74.ExecuteScalar().ToString();

            SqlCommand cmd75 = new SqlCommand("Select DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            defiv4.Text = cmd75.ExecuteScalar().ToString();

            SqlCommand cmd76 = new SqlCommand("Select SP_ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            spatkev4.Text = cmd76.ExecuteScalar().ToString();

            SqlCommand cmd77 = new SqlCommand("Select SP_ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            spatkiv4.Text = cmd77.ExecuteScalar().ToString();

            SqlCommand cmd78 = new SqlCommand("Select SP_DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            spdefev4.Text = cmd78.ExecuteScalar().ToString();

            SqlCommand cmd79 = new SqlCommand("Select SP_DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            spdefiv4.Text = cmd79.ExecuteScalar().ToString();

            SqlCommand cmd80 = new SqlCommand("Select SPD_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            spdev4.Text = cmd80.ExecuteScalar().ToString();

            SqlCommand cmd81 = new SqlCommand("Select SPD_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            spdiv4.Text = cmd81.ExecuteScalar().ToString();

            SqlCommand cmd82 = new SqlCommand("Select Nature_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            Nature4.SelectedValue = cmd82.ExecuteScalar().ToString();

            SqlCommand cmd83 = new SqlCommand("Select Ability_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            Ability4.SelectedValue = cmd83.ExecuteScalar().ToString();

            SqlCommand cmd84 = new SqlCommand("Select Item_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            Item4.SelectedValue = cmd84.ExecuteScalar().ToString();

            SqlCommand cmd85 = new SqlCommand("Select Move_1 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            Attack1_4.SelectedValue = cmd85.ExecuteScalar().ToString();

            SqlCommand cmd86 = new SqlCommand("Select Move_2 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            Attack2_4.SelectedValue = cmd86.ExecuteScalar().ToString();

            SqlCommand cmd87 = new SqlCommand("Select Move_3 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            Attack3_4.SelectedValue = cmd87.ExecuteScalar().ToString();

            SqlCommand cmd88 = new SqlCommand("Select Move_4 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + ";", con);
            Attack4_4.SelectedValue = cmd88.ExecuteScalar().ToString();
        }
        //poke5
        SqlCommand session5 = new SqlCommand("Select PDB_ID from SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID > " + Session["Pokemon4"] + " ;", con);
        string poke5 = session5.ExecuteScalar().ToString();
        Session["Pokemon5"] = poke5;

        if (Session["Pokemon5"] != null || (string)Session["Pokemon5"] != "") {
            SqlCommand cmd89 = new SqlCommand("Select NickName From SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            NickName5.Text = cmd89.ExecuteScalar().ToString();

            SqlCommand cmd90 = new SqlCommand("Select ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            Pokemon5.SelectedValue = cmd90.ExecuteScalar().ToString();

            SqlCommand cmd91 = new SqlCommand("Select Gender From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            Gender5.SelectedValue = cmd91.ExecuteScalar().ToString();

            SqlCommand cmd92 = new SqlCommand("Select HP_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            hpev5.Text = cmd92.ExecuteScalar().ToString();

            SqlCommand cmd93 = new SqlCommand("Select HP_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            hpiv5.Text = cmd93.ExecuteScalar().ToString();

            SqlCommand cmd94 = new SqlCommand("Select ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            atkev5.Text = cmd94.ExecuteScalar().ToString();

            SqlCommand cmd95 = new SqlCommand("Select ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            atkiv5.Text = cmd95.ExecuteScalar().ToString();

            SqlCommand cmd96 = new SqlCommand("Select DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            defev5.Text = cmd96.ExecuteScalar().ToString();

            SqlCommand cmd97 = new SqlCommand("Select DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            defiv5.Text = cmd97.ExecuteScalar().ToString();

            SqlCommand cmd98 = new SqlCommand("Select SP_ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            spatkev5.Text = cmd98.ExecuteScalar().ToString();

            SqlCommand cmd99 = new SqlCommand("Select SP_ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            spatkiv5.Text = cmd99.ExecuteScalar().ToString();

            SqlCommand cmd100 = new SqlCommand("Select SP_DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            spdefev5.Text = cmd100.ExecuteScalar().ToString();

            SqlCommand cmd101 = new SqlCommand("Select SP_DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            spdefiv5.Text = cmd101.ExecuteScalar().ToString();

            SqlCommand cmd102 = new SqlCommand("Select SPD_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            spdev5.Text = cmd102.ExecuteScalar().ToString();

            SqlCommand cmd103 = new SqlCommand("Select SPD_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            spdiv5.Text = cmd103.ExecuteScalar().ToString();

            SqlCommand cmd104 = new SqlCommand("Select Nature_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            Nature5.SelectedValue = cmd104.ExecuteScalar().ToString();

            SqlCommand cmd105 = new SqlCommand("Select Ability_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            Ability5.SelectedValue = cmd105.ExecuteScalar().ToString();

            SqlCommand cmd106 = new SqlCommand("Select Item_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            Item5.SelectedValue = cmd106.ExecuteScalar().ToString();

            SqlCommand cmd107 = new SqlCommand("Select Move_1 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            Attack1_5.SelectedValue = cmd107.ExecuteScalar().ToString();

            SqlCommand cmd108 = new SqlCommand("Select Move_2 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            Attack2_5.SelectedValue = cmd108.ExecuteScalar().ToString();

            SqlCommand cmd109 = new SqlCommand("Select Move_3 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            Attack3_5.SelectedValue = cmd109.ExecuteScalar().ToString();

            SqlCommand cmd110 = new SqlCommand("Select Move_4 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + ";", con);
            Attack4_5.SelectedValue = cmd110.ExecuteScalar().ToString();
        }
        //poke6
        SqlCommand session6 = new SqlCommand("Select PDB_ID from SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID > " + Session["Pokemon5"] + " ;", con);
        string poke6 = session6.ExecuteScalar().ToString();
        Session["Pokemon6"] = poke6;

        if (Session["Pokemon6"] != null || (string)Session["Pokemon6"] != "") {
            SqlCommand cmd111 = new SqlCommand("Select NickName From SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            NickName6.Text = cmd111.ExecuteScalar().ToString();

            SqlCommand cmd112 = new SqlCommand("Select ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            Pokemon6.SelectedValue = cmd112.ExecuteScalar().ToString();

            SqlCommand cmd113 = new SqlCommand("Select Gender From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            Gender6.SelectedValue = cmd113.ExecuteScalar().ToString();

            SqlCommand cmd114 = new SqlCommand("Select HP_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            hpev6.Text = cmd114.ExecuteScalar().ToString();

            SqlCommand cmd115 = new SqlCommand("Select HP_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            hpiv6.Text = cmd115.ExecuteScalar().ToString();

            SqlCommand cmd116 = new SqlCommand("Select ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            atkev6.Text = cmd116.ExecuteScalar().ToString();

            SqlCommand cmd117 = new SqlCommand("Select ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            atkiv6.Text = cmd117.ExecuteScalar().ToString();

            SqlCommand cmd118 = new SqlCommand("Select DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            defev6.Text = cmd118.ExecuteScalar().ToString();

            SqlCommand cmd119 = new SqlCommand("Select DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            defiv6.Text = cmd119.ExecuteScalar().ToString();

            SqlCommand cmd120 = new SqlCommand("Select SP_ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            spatkev6.Text = cmd120.ExecuteScalar().ToString();

            SqlCommand cmd121 = new SqlCommand("Select SP_ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            spatkiv6.Text = cmd121.ExecuteScalar().ToString();

            SqlCommand cmd122 = new SqlCommand("Select SP_DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            spdefev6.Text = cmd122.ExecuteScalar().ToString();

            SqlCommand cmd123 = new SqlCommand("Select SP_DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            spdefiv6.Text = cmd123.ExecuteScalar().ToString();

            SqlCommand cmd124 = new SqlCommand("Select SPD_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            spdev6.Text = cmd124.ExecuteScalar().ToString();

            SqlCommand cmd125 = new SqlCommand("Select SPD_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            spdiv6.Text = cmd125.ExecuteScalar().ToString();

            SqlCommand cmd126 = new SqlCommand("Select Nature_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            Nature6.SelectedValue = cmd126.ExecuteScalar().ToString();

            SqlCommand cmd127 = new SqlCommand("Select Ability_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            Ability6.SelectedValue = cmd127.ExecuteScalar().ToString();

            SqlCommand cmd128 = new SqlCommand("Select Item_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            Item6.SelectedValue = cmd128.ExecuteScalar().ToString();

            SqlCommand cmd129 = new SqlCommand("Select Move_1 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            Attack1_6.SelectedValue = cmd129.ExecuteScalar().ToString();

            SqlCommand cmd130 = new SqlCommand("Select Move_2 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            Attack2_6.SelectedValue = cmd130.ExecuteScalar().ToString();

            SqlCommand cmd131 = new SqlCommand("Select Move_3 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            Attack3_6.SelectedValue = cmd131.ExecuteScalar().ToString();

            SqlCommand cmd132 = new SqlCommand("Select Move_4 From SavedPokemon where Users_ID = " + Session["ID"] + "and Team_Name = '" + Session["SavedTeam"] + "' and PDB_ID != " + Session["Pokemon1"] + " and PDB_ID != " + Session["Pokemon2"] + " and PDB_ID != " + Session["Pokemon3"] + " and PDB_ID != " + Session["Pokemon4"] + " and PDB_ID != " + Session["Pokemon5"] + ";", con);
            Attack4_6.SelectedValue = cmd132.ExecuteScalar().ToString();
        }
        SqlCommand team = new SqlCommand("Select Team_Name From SavedPokemon where Users_ID = " + Session["ID"] + " and Team_Name = '" + Session["SavedTeam"] + "';", con);
        TeamName.Text = team.ExecuteScalar().ToString();
        con.Close();
    }
}