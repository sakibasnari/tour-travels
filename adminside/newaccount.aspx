
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newaccount.aspx.cs" Inherits="adminside.newaccount" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="signupstyle.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <center>
                <table border="1">
                    <tr>
                        <th>email</th>
                        <td>
                            <asp:TextBox ID="Text__email" runat="server" required="" placeholder="Enter the email"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th>password</th>
                        <td>
                            <asp:TextBox ID="Text__pasword" runat="server" required="" placeholder="Enter the password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th>first_name</th>
                        <td>
                            <asp:TextBox ID="Text_firstname" runat="server" required="" placeholder="Enter the first name"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th>last_name</th>
                        <td>
                            <asp:TextBox ID="Text_secondname" runat="server" required="" placeholder="Enter the last name"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th>bio</th>
                        <td>
                            <asp:TextBox ID="Text_bio" runat="server" required="" placeholder="Enter the bio"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <th colspan="1">
                            <asp:Button ID="Button1" runat="server" Text=" Sign Up" OnClick="Button1_Click" />
                        </th>
                         <td colspan="1">
                            <a href="userloginform.aspx" class="link">  alrady have an account</a>
                        </td>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>
</html>

