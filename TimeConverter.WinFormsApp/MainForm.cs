using System;
using System.Globalization;
using System.Windows.Forms;
using TimeConverter.Core;

namespace TimeConverter.WinFormsApp
{
    public partial class MainForm : Form
    {
        private const string DateTimeParseFormat = "dd/MM/yy hh:mm tt";
        private const string Iso8601ParseFormat  = "yyyy-MM-ddTHH:mm:ss";

        private static readonly IFormatProvider ParseCulture = CultureInfo.InvariantCulture;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var startDate = DateTime.Today;
            var endDate   = startDate.AddHours(23).AddMinutes(59);

            SetDates(startTimeMelbTextBox, startDate, endTimeMelbTextBox, endDate);
            SetDates(startTimeUtcTextBox, startDate.ToUniversalTime(), endTimeUtcTextBox, endDate.ToUniversalTime(), Iso8601ParseFormat);
        }

        private void convertToUtcButton_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.ParseExact(startTimeMelbTextBox.Text, DateTimeParseFormat, ParseCulture);
            DateTime endTime   = DateTime.ParseExact(endTimeMelbTextBox.Text, DateTimeParseFormat, ParseCulture);

            SetDates(
                startTimeUtcTextBox, 
                ConverterEngine.ConvertMelbourneTimeToUtc(startTime),
                endTimeUtcTextBox,
                ConverterEngine.ConvertMelbourneTimeToUtc(endTime),
                Iso8601ParseFormat);
        }

        private void convertToMelbButton_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.ParseExact(startTimeUtcTextBox.Text, Iso8601ParseFormat, ParseCulture);
            DateTime endTime = DateTime.ParseExact(endTimeUtcTextBox.Text, Iso8601ParseFormat, ParseCulture);

            SetDates(
                startTimeMelbTextBox,
                ConverterEngine.ConvertUtcToMelbourneTime(startTime),
                endTimeMelbTextBox,
                ConverterEngine.ConvertUtcToMelbourneTime(endTime));
        }

        private void SetDates(TextBox startTextBox, DateTimeOffset startDate, TextBox endTextBox, DateTimeOffset endDate, string format = DateTimeParseFormat)
        {
            SetDates(startTextBox, startDate.DateTime, endTextBox, endDate.DateTime, format);
        }

        private void SetDates(TextBox startTextBox, DateTime startDate, TextBox endTextBox, DateTime endDate, string format)
        {
            SetDates(
                startTextBox, 
                startDate.ToString(format, ParseCulture),
                endTextBox,
                endDate.ToString(format, ParseCulture));
        }

        private void SetDates(TextBox startTextBox, string startDate, TextBox endTextBox, string endDate)
        {
            startTextBox.Text = startDate;
            endTextBox.Text   = endDate;
        }
    }
}
