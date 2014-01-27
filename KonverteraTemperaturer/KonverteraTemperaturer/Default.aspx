<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KonverteraTemperaturer.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/app.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrapper">
            <h1>Konvertera temperaturer</h1>
            <p>
                <asp:Label ID="LabelStartTemp" runat="server" Text="Starttemperatur"></asp:Label>
                <asp:TextBox ID="TextBoxStartTemp" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator
                    ID="RequiredStartTempValidator"
                    ControlToValidate="TextBoxStartTemp"
                    runat="server"
                    ErrorMessage="Fyll i en starttemperatur."
                    Text="*"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator
                    ID="CompareStartTempValidator"
                    runat="server"
                    ControlToValidate="TextBoxStartTemp"
                    Type="Integer" 
                    Operator="DataTypeCheck"
                    ErrorMessage="Fyll i ett heltal."
                    Text="*"
                    Display="Dynamic">
                </asp:CompareValidator>
            </p>
            <p>
                <asp:Label ID="LabelEndTemp" runat="server" Text="Sluttemperatur"></asp:Label>
                <asp:TextBox ID="TextBoxEndTemp" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator
                    ID="RequiredEndTempValidator"
                    ControlToValidate="TextBoxEndTemp"
                    runat="server"
                    ErrorMessage="Fyll i sluttemperatur."
                    Text="*"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator
                    ID="CompareEndTempValidator"
                    runat="server"
                    ControlToValidate="TextBoxEndTemp"
                    Type="Integer" Operator="GreaterThan"
                    ControlToCompare="TextBoxStartTemp"
                    ErrorMessage="Fyll i en sluttemperatur större än starttemperaturen."
                    Text="*"
                    Display="Dynamic">
                </asp:CompareValidator>
            </p>
            <p>
                <asp:Label ID="LabelTempStep" runat="server" Text="Temperatursteg"></asp:Label>
                <asp:TextBox ID="TextBoxTempStep" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator
                    ID="RequiredTempStepValidator"
                    ControlToValidate="TextBoxTempStep"
                    runat="server"
                    ErrorMessage="Fyll i ett temperatursteg."
                    Text="*"
                    Display="Dynamic">
                </asp:RequiredFieldValidator>
                <asp:RangeValidator 
                    ID="RangeTempStepValidator"
                    runat="server"
                    ControlToValidate="TextBoxTempStep"
                    Type="Integer"
                    MinimumValue="0"
                    MaximumValue="100"
                    ErrorMessage="Fyll i temperatursteget så att det är ett heltal mellan 1 och 100."
                    Text="*"
                    Display="Dynamic">
                </asp:RangeValidator>
            </p>
            <p>
                <asp:Label ID="LabelTypeOfConversion" runat="server" Text="Typ av konvertering"></asp:Label>
            </p>
            <p>
                <asp:RadioButton ID="RadioButtonCelcius" Checked="true" GroupName="TypeOfConversion" Text="Celsius till Fahrenheit" runat="server" />
            </p>
            <p>
                <asp:RadioButton ID="RadioButtonFahrenheit" GroupName="TypeOfConversion" Text="Fahrenheit till Celsius" runat="server" />
            </p>

            <p>
                <asp:Button ID="ButtonConvert" runat="server" Text="Konvertera" OnClick="ButtonConvert_Click" />
            </p>
            <asp:ValidationSummary
                ID="errorList"
                DisplayMode="BulletList"
                EnableClientScript="true"
                HeaderText="Fel inträffade. Åtgärda felen och försök igen."
                runat="server" />

            <asp:Table ID="Table1" border="1" runat="server"></asp:Table>

        </div>
    </form>
</body>
</html>
