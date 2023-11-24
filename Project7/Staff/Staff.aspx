<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Project7.Staff.Staff" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <asp:Button ID="DefaultPageButton" runat="server" Text="Home" OnClick="DefaultPageButton_Click" /><br /><br />
        <h3>View Staff:</h3>
<p>Click the 'View Staff List' to view the current staff members</p>
<asp:Button ID="StaffButton" runat="server" Text="View Staff List" OnClick="StaffButton_Click"/>
<br />
<asp:Label ID="StaffResult" runat="server"></asp:Label>
<hr />
<h3>Add New Staff </h3>
<p>Enter staff members credetials, then click 'Add Staff', password will be encrypted</p>
<table style="width: 100%;">
    <tr>
        <td>
            <asp:Label ID="UserLabel" runat="server" Text="User"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="StaffUserInput" runat="server"></asp:TextBox>

        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="StaffPasswordInput" TextMode="Password" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
<asp:Button ID="AddStaffUser" runat="server" Text="Add Staff" OnClick="AddStaffUser_Click"/>
 <asp:Label ID="AddStaffStatus" runat="server"></asp:Label>
    </main>
</asp:Content>