using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for ClassDBInterface
/// </summary>
public class ClassDBInterface
{
    public ClassDBInterface()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    SqlParameter[] nobjSqlParameter = new SqlParameter[0];
    public void AddParams(String p_strParamName, Object p_objValue, SqlDbType p_objSqlDbType)
    {
        Array.Resize(ref nobjSqlParameter, nobjSqlParameter.Length + 1);
        nobjSqlParameter[nobjSqlParameter.Length - 1] = new SqlParameter();
        nobjSqlParameter[nobjSqlParameter.Length - 1].SqlDbType = p_objSqlDbType;
        nobjSqlParameter[nobjSqlParameter.Length - 1].SqlValue = p_objValue;
        nobjSqlParameter[nobjSqlParameter.Length - 1].ParameterName = p_strParamName;


    }

    public DataTable GetDataTable(String p_strQuery, CommandType p_objCommandType)
    {
        DataTable objDt = new DataTable();
        SqlConnection objSqlConnection = null;
        SqlCommand objSqlCommand = null;
        SqlDataAdapter objSqlDataAdapter = null;
        try
        {
            String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            objSqlConnection = new SqlConnection(strConnString);
            objSqlCommand = new SqlCommand(p_strQuery, objSqlConnection);
            objSqlCommand.CommandType = p_objCommandType;

            foreach (SqlParameter objSqlParameter in nobjSqlParameter)
                objSqlCommand.Parameters.Add(objSqlParameter);

            objSqlDataAdapter = new SqlDataAdapter(objSqlCommand);
            objSqlConnection.Open();
            objSqlDataAdapter.Fill(objDt);
            objSqlConnection.Close();
            objSqlConnection = null;
        }
        catch
        {

        }
        finally
        {
            if (objSqlConnection != null)
            {
                objSqlConnection.Close();
                objSqlConnection = null;
            }
            if (objSqlCommand != null)
            {
                objSqlCommand = null;
            }
            if (objSqlDataAdapter != null)
            {
                objSqlDataAdapter = null;
            }
        }
        return objDt;
    }

    public DataSet GetDataSet(String p_strQuery, CommandType p_objCommandType)
    {
        DataSet objDS = new DataSet();
        SqlConnection objSqlConnection = null;
        SqlCommand objSqlCommand = null;
        SqlDataAdapter objSqlDataAdapter = null;
        try
        {
            String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            objSqlConnection = new SqlConnection(strConnString);
            objSqlCommand = new SqlCommand(p_strQuery, objSqlConnection);
            objSqlCommand.CommandType = p_objCommandType;

            foreach (SqlParameter objSqlParameter in nobjSqlParameter)
                objSqlCommand.Parameters.Add(objSqlParameter);

            objSqlDataAdapter = new SqlDataAdapter(objSqlCommand);
            objSqlConnection.Open();
            objSqlDataAdapter.Fill(objDS);
            objSqlConnection.Close();
            objSqlConnection = null;
        }
        catch
        {

        }
        finally
        {
            if (objSqlConnection != null)
            {
                objSqlConnection.Close();
                objSqlConnection = null;
            }
            if (objSqlCommand != null)
            {
                objSqlCommand = null;
            }
            if (objSqlDataAdapter != null)
            {
                objSqlDataAdapter = null;
            }
        }
        return objDS;
    }





    public int executeQuery(string p_strQuery)
    {
        int intRowAffected = 0;
        SqlConnection objSqlConnection = null;
        SqlCommand objSqlCommand = null;
        try
        {
            if (p_strQuery != null)
            {
                String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
                objSqlConnection = new SqlConnection(strConnString);

                
                objSqlCommand = new SqlCommand(p_strQuery, objSqlConnection);
                objSqlCommand.CommandType = CommandType.Text;
                objSqlConnection.Open();
                
                intRowAffected = objSqlCommand.ExecuteNonQuery();

                
                objSqlConnection.Close();
            }
        }
        catch (Exception ex)
        {
            throw ex;
            //MessageBox.Show(ex.Message);
        }
        finally
        {
            if (objSqlConnection != null)
            {
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }

        return intRowAffected;
    }

    public Object ExecuteScalar(string p_strQuery, CommandType p_obj)
    {
        Object objData = null;
        SqlConnection objSqlConnection = null;
        SqlCommand objSqlCommand = null;
        try
        {
            if (p_strQuery != null)
            {
                String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
                objSqlConnection = new SqlConnection(strConnString);
                objSqlCommand = new SqlCommand(p_strQuery, objSqlConnection);

                foreach (SqlParameter objSqlParam in nobjSqlParameter)
                {
                    objSqlCommand.Parameters.Add(objSqlParam);
                }
                objSqlCommand.CommandType = p_obj;
                objSqlConnection.Open();

                objData = objSqlCommand.ExecuteScalar();
                objSqlConnection.Close();
            }
        }
        catch (Exception ex)
        {
            throw ex;
            //MessageBox.Show(ex.Message);
        }
        finally
        {
            if (objSqlConnection != null)
            {
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }

        return objData;
    }

    string ReturnString;
    public string GetStringData(string Query,CommandType obj_Type)
    {
        SqlConnection objSqlConnection = null;
        SqlCommand objSqlCommand = null;
      
        try
        {
            String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            objSqlConnection = new SqlConnection(strConnString);

            if (objSqlConnection.State == ConnectionState.Closed)
                objSqlConnection.Open();
            objSqlCommand = new SqlCommand(Query, objSqlConnection);
            objSqlCommand.CommandType = obj_Type;
            ReturnString = Convert.ToString(objSqlCommand.ExecuteScalar());


        }
        catch (Exception aa)
        {
            ReturnString = "Error";
          //  throw;
        }
        finally
        {
            if (objSqlConnection.State == ConnectionState.Open)
                objSqlConnection.Close();
        }

        return ReturnString;
    
    }



    public Object ExecuteNonquery(string p_strQuery, CommandType p_obj)
    {
        Object objData = null;
        SqlConnection objSqlConnection = null;
        SqlCommand objSqlCommand = null;
        try
        {
            if (p_strQuery != null)
            {
                String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
                objSqlConnection = new SqlConnection(strConnString);
                objSqlCommand = new SqlCommand(p_strQuery, objSqlConnection);

                foreach (SqlParameter objSqlParam in nobjSqlParameter)
                {
                    objSqlCommand.Parameters.Add(objSqlParam);
                }
                objSqlCommand.CommandType = p_obj;
                objSqlConnection.Open();

                objData = objSqlCommand.ExecuteNonQuery();
                objSqlConnection.Close();
            }
        }
        catch (Exception ex)
        {
            throw ex;
            //MessageBox.Show(ex.Message);
        }
        finally
        {
            if (objSqlConnection != null)
            {
                objSqlConnection.Dispose();
                objSqlConnection = null;
            }
        }

        return objData;
    }

   

}