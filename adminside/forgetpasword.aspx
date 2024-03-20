<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgetpasword.aspx.cs" Inherits="adminside.forgetpasword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Forget Password</title>
    <style>
        
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
        }
        .container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }
        th, td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
        th {
            background-color: #f2f2f2;
        }
        .form-group {
            margin-bottom: 20px;
        }
        .btn-primary {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 12px 20px;
            border-radius: 5px;
            cursor: pointer;
        }
        .btn-primary:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Forget Password</h2>
            <table>
                <tr>
                    <th>Enter your email:</th>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="Button2" runat="server" Text="Find Pasword" CssClass="btn btn-primary" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                    </td>
                     <td colspan="2" class="link-row">
                            <a href="userloginform.aspx" class="link"> for loginp</a>
                        </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
