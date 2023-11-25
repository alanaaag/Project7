<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Project7.TryIt" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <h4>Operation: encryptData </h4>
        <p>Type: Local Componet</p>
        <p>Input: string data - Output: string encyptedString </p>
        <p>Description: This local componet encypts the inputed string </p>
        <p>This local componet will be used as a part of the user/staff registration process for assignment 7</p>

        <asp:TextBox ID="EncyptInput" runat="server">passwrd132</asp:TextBox>
        <asp:Button ID="EncyptButton" runat="server" Text="Encypt" OnClick="EncyptButton_Click" />
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


        <h4>Operation: AverageSunCalulation </h4>
        <p>Type: Web Service</p>
        <p>Input: string zipCode - Output: string numberOfHoursOfSun </p>
        <p>Description: This service will recieve a zipcode and the average number of hours of sun for the next 7 days based on weather forcast</p>
        <p>URL: http://webstrar25.fulton.asu.edu/page4/WeatherService.svc</p>

        <asp:TextBox ID="SunZipCodeInput" runat="server">85258</asp:TextBox>
        <asp:Button ID="CalulateHoursOfSunButton" runat="server" Text="Cacluate" OnClick="CalulateHoursOfSunButton_Click" />
        <br />
        <br>
        <asp:Label ID="HoursOfSunLabel" runat="server" Text="Hours of Sun (Next 7 Days):"></asp:Label>
        <asp:Label ID="HoursOfSunResultsLabel" runat="server" Text=""></asp:Label><br />
        <br>
    </main>
</asp:Content>
