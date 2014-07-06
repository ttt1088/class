<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script type="text/javascript" src="js/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="css/login.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="reg">
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Username用户名" Width="130px" ForeColor="#333333"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Width="220px" Font-Names="Microsoft YaHei UI" Font-Size="Medium" ForeColor="#555555"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Password密码" Width="130px" ForeColor="#333333"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Width="220px" TextMode="Password" Font-Names="Microsoft YaHei UI" Font-Size="Medium" ForeColor="#555555"></asp:TextBox>
                <br />
                <br />
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem>学生</asp:ListItem>
                    <asp:ListItem>教务员</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:LinkButton ID="Button1" runat="server" Text="Login" SkinID="learnbt" CssClass="button" ForeColor="#F75A6F" Width="365px" Font-Names="Comic Sans MS" Font-Size="X-Large" OnClick="Button1_Click"/>
                <br />
                <br />
            </asp:View>
        </asp:MultiView>
    </div>
    <script type="text/javascript">
            $(function () {
                $(".button").hover(function () {
                    $(this).stop(true, false).animate({ "opacity": 1 }, 300);
                }, function () {
                    $(this).stop(true, false).animate({ "opacity": 0.7 }, 300);
                });

            });
    </script>
</asp:Content>

