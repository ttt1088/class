<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="student_index.aspx.cs" Inherits="student_index" StylesheetTheme="textb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript" src="js/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <link rel="stylesheet" type="text/css" href="css/stu.css" />
    <%--<div>--%>
        <div id="stumenu">
            <div style="margin-top:120px">
            <p><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">我的课表</asp:LinkButton></p>
            <p><asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">增选课程</asp:LinkButton></p>
            <p><asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">修改密码</asp:LinkButton></p>
            <p><asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">退出登录</asp:LinkButton></p>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:classConnectionString %>" SelectCommand="SELECT [stuClass] FROM [Student] WHERE ([stuID] = @stuID)">
                        <SelectParameters>
                            <asp:SessionParameter Name="stuID" SessionField="login" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:classConnectionString %>" SelectCommand="SELECT * FROM [Course] WHERE (([courseClass] = @courseClass) AND ([courseType] = @courseType))">
                        <SelectParameters>
                            <asp:SessionParameter Name="courseClass" SessionField="class" Type="Int32" />
                            <asp:Parameter DefaultValue="0" Name="courseType" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:classConnectionString %>" SelectCommand="SELECT * FROM [Course] WHERE (([courseClass] = @courseClass) AND ([courseType] = @courseType))">
                    <SelectParameters>
                        <asp:SessionParameter Name="courseClass" SessionField="class" Type="Int32" />
                        <asp:Parameter DefaultValue="1" Name="courseType" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                    <div style="display:none"><asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="courseID" DataSourceID="SqlDataSource2">
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
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="courseID" DataSourceID="SqlDataSource3">
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
                    </div>
                
            </div>
        </div>
        <div id="stu">
            <div id="stumain">
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View1" runat="server">
                    <table id="class">
                        <tr><th class="first"></th><th>周一</th><th>周二</th><th>周三</th><th>周四</th><th>周五</th></tr>
                        <tr><td class="first">第一节</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox13" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox25" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox37" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox49" runat="server"></asp:TextBox></td></tr>
                        <tr class="alt"><td class="first">第二节</td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox14" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox26" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox38" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox50" runat="server"></asp:TextBox></td></tr>
                        <tr><td class="first">第三节</td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox15" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox27" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox39" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox51" runat="server"></asp:TextBox></td></tr>
                        <tr class="alt"><td class="first">第四节</td><td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox16" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox28" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox40" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox52" runat="server"></asp:TextBox></td></tr>
                        <tr><td class="first">第五节</td><td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox17" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox29" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox41" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox53" runat="server"></asp:TextBox></td></tr>
                        <tr class="alt"><td class="first">第六节</td><td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox18" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox30" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox42" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox54" runat="server"></asp:TextBox></td></tr>
                        <tr><td class="first">第七节</td><td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox19" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox31" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox43" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox55" runat="server"></asp:TextBox></td></tr>
                        <tr class="alt"><td class="first">第八节</td><td><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox20" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox32" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox44" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox56" runat="server"></asp:TextBox></td></tr>
                        <tr><td class="first">第九节</td><td><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox21" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox33" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox45" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox57" runat="server"></asp:TextBox></td></tr>
                        <tr class="alt"><td class="first">第十节</td><td><asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox22" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox34" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox46" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox58" runat="server"></asp:TextBox></td></tr>
                        <tr><td class="first">第十一节</td><td><asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox23" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox35" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox47" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox59" runat="server"></asp:TextBox></td></tr>
                        <tr class="alt"><td class="first">第十二节</td><td><asp:TextBox ID="TextBox12" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox24" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox36" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox48" runat="server"></asp:TextBox></td><td><asp:TextBox ID="TextBox60" runat="server"></asp:TextBox></td></tr>
                    </table>
                </asp:View>
                <asp:View ID="View2" runat="server">
                    <div id="pick">
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3" DataTextField="courseName" DataValueField="courseID" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AppendDataBoundItems="True">
                            <asp:ListItem>请选择课程</asp:ListItem>
                        </asp:DropDownList><br />
                        <div id="classinfo">
                        <asp:Label ID="Label1" runat="server" CssClass="pickclass" Text="课程名称："></asp:Label><br />
                        <asp:Label ID="Label2" runat="server" CssClass="pickclass" Text="上课老师："></asp:Label><br />
                        <asp:Label ID="Label3" runat="server" CssClass="pickclass" Text="上课时间："></asp:Label><br />
                        <asp:Label ID="Label4" runat="server" CssClass="pickclass" Text="上课地点："></asp:Label><br />
                        <asp:Label ID="Label5" runat="server" CssClass="pickclass" Text="课程类型："></asp:Label><br />
                        <asp:Label ID="Label6" runat="server" CssClass="pickclass" Text="课程学分："></asp:Label><br />
                        <asp:Label ID="Label7" runat="server" CssClass="pickclass" Text="限定人数："></asp:Label>
                         <br /><br />   <asp:Button ID="Button2" runat="server" Text="确认提交，无法修改！" OnClick="Button2_Click" />
                        </div>
                        
                    </div>
                    
                </asp:View>
                
                <asp:View ID="View3" runat="server">
                    <table id="changepass">
                        <tr>
                            <td>原密码</td><td>
                                <asp:TextBox ID="TextBox61" runat="server" SkinID="pass" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>新密码</td><td>
                                <asp:TextBox ID="TextBox62" runat="server" SkinID="pass" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>重复新密码</td><td>
                                <asp:TextBox ID="TextBox63" runat="server" SkinID="pass" TextMode="Password"></asp:TextBox></td>
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
    <%--</div>--%>
<%--    <script type="text/javascript">
        $(function () {
            $(".button").hover(function () {
                $(this).stop(true, false).animate({ "opacity": 1 }, 300);
            }, function () {
                $(this).stop(true, false).animate({ "opacity": 0.7 }, 300);
            });

        });
    </script>--%>
<script type="text/javascript">
    //页面背景高度适应课表高度
    $(function () {
        var h = parseFloat($("#class").css("height"));
        var h2 = parseFloat(90);
        h = h + h2;
        $("#menu").css("height", h);
        $("#main").css("height", h);
    });
  </script>
</asp:Content>
    

