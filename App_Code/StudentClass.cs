using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Web.SessionState;


/// <summary>
/// Summary description for StudentClass
/// </summary>
public class StudentClass
{
    ClassDBInterface ClsDb;
    // DataSet ds;
    DataTable dt;
    string ReturnValue = string.Empty;


    public StudentClass()
    {


        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary>
    /// this method using for save the student data.
    /// </summary>
    /// <returns> 0 means insert ,1 means not insert, 2 means runtime error</returns>
    public string SaveStudentData(string StudentName, string StudentAddress, string StudentStudyingClass)
    {
        try
        {
            ClsDb = new ClassDBInterface();
            ClsDb.AddParams("@StudentName", StudentName, SqlDbType.VarChar);
            ClsDb.AddParams("@StudentAddress", StudentAddress, SqlDbType.VarChar);
            ClsDb.AddParams("@StudentStudyingClass", StudentStudyingClass, SqlDbType.VarChar);
            ReturnValue = Convert.ToString(ClsDb.ExecuteScalar("Sp_InsertStudentData", CommandType.StoredProcedure));

        }
        catch (Exception)
        {

            ReturnValue = "2";
        }
        return ReturnValue;

    }

    /// <summary>
    /// this method using for get the student data.
    /// </summary>
    /// <returns>Return Student Datatable </returns>
    public DataSet GetStudentData(int UserId, string StudentNo)
    {
        DataSet ds = new DataSet();
        try
        {
            ClsDb = new ClassDBInterface();
            ClsDb.AddParams("@UserId", UserId, SqlDbType.Int);
            ClsDb.AddParams("@StudentId", StudentNo, SqlDbType.VarChar);
            ds = ClsDb.GetDataSet("Sp_GetStudentDetails", CommandType.StoredProcedure);

        }
        catch (Exception)
        {


        }
        return ds;
    }



    /// <summary>
    /// this method using for the check the login credentials
    /// </summary>
    /// <param name="UserName"></param>
    /// <param name="Password"></param>
    /// <returns> status of account 0 or null or empty means not exist account,runtime error etc </returns>
    public DataTable CheckLoginCredentials(string UserName, string Password)
    {

        DataTable dtTemp = new DataTable();
        dtTemp.Columns.Add("Status");
        dtTemp.Columns.Add("SessionKey");
        dtTemp.Columns.Add("UserId");

        DataRow drTemp;
        try
        {

            ClsDb = new ClassDBInterface();
            dt = new DataTable();
            ClsDb.AddParams("@UserName", UserName, SqlDbType.VarChar);
            ClsDb.AddParams("@Password", Password, SqlDbType.VarChar);
            dt = ClsDb.GetDataTable("Sp_CheckLoginCredentials", CommandType.StoredProcedure);

            drTemp = dtTemp.NewRow();
            if (dt != null)
            {
                if (dt.Rows.Count != 0)
                {
                    if (dt.Rows[0][0].ToString() == "0" || dt.Rows[0][0].ToString() == null || dt.Rows[0][0].ToString() == "")
                    {
                        drTemp[0] = "Enter the Correct credentials";
                        drTemp[1] = "No key";
                        drTemp[2] = "0";
                    }
                    else if (dt.Rows[0][0].ToString() != "0")
                    {
                        HttpContext.Current.Session["ID"] = dt.Rows[0][0].ToString();

                        drTemp[0] = "Active";
                        drTemp[1] = HttpContext.Current.Session.SessionID;
                        drTemp[2] = dt.Rows[0][0].ToString();
                    }
                }
                else
                {
                    drTemp[0] = "Enter the Correct credentials";
                    drTemp[1] = "No key";
                    drTemp[2] = "0";
                }

            }
            else
            {
                drTemp[0] = "Some internal problem";
                drTemp[1] = "No key";
                drTemp[2] = "0";
            }

            dtTemp.Rows.Add(drTemp);

        }
        catch (Exception a)
        {
            drTemp = dtTemp.NewRow();
            drTemp[0] = "Exception" + a.Message;
            drTemp[1] = "No key";
            drTemp[2] = "0";
            dtTemp.Rows.Add(drTemp);
        }
        return dtTemp;
    }

}
