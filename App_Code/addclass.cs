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
/// addclass 的摘要说明
/// </summary>
public class addclass
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["classConnectionString"].ConnectionString);
	public addclass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public bool stu_add(string username, string courseid, string time)
    {
        String sql = "insert into Record values('" + username +"','" + courseid + "'," + time +")";
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
    public bool stu_chk(string courseID, string time)
    {
        String sql = "select * from Record where stuID='" + courseID + "' and courseTime='" + time + "'";
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
    public bool ad_chkid(string courseID)
    {
        String sql = "select * from Course where courseID='" + courseID + "'";
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
    public bool ad_chktime0(string courseTime,string courseClass)
    {
        String sql = "select * from Course where courseTime='" + courseTime + "'and courseClass='" + courseClass + "'";
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
    public bool ad_chktime1(string courseTime, string courseClass)
    {
        String sql = "select * from Course where courseTime='" + courseTime + "'and courseClass='" + courseClass + "'and courseType=0";
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
    public bool ad_addclass(string courseID, string courseName, string teaName, string courseTime, string courseAddress, string courseType, string courseCredit, string limitNum, string courseClass)
    {
        String sql = "insert into Course values('" + courseID + "','" + courseName+ "','" + teaName + "'," + courseTime + ",'" + courseAddress + "'," + courseType + "," + courseCredit + "," + limitNum + "," + courseClass + ")";
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