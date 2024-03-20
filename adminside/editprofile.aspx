<%@ Page Title="" Language="C#" MasterPageFile="user2.Master" AutoEventWireup="true" CodeBehind="editprofile.aspx.cs" Inherits="adminside.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
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
        .form-group label {
            font-weight: bold;
        }
        .form-control {
            width: 100%;
            padding: 10px;
            border-radius: 5px;
            border: 1px solid #ccc;
            transition: border-color 0.3s ease;
        }
        .form-control:focus {
            border-color: #007bff;
            outline: none;
        }
        .btn-primary {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 12px 20px;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }
        .btn-primary:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Edit Profile</h2>
        <div class="form-group">
            <label>Email:</label>
            <asp:TextBox ID="textemail" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>First Name:</label>
            <asp:TextBox ID="fname" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            <asp:TextBox ID="fname2" runat="server" CssClass="form-control" placeholder="Enter first name" required=""></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Second Name:</label>
            <asp:TextBox ID="sname" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            <asp:TextBox ID="sname2" runat="server" CssClass="form-control" placeholder="Enter second name" required=""></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Bio:</label>
            <asp:TextBox ID="TextBio" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            <asp:TextBox ID="TextBio2" runat="server" CssClass="form-control" placeholder="Enter bio" required=""></asp:TextBox>
        </div>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <asp:Button ID="Button1" runat="server" Text="Update Profile" CssClass="btn btn-primary" OnClick="Button1_Click" />
    </div>
</asp:Content>
