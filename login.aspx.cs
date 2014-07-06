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

public partial class login : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        logon go = new logon();
        if (RadioButtonList1.SelectedIndex == 0)
        {
            if (go.Schklogon(TextBox1.Text, TextBox2.Text))
            {
                Session["login"] = TextBox1.Text;
                Session["pass"] = TextBox2.Text;
                Server.Transfer("student_index.aspx");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误')</script>");
            }
        }
        else if (RadioButtonList1.SelectedIndex == 1)
        {
            if (go.Achklogon(TextBox1.Text, TextBox2.Text))
            {
                Session["alogin"] = TextBox1.Text;
                Session["pass"] = TextBox2.Text;
                Server.Transfer("admin_index.aspx");
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误')</script>");
            }
        }
        
        
    }
}