<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="category.aspx.cs" Inherits="adminside.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>
        Addd Categoy
    </h3>

    <table>
        <tr>
            <th>
                category
            </th>
            <td>
                <asp:TextBox ID="category" runat="server"></asp:TextBox>
            </td>  
        </tr>
        <tr>
            <th>
                <asp:Button ID="add_cat" runat="server" Text="Add"   OnClick="add_cat_Click"/></th>
        </tr>
         <tr>
            <th>
                <asp:Literal ID="Literal1" runat="server"></asp:Literal></th>
        </tr>

      </table>  

    <hr />
     <h3>Add Sub Category</h3>
    <table>  
        <tr>
            <th>
               category
            </th>
            <th>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></th>
            </tr>
        <tr>
            <td>sub category</td>
            <td>
                <asp:TextBox ID="subcategory" runat="server"></asp:TextBox>
            </td>  
        </tr>
           <tr>
            <th>
                <asp:Literal ID="Literal2" runat="server"></asp:Literal></th>
        </tr>
        <tr>
            <th>
                <asp:Button ID="sub_category" runat="server" Text="Add"  OnClick="sub_category_Click"/></th>
        </tr>








    </table>

    

</asp:Content>
