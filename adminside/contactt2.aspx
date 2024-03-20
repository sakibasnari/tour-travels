<%@ Page Title="" Language="C#" MasterPageFile="~/user2.Master" AutoEventWireup="true" CodeBehind="contactt2.aspx.cs" Inherits="adminside.contactt2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        
        .container {
            max-width: 600px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }
        
        table {
            width: 100%;
            border-collapse: collapse;
        }
        
        th, td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
        
        th {
            background-color: #f2f2f2;
        }
        
        .contact-form {
            margin-top: 20px;
        }
        
        input[type="text"],
        textarea {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ddd;
            border-radius: 5px;
            box-sizing: border-box;
        }
        
        input[type="submit"] {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 12px 20px;
            border-radius: 5px;
            cursor: pointer;
        }
        
        input[type="submit"]:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>Contact Information</h2>
        <table>
            <tr>
                <th>Name</th>
                <td>Unknown</td>
            </tr>
            <tr>
                <th>Email</th>
                <td>ansaritour@09gmail.com</td>
            </tr>
            <tr>
                <th>Mobile No</th>
                <td>9089765432</td>
            </tr>
            <tr>
                <th>Address</th>
                <td>Delhi</td>
            </tr>
            <tr>
                <th>Office Hours</th>
                <td>Mon-Fri: 9am-5pm</td>
            </tr>
            <tr>
                <th>Social Media</th>
                <td>
                    <a href="#" target="_blank">Facebook</a>, 
                    <a href="#" target="_blank">Twitter</a>, 
                    <a href="#" target="_blank">Instagram</a>
                </td>
            </tr>
        </table>

        <div class="contact-form">
            <h2>Contact Us</h2>
            <form action="#" method="post">
                <input type="text" name="name" placeholder="Your Name" required>
                <input type="text" name="email" placeholder="Your Email" required>
                <textarea name="message" rows="5" placeholder="Your Message" required></textarea>
                <input type="submit" value="Send Message">
            </form>
        </div>
    </div>
</asp:Content>
