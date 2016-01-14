<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html>
<head>
    <meta charset="UTF-8">
    <title>Login & Register form</title>




    <link rel="stylesheet" href="css/Style.css">
</head>

<body>
    <form id="form1" runat="server">
        <div class="login-wrap">
            <h2>Login</h2>

            <div class="form">
                <%--  <input type="text" placeholder="Username" name="un" />--%>
                <asp:TextBox ID="txtuserName" runat="server" placeholder="Username"></asp:TextBox>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>

                <asp:Button ID="btnLogin" runat="server" Style="color: white; font-size: 18px; font-weight: 200; cursor: pointer; transition: box-shadow .4s ease; background-color: #e74c3c; width: 81%; height: 47px; margin: 0 0 0 33px; padding: 15px;"
                    Text="Login"
                    OnClick="btnLogin_Click" />
            </div>
            <asp:Label ID="lblerrormsg" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <script src='https://code.jquery.com/jquery-1.10.0.min.js'></script>

        <script src="Js/LoginJs.js"></script>



        <
    </form>
</body>
</html>







<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin: 0 auto; width: 50%; border: 1px solid">
            <table style="width: 80%">
                <tr>
                    <td>UserName :
                    </td>
                    <td>
                        <asp:TextBox ID="txtuserName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Password :
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnLogin" runat="server" Text="Login"
                            OnClick="btnLogin_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblerrormsg" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>--%>
