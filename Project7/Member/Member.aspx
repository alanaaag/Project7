<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Project7.Member.Member" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <main>
        <h1>Member Page</h1>
          <h2>Description</h2>
          <ul>
            <li>If the user needs to get their zip code from their lat/long. They can use the first section of the page to input their lat/long click the submit button and receive their corresponding zip code.</li>
            <li>To calculate their solar usage savings, The user will enter their zipcode, number of solar panels and they will receive information on the cost of savings the solar array produces that week.</li>
            <li>Additional information on how that cacluation will be displayed.</li>
          </ul>
          <ul>
              <li>Location Service</li>
              <li>Average Sun Calculator Service</li>
              <li>Average kW/H Service</li>
              <li>Cost Calculator Service</li>
          </ul>
          <hr />
          <asp:Label ID="LatLabel" runat="server" Text="Lat: ">
          </asp:Label> <asp:TextBox ID="LatTextBox" runat="server"></asp:TextBox>
          <br />
          <asp:Label ID="LongLabel" runat="server" Text="Long: "></asp:Label>
          <asp:TextBox ID="LongTextBox" runat="server"></asp:TextBox>
          <br />
          <asp:Button ID="LatLongButton" runat="server" Text="Get Zip Code" />

          <hr />
          <asp:Label ID="ZipCodeLabel" runat="server" Text="Zip Code: "></asp:Label>
          <asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox>
          <br />
          <asp:Label ID="NumSolarPanelsLabel" runat="server" Text="Number of Solar Panels: "></asp:Label>
          <asp:TextBox ID="NumSolarPanelsTextBox" runat="server"></asp:TextBox>
          <br />
          <asp:Button ID="CalculatorButton" runat="server" Text="Calculate Solar Cost Savings" />



      </main>
    </asp:Content>