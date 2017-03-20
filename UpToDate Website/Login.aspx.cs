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

    public int Validate_Login(String Username, String Password)
    {
        int Results = 0;

        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");

        SqlCommand cmd = new SqlCommand("Select count(*) from Users where Users_Name = '" + Username + "' and Users_Pass = '" + Password + "';", con);

        con.Open();

        Results = (int)cmd.ExecuteScalar();

        con.Close();

        return Results;
    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {



        int Results = 0;

        if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)

        {

            Results = Validate_Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (Results == 1)

            {
                SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");
                con.Open();
                string ID = new SqlCommand("Select Users_ID from Users where Users_Name = '" + txtUsername.Text + "';", con).ToString();

                con.Close();

                lblMessage.Text = "Login is Good, Send the User to another page or enable controls";
                Session["UserName"] = txtUsername.Text;
                Session["ID"] = ID;
                Response.Redirect("Account.aspx");
            }

            else

            {

                lblMessage.Text = "Invalid Login";

                lblMessage.ForeColor = System.Drawing.Color.AliceBlue;

            }

        }

        else

        {

            lblMessage.Text = "Please make sure that the username and the password is Correct";

        }


    }
}