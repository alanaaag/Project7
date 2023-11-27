<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CookieSessionTryIt.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Project7.Cookie.CookieSessionTryIt" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <h3>Try it Page for Cookies and Session Storage</h3>
        <asp:Label runat="server" Text="Click on the button to fetch data stored in the cookie"></asp:Label>
        <asp:Button ID="getCookieDataButton" runat="server" Text="Get Cookie Data" OnClick="getCookieDataButton_Click" />
        <br />
        <br />
        <asp:Label ID="CookieDataLabel" runat="server" Text="Cookie Data:"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label runat="server" Text="Click on the button to fetch data stored in the session storage"></asp:Label> 
        <asp:Button ID="getSessionStorageDataButton" runat="server" Text="Get Session Storage Data" OnClick="getSessionStorageDataButton_Click" />
        <br />
        <br />
        <asp:Label ID="SessionStorageDataLabel" runat="server" Text="Session Storage Data:"></asp:Label>
   </main>
</asp:Content>