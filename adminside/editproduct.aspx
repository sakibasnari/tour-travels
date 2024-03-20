<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="editproduct.aspx.cs" Inherits="adminside.editproduct" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        
        body {
            font-family: Arial, sans-serif;
            background-color: #f8f9fa;
        }

 
        .container {
            max-width: 800px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h3 {
            margin-top: 0;
            color: #007bff;
        }

        #pnlProductDetails {
            margin-bottom: 20px;
        }


        table {
            width: 100%;
            border-collapse: collapse;
        }

        th, td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
        }

        th {
            background-color: #f2f2f2;
        }

        /* Textbox styles */
        input[type="text"],
        textarea {
            width: 100%;
            padding: 8px;
            border: 1px solid #ced4da;
            border-radius: 4px;
            box-sizing: border-box;
            margin-bottom: 10px;
        }

       
        button {
            background-color: #007bff;
            color: #fff;
            border: none;
            border-radius: 8px; 
            padding: 15px 30px; 
            cursor: pointer;
            font-size: 18px; 
            font-weight: bold; 
        }

        button:hover {
            background-color: #0056b3;
        }
    </style>

    <h3>Edit Product</h3>
    <asp:Panel ID="pnlProductDetails" runat="server">
        <table>
            <tr>
                <th>Code</th>
                <td>
                    <asp:Label ID="lblCode" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <th>Name</th>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>Price</th>
                <td>
                    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <th>Description</th>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click"  />
    </asp:Panel>
    <asp:Panel ID="pnlNoProduct" runat="server" Visible="false">
        <p>No product found for editing.</p>
    </asp:Panel>
</asp:Content>
