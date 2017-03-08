using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void RegisterUser(object sender, EventArgs e)
    {
        int userId = 0;
        using (SqlConnection con = new SqlConnection("Data Source=stusql;Initial Catalog=EnterpriseJDW350;Integrated Security=true"))
        {
            using (SqlCommand cmd = new SqlCommand("Insert_User"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                    //cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                    //cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Connection = con;
                    con.Open();
                    userId = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
            }
            string message = string.Empty;
            switch (userId)
            {
                case -1:
                    message = "Username already exists.\\nPlease choose a different username.";
                    break;
                case -2:
                    message = "Supplied email address has already been used.";
                    break;
                default:
                    message = "Registration successful.";
                    break;
            }
            ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);
        }
    }

    public int Validate_Login(String Username, String Password)
    {
        SqlConnection con = new SqlConnection(@"User id=sa;Password=Dotnetfunda;Server=VUYISWA\VUYISWA;Database=Forum");

        SqlCommand cmdselect = new SqlCommand();

        cmdselect.CommandType = CommandType.StoredProcedure;

        cmdselect.CommandText = "[dbo].[prcLoginv]";

        cmdselect.Parameters.Add("@Username", SqlDbType.VarChar, 50).Value = Username;

        cmdselect.Parameters.Add("@UPassword", SqlDbType.VarChar, 50).Value = Password;

        cmdselect.Parameters.Add("@OutRes", SqlDbType.Int, 4);

        cmdselect.Parameters["@OutRes"].Direction = ParameterDirection.Output;

        cmdselect.Connection = con;
        int Results = 0;

        try

        {
            con.Open();

            cmdselect.ExecuteNonQuery();
            Results = (int)cmdselect.Parameters["@OutRes"].Value;

        }
        catch (SqlException ex)

        {

            //lblMessage.Text = ex.Message;
        }
        finally

        {
            cmdselect.Dispose();
            if (con != null)

            {

                con.Close();

            }
        }
        return Results;
    }

    protected void btnlogin_Click(object sender, EventArgs e)

    {



        int Results = 0;
        /*
        if (txtUsername.Text != string.empty && txtPassword.Text != string.empty)

        {

            Results = Validate_Login(txtUsername.Text.trim(), txtPassword.Text.trim());

            if (Results == 1)

            {

                lblMessage.Text = "Login is Good, Send the User to another page or enable controls";

            }

            else

            {

                lblMessage.Text = "Invalid Login";

                lblMessage.ForeColor = System.Drawing.Color.Red;

                //Dont Give too much information this might tell a hacker what is wrong in the login

            }

        }

        else

        {

            lblMessage.Text = "Please make sure that the username and the password is Correct";

        }
        */

    }
}