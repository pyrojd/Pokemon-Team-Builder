using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public int Validate_Login(String Username, String Password)

    {

        SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW35;Integrated Security=true");

        SqlCommand cmdselect = new SqlCommand("Select dbo.UsersLogin(@Username,@UPassword,@OutRes)", con);

        cmdselect.CommandType = CommandType.Text;

        cmdselect.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = Username;

        cmdselect.Parameters.Add("@UPassword", SqlDbType.VarChar, 50).Value = Password;

        int Results = 0;

        try
        {
            con.Open();

            string res = cmdselect.ExecuteScalar().ToString();
            //(int)cmdselect.Parameters["@OutRes"].Value
            cmdselect.ExecuteNonQuery();
            Results = int.Parse(res);      //CAUSING ERRORS?!?!-----------------------------------------------------

        }
        catch (SqlException ex)
        {

            lblMessage.Text = ex.Message;
        }
        finally
        {
            con.Close();            
        }
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

                lblMessage.Text = "Login is Good, Send the User to another page or enable controls";

            }

            else

            {

                lblMessage.Text = "Invalid Login";

                lblMessage.ForeColor = System.Drawing.Color.Red;

            }

        }

        else

        {

            lblMessage.Text = "Please make sure that the username and the password is Correct";

        }


    }
}