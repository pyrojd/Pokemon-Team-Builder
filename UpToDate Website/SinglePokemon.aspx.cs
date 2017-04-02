using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SinglePokemon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        if (Session["SavedPoke"] == null)
        {

        }
        else if(!IsPostBack)
        {
            SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select NickName From SavedPokemon where Users_ID = "+ Session["ID"] + " and PDB_ID = " + Session["SavedPoke"] +" ;",con);
            NickName.Text = cmd.ExecuteScalar().ToString();

            SqlCommand cmd2 = new SqlCommand("Select ID From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            Pokemon.SelectedValue = cmd2.ExecuteScalar().ToString();

            SqlCommand cmd3 = new SqlCommand("Select Gender From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            Gender.SelectedValue = cmd3.ExecuteScalar().ToString();

            SqlCommand cmd4 = new SqlCommand("Select HP_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            hpev.Text = cmd4.ExecuteScalar().ToString();

            SqlCommand cmd5 = new SqlCommand("Select HP_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            hpiv.Text = cmd5.ExecuteScalar().ToString();

            SqlCommand cmd6 = new SqlCommand("Select ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            atkev.Text = cmd6.ExecuteScalar().ToString();

            SqlCommand cmd7 = new SqlCommand("Select ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            atkiv.Text = cmd7.ExecuteScalar().ToString();

            SqlCommand cmd8 = new SqlCommand("Select DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            defev.Text = cmd8.ExecuteScalar().ToString();

            SqlCommand cmd9 = new SqlCommand("Select DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            defiv.Text = cmd9.ExecuteScalar().ToString();

            SqlCommand cmd10 = new SqlCommand("Select SP_ATK_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            spatkev.Text = cmd10.ExecuteScalar().ToString();

            SqlCommand cmd11 = new SqlCommand("Select SP_ATK_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            spatkiv.Text = cmd11.ExecuteScalar().ToString();

            SqlCommand cmd12 = new SqlCommand("Select SP_DEF_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            spdefev.Text = cmd12.ExecuteScalar().ToString();

            SqlCommand cmd13 = new SqlCommand("Select SP_DEF_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            spdefiv.Text = cmd13.ExecuteScalar().ToString();

            SqlCommand cmd14 = new SqlCommand("Select SPD_EV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            spdev.Text = cmd14.ExecuteScalar().ToString();

            SqlCommand cmd15 = new SqlCommand("Select SPD_IV From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            spdiv.Text = cmd15.ExecuteScalar().ToString();

            SqlCommand cmd16 = new SqlCommand("Select Nature_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            Nature.SelectedValue = cmd16.ExecuteScalar().ToString();

            SqlCommand cmd17 = new SqlCommand("Select Ability_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            Ability.SelectedValue = cmd17.ExecuteScalar().ToString();

            SqlCommand cmd18 = new SqlCommand("Select Item_ID From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            Item.SelectedValue = cmd18.ExecuteScalar().ToString();

            SqlCommand cmd19 = new SqlCommand("Select Move_1 From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            Attack1.SelectedValue = cmd19.ExecuteScalar().ToString();

            SqlCommand cmd20 = new SqlCommand("Select Move_2 From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            Attack2.SelectedValue = cmd20.ExecuteScalar().ToString();

            SqlCommand cmd21 = new SqlCommand("Select Move_3 From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            Attack3.SelectedValue = cmd21.ExecuteScalar().ToString();

            SqlCommand cmd22 = new SqlCommand("Select Move_4 From SavedPokemon where Users_ID = " + Session["ID"] + "and PDB_ID = " + Session["SavedPoke"] + " ;", con);
            Attack4.SelectedValue = cmd22.ExecuteScalar().ToString();

            con.Close();
            
        }
    }

    protected void SaveButton(object sender, EventArgs e)
    {

        if (Session["SavedPoke"] == null)
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
        else
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

            con.Open();

            SqlCommand update = new SqlCommand("UPDATE dbo.SavedPokemon set ID = " + Pokemon.SelectedValue + ", NickName = '" + NickName.Text + "', Gender = " + Gender.SelectedValue +
                ", HP_EV = " + HpEv + ", ATK_EV = " + AtkEv + ", DEF_EV = " + DefEv + ", SP_ATK_EV = " + SpAtkEv + ", SP_DEF_EV = " + SpDefEv + ", SPD_EV = " + SpdEv +
                ", HP_IV = " + HpIv + ", ATK_IV = " + AtkIv + ", DEF_IV = " + DefIv + ", SP_ATK_IV = " + SpAtkIv + ", SP_DEF_IV = " + SpDefIv + ", SPD_IV = " + SpdIv +
                ", Nature_ID = "+ Nature.SelectedValue + ", Ability_ID = " + Ability.SelectedValue + ", Item_ID = " + Item.SelectedValue + ", Move_1 = " + Attack1.SelectedValue +
                ", Move_2 = " + Attack2.SelectedValue + ", Move_3 = " + Attack3.SelectedValue + ", Move_4 = " + Attack4.SelectedValue + " Where PDB_ID = " + Session["SavedPoke"] + ";", con);

            update.ExecuteNonQuery();

            con.Close();

            //Response.Redirect("Account.aspx");
        }
    }

    protected void DeleteButton(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");

        con.Open();

        SqlCommand delete = new SqlCommand("Delete from dbo.SavedPokemon where Users_ID = " + Session["ID"] + " and PDB_ID = " + Session["SavedPoke"] + ";",con);

        delete.ExecuteNonQuery();

        con.Close();
        Response.Redirect("Account.aspx");
    }
}


