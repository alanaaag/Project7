<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffLogin.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Project7.Staff.StaffLogin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
    <h3>Staff Login</h3>
    <asp:Button ID="StaffLoginBackButton" runat="server" Text="Back" OnClick="StaffLoginBackButton_Click" />
    <br />
    <br />
    <p>Enter Username and Password to Login to get access to Staff Page.</p>
    <br />
        <p>Username: </p>
        <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox>
    <br />
        <p>Password: </p>
        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
    <br />
         <asp:Label ID="StatusLabel" runat="server" Text="LoginStatus"></asp:Label>
    <br />
    <br />
   </main>
</asp:Content>
