<%@ Page Title="" Language="C#" MasterPageFile="~/user2.Master" AutoEventWireup="true" CodeBehind="dhbord2.aspx.cs" Inherits="adminside.dhbord2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .table {
            flex-wrap: wrap;
            justify-content: space-between;
        }
        .table th {
            text-align: center;
            width: 200px;
            padding: 10px; 
        }
        .ticket-button {
            background-color: #4CAF50; 
            border: none;
            color: white;
            padding: 10px 20px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 16px;
            margin: 4px 2px;
            cursor: pointer;
            border-radius: 5px;
            width: 100%; 
        }
        .quantity-dropdown {
            width: 20%;
            padding: 5px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="8" CssClass="table">
            <ItemTemplate>
                <table border="1">
                    <tr>
                        <th class="table th">
                            <img src='upload/<%#Eval("img")%>' height="150" width="200" alt="no image" />
                            <br /> 
                            Code: <asp:Literal ID="Literal1" runat="server" Text='<%#Eval("code")%>'></asp:Literal> <br />
                            Place: <%#Eval("nam") %> <br />
                           Price: <%#Eval("price") %>  / per<br />
                            Quantity: 
                            <asp:DropDownList ID="ddlQuantity" runat="server" CssClass="quantity-dropdown">
                                <asp:ListItem Text="1" Value="1"></asp:ListItem>
                                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                                <asp:ListItem Text="3" Value="3"></asp:ListItem>
                            </asp:DropDownList>
                   <asp:Button ID="Button1" runat="server" Text="Ticket Book" CssClass="ticket-button" OnClick="btncancel_Click" />
                        </th>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
