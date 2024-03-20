<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="add_product.aspx.cs" Inherits="adminside.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    
        .form-container {
            max-width: 500px; 
            margin: 0 auto; 
            padding: 20px;
            background-color: #f9f9f9; 
            border-radius: 10px; 
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1); 
        }
        .form-container h3 {
            text-align: center; 
            margin-bottom: 20px;
        }
        .form-container table {
            width: 100%; 
            border-collapse: collapse; 
        }
        .form-container th,
        .form-container td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }
        .form-container th {
            text-align: right; 
            width: 30%; 
        }
        .form-container td {
            text-align: left; 
            width: 70%;
        }
        .form-container input[type="text"],
        .form-container input[type="file"],
        .form-container input[type="button"] {
            width: calc(100% - 20px); 
            padding: 8px; 
            margin-bottom: 10px; 
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box; 
        }
        .form-container input[type="button"] {
            background-color: #007bff; 
            color: #fff; 
            cursor: pointer; 
            transition: background-color 0.3s; 
        }
        .form-container input[type="button"]:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-container">
        <h3>Add Product</h3>
        <table>
            <tr>
                <th>Code:</th>
                <td><asp:TextBox ID="Textcode" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Name:</th>
                <td><asp:TextBox ID="Textname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Price:</th>
                <td><asp:TextBox ID="Textprice" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Description:</th>
                <td><asp:TextBox ID="Textdisc" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <th>Image:</th>
                <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
            </tr>
            <tr>
                <th colspan="2"><asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" /></th>
            </tr>
        </table>
    </div>
</asp:Content>
