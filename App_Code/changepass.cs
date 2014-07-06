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
/// changepass 的摘要说明
/// </summary>
public class changepass
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["classConnectionString"].ConnectionString);
	public changepass()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public bool Schangepass(string np, string id)
    {
        String sql = "update Student set stuPwd='" + np + "'where stuID='" + id + "'";
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
    public bool Achangepass(string np, string id)
    {
        String sql = "update Admin set adPwd='" + np + "'where adID='" + id + "'";
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