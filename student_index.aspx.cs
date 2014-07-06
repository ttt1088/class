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

public partial class student_index : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["classConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["login"] == null)
        {
            Response.Redirect("login.aspx");
        }
        String sql = "select stuClass from Student where stuID='" + Session["login"] +  "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader myreader = cmd.ExecuteReader();
        while (myreader.Read())
        {
            int stuclass = myreader.GetInt32(0);/*获取专业ID*/
            Session["class"] = stuclass;
        }
        
        myreader.Close();
        con.Close();
        //TextBox1.BackColor = System.Drawing.Color.Transparent;
        SetBox();  
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox62.Text == TextBox63.Text)
        {
            if (TextBox61.Text == Session["pass"].ToString())
            {
                if (TextBox62.Text.Length > 5 && TextBox62.Text.Length < 16)
                {
                    changepass ch = new changepass();
                    ch.Schangepass(TextBox62.Text, Session["login"].ToString());
                    Session["pass"] = TextBox62.Text;
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
        addclass ad = new addclass();
        if (DropDownList1.SelectedIndex == 0)
        {
            Response.Write("<script>alert('请选择课程')</script>");
        }
        else
        {
            if (ad.stu_chk(Session["login"].ToString(),Session["time"].ToString()))
            {
                Response.Write("<script>alert('课程时间与已选课程有冲突')</script>");
            }
            else 
            {
                ad.stu_add(Session["login"].ToString(), Session["courseid"].ToString(), Session["time"].ToString());
                Response.Write("<script>alert('课程添加成功')</script>");
            }            
        }
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Session["login"] = null;
        Session["pass"] = null;
        Response.Redirect("login.aspx");
    }
    public void SetBox()
    {
        TextBox[] myTextBox = new TextBox[61];
        myTextBox[0] = TextBox61;
        myTextBox[1] = TextBox1;
        myTextBox[2] = TextBox2;
        myTextBox[3] = TextBox3;
        myTextBox[4] = TextBox4;
        myTextBox[5] = TextBox5;
        myTextBox[6] = TextBox6;
        myTextBox[7] = TextBox7;
        myTextBox[8] = TextBox8;
        myTextBox[9] = TextBox9;
        myTextBox[10] = TextBox10;
        myTextBox[11] = TextBox11;
        myTextBox[12] = TextBox12;
        myTextBox[13] = TextBox13;
        myTextBox[14] = TextBox14;
        myTextBox[15] = TextBox15;
        myTextBox[16] = TextBox16;
        myTextBox[17] = TextBox17;
        myTextBox[18] = TextBox18;
        myTextBox[19] = TextBox19;
        myTextBox[20] = TextBox20;
        myTextBox[21] = TextBox21;
        myTextBox[22] = TextBox22;
        myTextBox[23] = TextBox23;
        myTextBox[24] = TextBox24;
        myTextBox[25] = TextBox25;
        myTextBox[26] = TextBox26;
        myTextBox[27] = TextBox27;
        myTextBox[28] = TextBox28;
        myTextBox[29] = TextBox29;
        myTextBox[30] = TextBox30;
        myTextBox[31] = TextBox31;
        myTextBox[32] = TextBox32;
        myTextBox[33] = TextBox33;
        myTextBox[34] = TextBox34;
        myTextBox[35] = TextBox35;
        myTextBox[36] = TextBox36;
        myTextBox[37] = TextBox37;
        myTextBox[38] = TextBox38;
        myTextBox[39] = TextBox39;
        myTextBox[40] = TextBox40;
        myTextBox[41] = TextBox41;
        myTextBox[42] = TextBox42;
        myTextBox[43] = TextBox43;
        myTextBox[44] = TextBox44;
        myTextBox[45] = TextBox45;
        myTextBox[46] = TextBox46;
        myTextBox[47] = TextBox47;
        myTextBox[48] = TextBox48;
        myTextBox[49] = TextBox49;
        myTextBox[50] = TextBox50;
        myTextBox[51] = TextBox51;
        myTextBox[52] = TextBox52;
        myTextBox[53] = TextBox53;
        myTextBox[54] = TextBox54;
        myTextBox[55] = TextBox55;
        myTextBox[56] = TextBox56;
        myTextBox[57] = TextBox57;
        myTextBox[58] = TextBox58;
        myTextBox[59] = TextBox59;
        myTextBox[60] = TextBox60;
        for (int i = 1; i <= 60; i++)
        {
            myTextBox[i].BackColor = System.Drawing.Color.Transparent;/*设置背景色为透明*/
            myTextBox[i].ReadOnly = true;
            myTextBox[i].TextMode = TextBoxMode.MultiLine;
            myTextBox[i].Rows = 4;
        }
        for (int j = 0; j < GridView1.Rows.Count; j++)
        {
            int k = Convert.ToInt32(GridView1.Rows[j].Cells[3].Text);
            myTextBox[k].Text = GridView1.Rows[j].Cells[1].Text + "\r" + GridView1.Rows[j].Cells[2].Text + "\r" + GridView1.Rows[j].Cells[4].Text + "\r学分：" + GridView1.Rows[j].Cells[6].Text;
        }
        String sql = "select * from Record where stuID='" + Session["login"] + "'";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader myreader = cmd.ExecuteReader();
        while (myreader.Read())
        {
            string courseid = myreader[1].ToString();
            for (int p = 0; p < GridView2.Rows.Count; p++)
            {
                if (GridView2.Rows[p].Cells[0].Text == courseid)
                {
                    int q = Convert.ToInt32(GridView2.Rows[p].Cells[3].Text);
                    myTextBox[q].Text = GridView2.Rows[p].Cells[1].Text + "\r" + GridView2.Rows[p].Cells[2].Text + "\r" + GridView2.Rows[p].Cells[4].Text + "\r学分：" + GridView2.Rows[p].Cells[6].Text;
                }                
            }
        }
        myreader.Close();
        con.Close();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0)
        {
            Label1.Text = "课程名称：";
            Label2.Text = "上课老师：";
            Label3.Text = "上课时间：";
            Label4.Text = "上课地点：";
            Label5.Text = "课程类型：";
            Label6.Text = "课程学分：";
            Label7.Text = "限定人数：";
        }
        else
        {
            for (int j = 0; j < GridView2.Rows.Count; j++)
            {
                if (GridView2.Rows[j].Cells[0].Text == DropDownList1.SelectedValue)
                {
                    string time = null;
                    Session["time"] = GridView2.Rows[j].Cells[3].Text;
                    Session["courseid"] = GridView2.Rows[j].Cells[0].Text;
                    int k = Convert.ToInt32(GridView2.Rows[j].Cells[3].Text) / 12;
                    switch (k)
                    {
                        case 0:
                            time = "周一第";
                            break;
                        case 1:
                            time = "周二第";
                            break;
                        case 2:
                            time = "周三第";
                            break;
                        case 3:
                            time = "周四第";
                            break;
                        case 4:
                            time = "周五第";
                            break;
                    }

                    Label1.Text = "课程名称：" + GridView2.Rows[j].Cells[1].Text;
                    Label2.Text = "上课老师：" + GridView2.Rows[j].Cells[2].Text;
                    Label3.Text = "上课时间：" + time + Convert.ToInt32(GridView2.Rows[j].Cells[3].Text) % 12 + "节";
                    Label4.Text = "上课地点：" + GridView2.Rows[j].Cells[4].Text;
                    Label5.Text = "课程类型：选修课";
                    Label6.Text = "课程学分：" + GridView2.Rows[j].Cells[6].Text;
                    Label7.Text = "限定人数：" + GridView2.Rows[j].Cells[7].Text;
                }
            }
        }
    }

}