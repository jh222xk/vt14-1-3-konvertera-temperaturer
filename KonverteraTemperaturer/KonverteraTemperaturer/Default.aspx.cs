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

                if (RadioButtonCelcius.Checked)
                {
                    TableHeaderRow tableHeaderRowCelsius = new TableHeaderRow();
                    TableHeaderCell tableHeaderCellCelsius = new TableHeaderCell();
                    TableHeaderCell tableHeaderCellFahrenheit = new TableHeaderCell();

                    tableHeaderCellCelsius.Text = "°C";

                    tableHeaderRowCelsius.Cells.Add(tableHeaderCellCelsius);

                    tableHeaderCellFahrenheit.Text = "°F";

                    tableHeaderRowCelsius.Cells.Add(tableHeaderCellFahrenheit);

                    Table1.Rows.Add(tableHeaderRowCelsius);

                    for (int j = startTemp; j <= endTemp; j += tempStep)
                    {
                        TableRow row = new TableRow();
                        TableCell cell = new TableCell();
                        TableCell cell2 = new TableCell();

                        cell.Text = String.Format("{0}", j);
                        cell2.Text = String.Format("{0}", Model.TemperatureConverter.CelsiusToFahrenheit(j));

                        row.Cells.Add(cell);
                        row.Cells.Add(cell2);
                        Table1.Rows.Add(row);

                    }
                }
                else if (RadioButtonFahrenheit.Checked)
                {
                    TableHeaderRow tableHeaderRowFahrenheit = new TableHeaderRow();
                    TableHeaderCell tableHeaderCellCelsius = new TableHeaderCell();
                    TableHeaderCell tableHeaderCellFahrenheit = new TableHeaderCell();

                    tableHeaderCellFahrenheit.Text = "°F";

                    tableHeaderRowFahrenheit.Cells.Add(tableHeaderCellFahrenheit);

                    tableHeaderCellCelsius.Text = "°C";

                    tableHeaderRowFahrenheit.Cells.Add(tableHeaderCellCelsius);
                    
                    Table1.Rows.Add(tableHeaderRowFahrenheit);

                    for (int j = startTemp; j <= endTemp; j +=tempStep)
                    {
                        TableRow row = new TableRow();
                        TableCell cell = new TableCell();
                        TableCell cell2 = new TableCell();

                        cell.Text = String.Format("{0}", j);
                        cell2.Text = String.Format("{0}", Model.TemperatureConverter.FahrenheitToCelsius(j));

                        row.Cells.Add(cell);
                        row.Cells.Add(cell2);

                        Table1.Rows.Add(row);
                    
                    }
                }

                
            }
        }
    }
}