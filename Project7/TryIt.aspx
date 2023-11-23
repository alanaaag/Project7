<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Project7.TryIt" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
  <h4>Operation: encryptData </h4>
  <p>Type: Local Componet</p>
  <p>Input: string data - Output: string encyptedString </p>
  <p>Description: This local componet encypts the inputed string </p>
  <p>This local componet will be used as a part of the user/staff registration process for assignment 7</p>

  <asp:TextBox ID="EncyptInput" runat="server">passwrd132</asp:TextBox>
  <asp:Button ID="EncyptButton" runat="server" Text="Encypt" OnClick="EncyptButton_Click"/>
  <br />
  <br>
  <asp:Label ID="EncyptLabel" runat="server" Text="Result:"></asp:Label>
  <asp:Label ID="EncyptResult" runat="server" Text=""></asp:Label><br />
  <br>

  <h4>Operation: decryptData </h4>
  <p>Type: Local Componet</p>
  <p>Input: string data - Output: string decyptedString </p>
  <p>Description: This local componet decypts the inputed string </p>
  <p>This local componet will be used as a part of the user/staff login process for assignment 7</p>

  <asp:TextBox ID="DecyptInput" runat="server">d3xpsVFZrTdyS9IGVutp9Q==</asp:TextBox>
  <asp:Button ID="DecyptButton" runat="server" Text="Decypt" OnClick="DecyptButton_Click" />

  <br />

  <br>
  <asp:Label ID="DecyptLabel" runat="server" Text="Result:"></asp:Label>
  <asp:Label ID="DecyptResult" runat="server" Text=""></asp:Label><br />
  <br>

    </main>
</asp:Content>