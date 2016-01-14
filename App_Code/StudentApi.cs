using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;
using System.Web.Script.Services;

/// <summary>
/// Summary description for StudentApi
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService]
public class StudentApi : System.Web.Services.WebService
{
    StudentClass StudentClsObject;
    DataSet ds;
    List<Dictionary<string, object>> rows;
    System.Web.Script.Serialization.JavaScriptSerializer serializer;

    string ReturnValue = string.Empty;

    public StudentApi()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }



    /// <summary>
    /// this method using for get the student details depend login id
    /// </summary>
    /// <param name="UserID"></param>
    /// <returns> Jshon format</returns>

    [WebMethod(EnableSession = true)]
    public void GetStudentDetails_Json(string Session_Key, string Student_No)
    {
        int LoginID = 0;
        rows = new List<Dictionary<string, object>>();
        serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        if (HttpContext.Current.Session["ID"] == null)
        {

            Context.Response.Write("[{Status: Login is experied}]");
        }
        else if (Convert.ToString(HttpContext.Current.Session.SessionID) == Session_Key)
        {

            DataTable dt = new DataTable();
            StudentClsObject = new StudentClass();
            ds = new DataSet();
            try
            {

                LoginID = Convert.ToInt32(HttpContext.Current.Session["ID"].ToString());
                ds = StudentClsObject.GetStudentData(LoginID, Student_No);
                dt = ds.Tables[0];
                Dictionary<string, object> row;
                foreach (DataRow dr in dt.Rows)
                {
                    row = new Dictionary<string, object>();
                    foreach (DataColumn col in dt.Columns)
                    {
                        row.Add(col.ColumnName, dr[col]);
                    }
                    rows.Add(row);
                }

            }
            catch (Exception)
            {


            }
            if (rows.Count > 0)
            {

                Context.Response.Write(serializer.Serialize(rows));
            }
        }
        else
        {
            // Context.Response.Clear();
            //  Context.Response.ContentType = "application/json; charset=utf-8";
            Context.Response.Write("[{Status: Session key is not Matched}]");
        }
    }


    [WebMethod]
    public DataTable GetStudentDetails_Xml(int UserID, string StudentId)
    {

        StudentClsObject = new StudentClass();
        ds = StudentClsObject.GetStudentData(UserID, StudentId);
        return ds.Tables[0];

    }

    /// <summary>
    /// this method using for the check login credentials
    /// </summary>
    /// <param name="UserName"></param>
    /// <param name="Password"></param>
    /// <returns> status of account 0 or null or empty means not exist account </returns>
    [WebMethod(EnableSession = true)]
    [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
    public void CheckLoginCredentials(string UserName, string Password)
    {

        rows = new List<Dictionary<string, object>>();
        serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

        ReturnValue = string.Empty;
        StudentClsObject = new StudentClass();
        DataTable dt = new DataTable();
        dt = StudentClsObject.CheckLoginCredentials(UserName, Password);
        Dictionary<string, object> row;
        foreach (DataRow dr in dt.Rows)
        {
            row = new Dictionary<string, object>();
            foreach (DataColumn col in dt.Columns)
            {
                row.Add(col.ColumnName, dr[col]);
            }
            rows.Add(row);
        }
        //  string s = HttpContext.Current.Session["ID"].ToString(); ;
        //HttpContext.Current.Session["ID"] = HttpContext.Current.Session["ID"].ToString();
        // Context.Response.Clear();
        // Context.Response.ContentType = "application/json";
        Context.Response.Write(serializer.Serialize(rows));
    }

}

