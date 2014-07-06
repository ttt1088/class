using System;
using System.Data;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

/// <summary>
/// addstudent 的摘要说明
/// </summary>
public class addstudent
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["classConnectionString"].ConnectionString);
	public addstudent()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public bool ad_chk(string stuID)
    {
        String sql = "select * from Student where stuID='" + stuID + "'";
        SqlCommand cmd = new SqlCommand(sql, con);
        try
        {
            con.Open();
            SqlDataReader da = cmd.ExecuteReader();

            if (!da.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            con.Close();
        }
    }
    public bool ad_addstu(string stuID, string stuName, string stuDepart, string stuGrade, string stuClass)
    {
        String sql = "insert into Student values('" + stuID + "','111111','" + stuName + "'," + stuDepart + "," + stuGrade + "," + stuClass + ")";
        SqlCommand cmd = new SqlCommand(sql, con);
        try
        {
            con.Open();
            SqlDataReader da = cmd.ExecuteReader();

            if (da.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception ex)
        {
            throw (ex);
        }
        finally
        {
            con.Close();
        }
    }
}