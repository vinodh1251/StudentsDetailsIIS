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

public partial class Home : System.Web.UI.Page
{

    StudentClass StudentClassObject;
    DataSet ds;
    string ReturnValue;

    protected void Page_Load(object sender, EventArgs e)
    {
        lblerrormsg_Submit.Text = "";
        if (Session["ID"] == null)
        {
            Response.Redirect("login.aspx");
        }
        if (!IsPostBack)
        {
          //  lblsessionIdDisplay.Text = Session.SessionID.ToString();
            DisplayStudent_Grid();
        }
    }


    /// <summary>
    /// this method using for get the student data and return table 
    /// </summary>
    public void DisplayStudent_Grid()
    {

        try
        {
            StudentClassObject = new StudentClass();
            ds = new DataSet();
            ds = StudentClassObject.GetStudentData(Convert.ToInt32(Session["ID"].ToString()), "");
            GridView1.DataSource = null;
            if (ds.Tables.Count != 0)
            {
                GridView1.DataSource = ds.Tables[0];
            }

            //GridView1.DataBind();
        }
        catch (Exception)
        {
            GridView1.DataSource = null;
        }
        finally
        {
            GridView1.DataBind();
        }
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //  0 means insert ,1 means not insert, 2 means runtime error
        try
        {
            StudentClassObject = new StudentClass();
            ReturnValue = StudentClassObject.SaveStudentData(txtStudentName.Text, txtStudentAddress.Text, txtStudyingClass.Text);
            if (ReturnValue == "0")
            {
                lblerrormsg_Submit.Text = "Successfully Submitted";
                DisplayStudent_Grid();
                ClrSubmitData();
            }
            else if (ReturnValue == "1")
            {
                lblerrormsg_Submit.Text = "Not  Submitted";

            }
            else if (ReturnValue == "2")
            {
                lblerrormsg_Submit.Text = "Rutime Error while Student Class";
            }
            else
            { lblerrormsg_Submit.Text = "Rutime Error while Student Class return some thing"; }
        }
        catch (Exception)
        {

            lblerrormsg_Submit.Text = "Runtime error while submitting same page";
        }
    }

    /// <summary>
    /// this method using for clear the submitting data
    /// </summary>
    public void ClrSubmitData()
    {
        txtStudentName.Text = "";
        txtStudentAddress.Text = "";
        txtStudyingClass.Text = "";

    }
    protected void lnklogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.SessionID.Remove(0);
        Session.RemoveAll();
        Session.Abandon();
        Session.Abandon();
        Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
        Response.Redirect("login.aspx");
    }
}
