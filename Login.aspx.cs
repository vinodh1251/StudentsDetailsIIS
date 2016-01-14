using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Login : System.Web.UI.Page
{
    StudentClass StudentClassObject;

    string ReturnValue = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        try
        {
            StudentClassObject = new StudentClass();
            dt = StudentClassObject.CheckLoginCredentials(txtuserName.Text, txtPassword.Text);

            if (dt.Rows[0][0].ToString() == "Active")
            {
                // string key = Session.SessionID.ToString();
                // Response.Write(Session.SessionID.ToString());
                Response.Redirect("home.aspx");

            }
            else
            {
                lblerrormsg.Text = dt.Rows[0][0].ToString();
            }
        }
        catch (Exception)
        {

            // ReturnValue = "2";
        }
        // return ds;

    }
}
