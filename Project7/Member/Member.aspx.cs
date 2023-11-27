using Project7.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Project7.Member
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LatLongButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client energyUnitConversion = new ServiceReference1.Service1Client();
            try { 
            string address = energyUnitConversion.ReturnZipByLatLong(LatTextBox.Text, LongTextBox.Text).ToString();
            LatLongResultLabel.Text = "Answer: " + address;
            } catch(Exception ex)
            {
                // IF ERROR OCCURS, DISPLAY ERROR MESSAGE
                LatLongResultLabel.Text = "An error has occured, please retry agian.";
            }
        }

        protected void CalculatorButton_Click(object sender, EventArgs e)
        {
            //CREATE SERVICE CLIENT
            WeatherService.ServiceClient service = new WeatherService.ServiceClient();
            ServiceReference2.Service1Client KwHservice = new ServiceReference2.Service1Client();

            try
            {
                // GET INPUT
                var input = ZipCodeTextBox.Text.ToString();

                // CALL SERVICE
                string result = service.AverageSunCalulation(input);

                // SET RESULT TO HAZARD INDEX RESULT
                WeatherServiceLabel.Text = result.ToString();

                double KiloWattPerHour = KwHservice.KwHValue(Double.Parse(NumSolarPanelsTextBox.Text));

                NumberOfSolarPanelLabel.Text = KiloWattPerHour.ToString();

                PotentialSolarGeneratedLabel.Text = (Double.Parse(result) * KiloWattPerHour).ToString();

            }
            catch (Exception ex)
            {
                // IF ERROR OCCURS, DISPLAY ERROR MESSAGE
                PotentialSolarGeneratedLabel.Text = "An error has occured, please retry agian.";
            }
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }
    }
}