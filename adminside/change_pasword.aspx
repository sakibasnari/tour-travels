<%@ Page Title="" Language="C#" MasterPageFile="user2.Master" AutoEventWireup="true" CodeBehind="change_pasword.aspx.cs" Inherits="adminside.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Change Password</h2>
        <table>
            <tr>
                <th>Email:</th>
                <td><asp:TextBox ID="Textemail" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox></td>
            </tr>
            <tr>
                <th>New Password:</th>
                <td><asp:TextBox ID="Textpasword" runat="server" CssClass="form-control"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="ok" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="ok_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
