using System;
using System.Globalization;
using System.Windows.Forms;
using TimeConverter.Core;

namespace TimeConverter.WinFormsApp
{
    public partial class MainForm : Form
    {
        private const string DateTimeParseFormat = "dd/MM/yy hh:mm tt";
        private static readonly IFormatProvider ParseCulture = CultureInfo.InvariantCulture;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var now    = DateTime.Now;
            var utcNow = now.ToUniversalTime();

            SetDates(startTimeMelbTextBox, now, endTimeMelbTextBox, now);
            SetDates(startTimeUtcTextBox, utcNow, endTimeUtcTextBox, utcNow);
        }

        private void convertToUtcButton_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.ParseExact(startTimeMelbTextBox.Text, DateTimeParseFormat, ParseCulture);
            DateTime endTime   = DateTime.ParseExact(endTimeMelbTextBox.Text, DateTimeParseFormat, ParseCulture);

            SetDates(
                startTimeUtcTextBox, 
                ConverterEngine.ConvertMelbourneTimeToUtc(startTime),
                endTimeUtcTextBox,
                ConverterEngine.ConvertMelbourneTimeToUtc(endTime));
        }

        private void convertToMelbButton_Click(object sender, EventArgs e)
        {
            DateTime startTime = DateTime.ParseExact(startTimeUtcTextBox.Text, DateTimeParseFormat, ParseCulture);
            DateTime endTime = DateTime.ParseExact(endTimeUtcTextBox.Text, DateTimeParseFormat, ParseCulture);

            SetDates(
                startTimeMelbTextBox,
                ConverterEngine.ConvertUtcToMelbourneTime(startTime),
                endTimeMelbTextBox,
                ConverterEngine.ConvertUtcToMelbourneTime(endTime));
        }

        private void SetDates(TextBox startTextBox, DateTimeOffset startDate, TextBox endTextBox, DateTimeOffset endDate)
        {
            SetDates(startTextBox, startDate.DateTime, endTextBox, endDate.DateTime);
        }

        private void SetDates(TextBox startTextBox, DateTime startDate, TextBox endTextBox, DateTime endDate)
        {
            SetDates(
                startTextBox, 
                startDate.ToString(DateTimeParseFormat, ParseCulture),
                endTextBox,
                endDate.ToString(DateTimeParseFormat, ParseCulture));
        }

        private void SetDates(TextBox startTextBox, string startDate, TextBox endTextBox, string endDate)
        {
            startTextBox.Text = startDate;
            endTextBox.Text   = endDate;
        }
    }
}
