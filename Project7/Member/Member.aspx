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
          <asp:Button ID="LatLongButton" runat="server" Text="Get Zip Code" OnClick="LatLongButton_Click" />
          <asp:Label ID="LatLongResultLabel" runat="server" Text="Result:"></asp:Label>
          <hr />
          <asp:Label ID="ZipCodeLabel" runat="server" Text="Zip Code: "></asp:Label>
          <asp:TextBox ID="ZipCodeTextBox" runat="server"></asp:TextBox>
          <br />
          <asp:Label ID="NumSolarPanelsLabel" runat="server" Text="Number of Solar Panels: "></asp:Label>
          <asp:TextBox ID="NumSolarPanelsTextBox" runat="server"></asp:TextBox>
          <br />
          <asp:Button ID="CalculatorButton" runat="server" Text="Calculate Solar Energy Generated" OnClick="CalculatorButton_Click" />
          <br />
          <br />
          <asp:Label ID="WeatherServiceResultLabel" runat="server" Text="Average number of hours of sun in next 5 days : "></asp:Label>
          <asp:Label ID="WeatherServiceLabel" runat="server" Text=""></asp:Label>
          <br />
          <br />
          <asp:Label ID="NumberOfSolarPanelResultLabel" runat="server" Text="KwH of Solar Panels : "></asp:Label>
          <asp:Label ID="NumberOfSolarPanelLabel" runat="server" Text=""></asp:Label>
          <br />
          <br />
          <asp:Label ID="PotentialSolarGeneratedResultLabel" runat="server" Text="Potential Energy generated in next 5 days (KwH) : "></asp:Label>
          <asp:Label ID="PotentialSolarGeneratedLabel" runat="server" Text=""></asp:Label>
      </main>
    </asp:Content>