<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project7._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        table, th, td {
            border: 1px solid black;
        }
    </style>
    <main>
        <asp:Button ID="MemberLoginButton" runat="server" Text="Member Login" />
        <asp:Button ID="MemberPageButton" runat="server" Text="Member Page" OnClick="MemberPageButton_Click" />
        <asp:Button ID="MemberRegistrationButton" runat="server" Text="Member Registration" />
        <asp:Button ID="StaffLoginButton" runat="server" Text="Staff Login" />
        <asp:Button ID="StaffPageButton" runat="server" Text="Staff Page" OnClick="StaffPageButton_Click" />

        <h1>Application Description</h1>
        <h2>Energy Calculator Web Service</h2>
        <p>This web application service provides an energy-related calculation and utility to assist users in making informed decisions about their energy consumption and cost.</p>
        <p>The calucation/utility service uses the following componets to calculate energy cost savings based on solar weather conditions, capacity of solar array and current electricy cost based on location provided.</p>
        <p>Please navigate to the member page to utilize this utility or navigate to the member registration to sign up.</p>
        <hr />

        <h1>Application Testing Instructions</h1>
        <br>
        <h2>Default Page</h2>
        <ul>
            <li>If the user wishes to register to be a member, they should navigate to the "Member Registration" page. There they will be asked to enter a username and password and to be verified via CAPTCHA. If the username already exists, the user will have to navigate to the "Member Login" page. </li>
            <li>If the user wishes to log in as a member, they should navigate to the "Member Login" page. There they will be asked to enter their username and password. If their login information is correct, they will be navigated to the "Member Page".</li>
            <li>If the user wishes to log in as "staff", they should navigate to the "Staff Login" page. There they will be asked to enter their username and password. If their login information is saved in the Staff database, they will be navigated to the "Staff Page". </li>
        </ul>
        <br />
        <h2>Member Page</h2>
        <ul>
            <li>If the user needs to get their zip code from their lat/long. They can use the first section of the page to input their lat/long click the submit button and receive their corresponding zip code.</li>
            <li>To calculate their solar usage savings, The user will enter their zipcode, number of solar panels and they will receive information on the cost of savings the solar array produces that week.</li>
            <li>Additional information on how that cacluation will be displayed.</li>
        </ul>
        <br />
        <h2>Staff Page</h2>
        <ul>
            <li>Requires valid username and password for access.</li>
            <li>Logged in staff can display existing users in the staff xml file by clicking the 'View Staff List' button.
            <li>The Staff Page provides input fields for entering a new staff member's username and password.</li>
            <li>Upon clicking the submit button, the credentials are encrypted and added to the Staff.XML file.</li>
            <li>The newly added user can then access the Staff Page.</li>
            <br>
            <p><b>Default Staff Account:</b></p>
            <li>A pre-configured staff account exists for the TA/grader/tester.</li>
            <li>Username: "TA"</li>
            <li>Password: "Cse44598!"</li>
        
        </ul>
        <hr />

        <table style="width: 100%; text-align: center;">
            <tr>
                <td>
                    <h2>Application and Componets Summary: Team 25 </h2>
                </td>
            </tr>
            <tr>
                <td><b>This page is at: <a href="http://webstrar25.fulton.asu.edu/index.html">http://webstrar25.fulton.asu.edu/index.html</a> </b></td>
            </tr>
            <tr>
                <td>Percentage of contribution: <b>Kshitij</b> : 33.33%, <b>Jay</b> : 33.33%, <b>Alana</b>: 33.33% </td>
            </tr>
        </table>
        <table>
            <tr>
                <th>Provider Name</th>
                <th>Page/Component Type</th>
                <th>Component/Service Description</th>
                <th>Resources/Methods used to implement component</th>
                <th>Where component is used</th>
                <th>Try It Link</th>
            </tr>
            <tr>
                <td>Jay Parker</td>
                <td>DLL</td>
                <td>Encryption Library, used to encypt and decrypt data </td>
                <td>This library will be used with 'Member' and 'Staff' registration process for storing passwords encrypted<br />
                    This library will also be used to verify user/staff login creditials </td>
                <td>Will be used on the 'Members' and 'Staff' pages, can be tested via TryIt link or Mock Staff page via viewing or adding a staff functionality</td>
                <td>
                    <a href="http://webstrar25.fulton.asu.edu/page3/TryIt">TryIt</a><br />
                    <br />
                    <a href="http://webstrar25.fulton.asu.edu/page3/Staff">Mockup Staff Page</a>
                </td>
            </tr>
            <tr>
                <td>Jay Parker</td>
                <td>XML File</td>
                <td>Store User and Passwords for Staff</td>
                <td>Staff data is stored in an xml within the AppData folder</td>
                <td>Will be used 'Staff' page, can be tested via TryIt link or Mock Staff page via viewing or adding a staff functionality</td>
                <td>
                    <a href="http://webstrar25.fulton.asu.edu/page3/Staff">Mockup Staff Page</a>
                </td>
            </tr>
            <tr>
                <td>Jay Parker</td>
                <td>Web Service</td>
                <td><b>* Average Sun Calculator Service</b>
                    <br />
                    * This service will recieve a zipcode and the average number of hours of sun for the next 7 days based on weather forcast -
                    <br>
                    * Input: string zipCode - Output: string numberOfHoursOfSun
                </td>
                <td>* Intergrations with WSDL/RESTful services<br />
                    * Pulls and filters the data needed for # of hours sun is present<br />
                    https://geocode.maps.co/
                    <br />
                    https://api.weather.gov/</td>
                <td>Will be used on the 'Default' or 'Members' (pending), can be tested via TryIt link</td>
                <td><a href="http://webstrar25.fulton.asu.edu/page3/TryIt">TryIt</a></td>
            </tr>
            <tr>
                <td>Jay Parker</td>
                <td>Web Service</td>
                <td><b>* Average Wind Speed Calculator Service</b><br />
                    * This service will recieve a zipcode and the average windspeed for the next 7 days based on weather forcast<br />
                    * Input: string zipCode - Output: string avgWindSpeed
                </td>
                <td>* Intergrations with WSDL/RESTful services<br />
                    * Pulls and filters the data needed for # of hours wind is present
                    <br />
                    https://geocode.maps.co/
                    <br />
                    https://api.weather.gov/</td>
                <td>Will be used on the 'Default' or 'Members' (pending), can be tested via TryIt link</td>
                <td><a href="http://webstrar25.fulton.asu.edu/page3/TryIt">TryIt</a></td>
            </tr>
            <tr>
                <td>Kshitij Dhyani</td>
                <td>Event Handler in Global.asax File</td>
                <td>Sets application-wide settings and variables in the Global.asax file. These settings can be accessed by all parts of your application.</td>
                <td>This uses the Application_Start event handler in the Global.asax file to set application-wide configurations.</td>
                <td>This code will be used with 'Public', 'Member' and 'Staff' pages to provide base configuration settings to the web application.</td>
                <td>
                    <a href="http://webstrar25.fulton.asu.edu/page2/">Test</a><br />
                    <br />
                </td>
            </tr>
            <tr>
                <td>Kshitij Dhyani</td>
                <td>Cookie and Session State Storage</td>
                <td>Stores Light and Dark Theme perference for user as a cookie, and notification perference as a session state.</td>
                <td>This uses the Session State Storage and Cookies provided by the Request.Cookies collection in ASP.NET</td>
                <td>This code will be used with 'Public', 'Member' and 'Staff' pages to provide user preferences stored as cookies or session storage.</td>
                <td>
                    <a href="http://webstrar25.fulton.asu.edu/page2/">Test</a><br />
                    <br />
                </td>
            </tr>
            <tr>
                <td>Kshitij Dhyani</td>
                <td>Web Service</td>
                <td>Energy in kW to convert to MW or Enter Energy in MW to convert to kW - Energy Service - Give energy in converted unit (kW/MW)</td>
                <td>https://www.rapidtables.com/convert/power/kw-to-megaw.html</td>
                <td>Will be used on the 'Default' or 'Members' (pending), can be tested via TryIt link</td>
                <td><a href="http://webstrar25.fulton.asu.edu/page2/">TryIt</a></td>
            </tr>
            <tr>
                <td>Kshitij Dhyani</td>
                <td>Web Service</td>
                <td>Get Zip and Address based on Latitude and Longitude - Geo Coding - Energy Service - Get address based on Lat/Long</td>
                <td>https://geocode.maps.co/</td>
                <td>Will be used on the 'Default' or 'Members' (pending), can be tested via TryIt link</td>
                <td><a href="http://webstrar25.fulton.asu.edu/page2/">TryIt</a></td>
            </tr>
            <tr>
                <td>Kshitij Dhyani</td>
                <td>Web Service</td>
                <td>Get Full address based on Zip - Reverse Geo Coding - Energy Service - Get Full address based on Zip</td>
                <td>https://geocode.maps.co/</td>
                <td>Will be used on the 'Default' or 'Members' (pending), can be tested via TryIt link</td>
                <td><a href="http://webstrar25.fulton.asu.edu/page2/">TryIt</a></td>
            </tr>
            <tr>
                <td>Alana Gregorio</td>
                <td>User Control</td>
                <td>Captcha Verification used to verify users at login</td>
                <td>This method will be used with 'Member' and 'Staff' registration and login to verify the user</td>
                <td>Will be used on the 'Members' and 'Staff' pages, can be tested via TryIt Link or Mock Members Sign Up Page</td>
                <td>
                    <a href="http://webstrar25.fulton.asu.edu/page6/TryIt">TryIt</a><br />
                    <br />
                    <a href="http://webstrar25.fulton.asu.edu/page6/Member">Mockup Member Page</a>
                </td>
            </tr>
            <tr>
                <td>Alana Gregorio</td>
                <td>XML File</td>
                <td>Store Username and Passwords for Members</td>
                <td>Member Data is stored in an XML file within the App_Data file</td>
                <td>Will be used as 'Member' page, can be tested via Mock Member Page for signing up to be a member and Captcha verification</td>
                <td>
                    <a href="http://webstrar25.fulton.asu.edu/page6/Member">Mockup Member Page</a>
                </td>
            </tr>

            <tr>
                <td>Alana Gregorio</td>
                <td>Web Service</td>
                <td>Get Average kW/H based on number of solar panels</td>
                <td>https://www.forbes.com/home-improvement/solar/how-much-power-does-a-solar-panel-produce/#:~:text=Average%20Solar%20Panel%20Production,-The%20average%20solar&text=On%20average%2C%20a%20standard%20residential,(kWh)%20of%20electricity%20annually</td>
                <td>Will be used on 'Default' and 'Members' pages, can be tested via TryIt link</td>
                <td>
                    <a href="http://webstrar25.fulton.asu.edu/page6/TryIt">TryIt</a><br />
                    <br />
                </td>
            </tr>
        </table>

    </main>

</asp:Content>
