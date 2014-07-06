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
/// logon 的摘要说明
/// </summary>
public class logon
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["classConnectionString"].ConnectionString);
	public logon()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public bool Schklogon(string username, string password)
    {
        String S_name = username;
        String S_pass = password;
        String sql = "select * from Student where stuID='" + S_name + "' and stuPwd='" + S_pass + "'";
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
    public bool Achklogon(string username, string password)
    {
        String A_name = username;
        String A_pass = password;
        String sql = "select * from Admin where adID='" + A_name + "' and adPwd='" + A_pass + "'";
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