<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userloginform.aspx.cs" Inherits="adminside.adminlogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f0f0;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 100%;
            max-width: 400px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        .container table {
            width: 100%;
        }

        .container th {
            text-align: left;
            padding: 10px;
        }

        .container td {
            padding: 10px;
        }

        .input-field {
            width: 80%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .btn-login {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            color: #fff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s;
        }

        .btn-login:hover {
            background-color: #0056b3;
        }

        .link-row {
            text-align: center;
        }

        .link {
            color: #007bff;
            text-decoration: none;
        }

        .link:hover {
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <center>
                <table border="1">
                    <tr>
                        <th>Email</th>
                        <td>
                            <asp:TextBox ID="Text__email" runat="server" PlaceHolder="Enter the email" CssClass="input-field" required=""></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <th>Password</th>
                        <td>
                            <asp:TextBox ID="Text__pasword" runat="server" PlaceHolder="Enter the password" TextMode="Password" CssClass="input-field" required=""></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <th colspan="2">
                            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" CssClass="btn-login" />
                        </th>
                    </tr>
                    <tr>
                        <td colspan="2" class="link-row">
                            <a href="newaccount.aspx" class="link">Don't have an account? Sign up</a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="link-row">
                            <a href="forgetpasword.aspx" class="link">Forgot password?</a>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" class="link-row">
                            <a href="dashbord.aspx" class="link">Access dashboard without login</a>
                        </td>
                    </tr>
                </table>
            </center>
        </div>
    </form>
</body>
</html>
