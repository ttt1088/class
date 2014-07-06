<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="admin_index.aspx.cs" Inherits="Admin_index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript" src="js/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="css/admin.css" />
    <div id="adminmenu">
            <div style="margin-top:120px">
            <p><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">添加学生</asp:LinkButton></p>
            <p><asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">添加课程</asp:LinkButton></p>
            <p><asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">修改密码</asp:LinkButton></p>
            <p><asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">退出登录</asp:LinkButton></p>
            </div>
    </div>
    <div id="admin">
            <div id="adminmain">
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server"><div id="addstu">
                    学号<asp:TextBox ID="TextBox4" runat="server" Width="150px"></asp:TextBox>
                    <br />
                    <br />
                    姓名<asp:TextBox ID="TextBox5" runat="server" Width="150px"></asp:TextBox>
                    <br />
                    <br />
                    年级<asp:TextBox ID="TextBox6" runat="server" Width="150px"></asp:TextBox>
                    <br />
                    <br />
                    专业<asp:DropDownList ID="DropDownList1" runat="server" Width="150px">
                        <asp:ListItem Value="101">计算机科学与技术</asp:ListItem>
                        <asp:ListItem Value="102">通信工程</asp:ListItem>
                        <asp:ListItem Value="201">数学</asp:ListItem>
                        <asp:ListItem Value="202">物理</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="提交" /></div>
                </asp:View>
                <asp:View ID="View2" runat="server"><div id="addclass">                                    
                    课程编号<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    课程名称<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    上课老师<asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    上课时间<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    上课地点<asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    课程类型<asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem Value="0">必修</asp:ListItem>
                        <asp:ListItem Value="1">选修</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    课程学分<asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    限定人数<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    可选专业<asp:DropDownList ID="DropDownList3" runat="server">
                        <asp:ListItem Value="101">计算机科学与技术</asp:ListItem>
                        <asp:ListItem Value="102">通信工程</asp:ListItem>
                        <asp:ListItem Value="201">数学</asp:ListItem>
                        <asp:ListItem Value="202">物理</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="提交" /></div>   
                </asp:View>
                
                <asp:View ID="View3" runat="server">
                    <table id="changepass">
                        <tr>
                            <td>原密码</td><td>
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>新密码</td><td>
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>重复新密码</td><td>
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr><td></td>
                            <td><asp:Button ID="Button1" runat="server" Text="提交" OnClick="Button1_Click" /></td>
                            <%--<td><asp:LinkButton ID="LinkButton4" runat="server" SkinID="learnbt" CssClass="button" ForeColor="#F75A6F" Font-Names="KaiTi" Font-Size="X-Large">提交</asp:LinkButton></td>--%>
                        </tr>

                    </table>

                </asp:View>
            </asp:MultiView>
            </div>
        </div>
</asp:Content>

