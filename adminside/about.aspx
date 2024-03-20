<%@ Page Title="" Language="C#" MasterPageFile="~/user2.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="adminside.about" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
            background-color: #f4f4f4;
        }
        
        .container {
            max-width: 800px;
            margin: 0 auto;
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
        
        td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2>About Us</h2>
        <table>
            <tr>
                <td>
                    <p>Welcome to our tour and travel agency! We specialize in providing unforgettable travel experiences to our customers.</p>
                    <p>Our mission is to make your travel dreams come true by offering exceptional service, personalized itineraries, and expert guidance.</p>
                    <p>With years of experience in the travel industry, we have established ourselves as a trusted partner for all your travel needs. Whether you're planning a relaxing beach getaway, an adventurous trekking expedition, or a cultural tour of exotic destinations, we've got you covered.</p>
                    <p>At our agency, we believe in creating memories that last a lifetime. Our team of dedicated professionals is committed to ensuring that every aspect of your journey is seamless and enjoyable.</p>
                    <p>Join us on an unforgettable journey and let us help you explore the world!</p>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
