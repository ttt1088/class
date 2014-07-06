<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:classConnectionString %>" SelectCommand="SELECT * FROM [Course] WHERE ([courseClass] = @courseClass)">
            <SelectParameters>
                <asp:Parameter DefaultValue="101" Name="courseClass" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="courseID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="courseID" HeaderText="courseID" ReadOnly="True" SortExpression="courseID" />
                <asp:BoundField DataField="courseName" HeaderText="courseName" SortExpression="courseName" />
                <asp:BoundField DataField="teaName" HeaderText="teaName" SortExpression="teaName" />
                <asp:BoundField DataField="courseTime" HeaderText="courseTime" SortExpression="courseTime" />
                <asp:BoundField DataField="courseAddress" HeaderText="courseAddress" SortExpression="courseAddress" />
                <asp:BoundField DataField="courseType" HeaderText="courseType" SortExpression="courseType" />
                <asp:BoundField DataField="courseCredit" HeaderText="courseCredit" SortExpression="courseCredit" />
                <asp:BoundField DataField="limitNum" HeaderText="limitNum" SortExpression="limitNum" />
                <asp:BoundField DataField="courseClass" HeaderText="courseClass" SortExpression="courseClass" />
            </Columns>
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" ReadOnly="True"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" BorderStyle="None" Height="40px" ReadOnly="True" Rows="3" TextMode="MultiLine" style="overflow:hidden;resize:none"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    </form>
</body>
</html>
