using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KonverteraTemperaturer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonConvert_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int startTemp;
                int endTemp;
                int tempStep;

                startTemp = Int32.Parse(TextBoxStartTemp.Text);
                endTemp = Int32.Parse(TextBoxEndTemp.Text);
                tempStep = Int32.Parse(TextBoxTempStep.Text);

                Table1.Visible = true;

                if (!RadioButtonCelcius.Checked)
                {
                    First.Text = "°F";
                    Second.Text = "°C";
                }

                for (int j = startTemp; j <= endTemp; j += tempStep)
                {
                    TableRow row = new TableRow();
                    TableCell cell = new TableCell();
                    TableCell cell2 = new TableCell();

                    cell.Text = String.Format("{0}", j);
                    cell2.Text = String.Format("{0:f0}",
                        RadioButtonCelcius.Checked ? Model.TemperatureConverter.CelsiusToFahrenheit(j) :
                        Model.TemperatureConverter.FahrenheitToCelsius(j));

                    row.Cells.Add(cell);
                    row.Cells.Add(cell2);
                    Table1.Rows.Add(row);
                }
            }
        }
    }
}