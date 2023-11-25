<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberReg.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Project7.Member.MemberReg" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
    <h3>Member Registration</h3>
    <asp:Button ID="MemberRegBackButton" runat="server" Text="Back" OnClick="MemberRegBackButton_Click" />
    <br />
    <br />
    <p>Enter Username and Password to register as a New Member.</p>
    <br />
        <p>Username: </p>
        <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox>
    <br />
        <p>Password: </p>
        <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
    <br />
        <asp:Image ID="CaptchaImage" runat="server" />
    <br />
    <br />
        <p>Please enter the above text.</p>
        <asp:TextBox ID="CaptchaTextBox" runat="server"></asp:TextBox>
    <br />
        <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
    <br />
        <asp:Label ID="StatusLabel" runat="server" Text="RegStatus"></asp:Label>
   </main>
</asp:Content>
