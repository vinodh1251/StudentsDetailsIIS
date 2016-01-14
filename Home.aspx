<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float: right">
            <asp:LinkButton ID="lnklogout" runat="server" OnClick="lnklogout_Click">logout</asp:LinkButton>
        </div>
        <div style="margin: 0 auto; width: 50%">
            <asp:Label ID="lblsessionIdDisplay" runat="server"></asp:Label>
            <div style="margin: 0 auto; width: 50%; text-align: center; font-size: 24px">Student Details </div>

            <table>
                <tr>
                    <td>Student Name
                    </td>
                    <td>
                        <asp:TextBox ID="txtStudentName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Student Address
                    </td>
                    <td>
                        <asp:TextBox ID="txtStudentAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Student Studying Class
                    </td>
                    <td>
                        <asp:TextBox ID="txtStudyingClass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblerrormsg_Submit" runat="server" ForeColor="Red"></asp:Label>

                    </td>
                </tr>
            </table>
        </div>
        <div style="margin: 0 auto; width: 50">
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <RowStyle BackColor="#EFF3FB" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="White" />
                <EmptyDataTemplate>
                    No Record Found
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
