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

public partial class Admin_index : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["classConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["alogin"] == null)
        {
            Response.Redirect("login.aspx");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Session["alogin"] = null;
        Session["pass"] = null;
        Response.Redirect("login.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text == TextBox3.Text)
        {
            if (TextBox1.Text == Session["pass"].ToString())
            {
                if (TextBox2.Text.Length > 5 && TextBox2.Text.Length < 16)
                {
                    changepass ch = new changepass();
                    ch.Achangepass(TextBox2.Text, Session["alogin"].ToString());
                    Session["pass"] = TextBox2.Text;
                    MultiView1.ActiveViewIndex = 0;
                    Response.Write("<script>alert('密码修改成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('密码长度必须为6-15位')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('原密码输入不正确')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('两次新密码输入不一致')</script>");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        addstudent ad = new addstudent();
        string depart = null;
        if (DropDownList1.SelectedValue == "101" || DropDownList1.SelectedValue == "102")
        {
            depart = "1";
        }
        else if (DropDownList1.SelectedValue == "201" || DropDownList1.SelectedValue == "202")
        {
            depart = "2";
        }
        if (ad.ad_chk(TextBox4.Text))
        {
            ad.ad_addstu(TextBox4.Text, TextBox5.Text, depart, TextBox6.Text, DropDownList1.SelectedValue);
            Response.Write("<script>alert('学生添加成功')</script>");
        }
        else
        {
            Response.Write("<script>alert('该学号已存在')</script>");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        addclass ad = new addclass();
        if (Convert.ToInt32(TextBox10.Text) >= 1 && Convert.ToInt32(TextBox10.Text) <= 60)
        {
            if (ad.ad_chkid(TextBox7.Text))
            {
                if (DropDownList2.SelectedValue == "0")
                {
                    if (ad.ad_chktime0(TextBox10.Text, DropDownList3.SelectedValue))
                    {
                        ad.ad_addclass(TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, DropDownList2.SelectedValue, TextBox12.Text, TextBox13.Text, DropDownList3.SelectedValue);
                        Response.Write("<script>alert('课程添加成功')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('必修课不能与该专业其他课程有时间冲突')</script>");
                    }
                }
                else if (DropDownList2.SelectedValue == "1")
                {
                    if (ad.ad_chktime1(TextBox10.Text, DropDownList3.SelectedValue))
                    {
                        ad.ad_addclass(TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, DropDownList2.SelectedValue, TextBox12.Text, TextBox13.Text, DropDownList3.SelectedValue);
                        Response.Write("<script>alert('课程添加成功')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('选修课不能与该专业必修课有时间冲突')</script>");
                    }
                }
                
            }
            else
            {
                Response.Write("<script>alert('课程编号不能重复')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('课程时间必须为1-60之间')</script>");
        }
    }
}