<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberLogin.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Project7.Member.MemberLogin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
    <h3>Login Authentication</h3>
    <asp:Button ID="MemberLoginBackButton" runat="server" Text="Back" OnClick="MemberLoginBackButton_Click" />
    <br />
    <br />
    <p>Enter Username and Password to access the page.</p>
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
