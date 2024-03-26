using System;
using System.Windows.Controls;

namespace Kontoverwaltung
{
    public partial class RegisterUserControl : UserControl
    {
        private MainWindow parent;
        public RegisterUserControl(MainWindow parent)
        {
            this.parent = parent;
            InitializeComponent();
            PopulateDayComboBox();
            PopulateMonthComboBox();
            PopulateYearComboBox();
        }

        private void PopulateDayComboBox()
        {
            for (int day = 1; day <= 31; day++)
            {
                dayComboBox.Items.Add(day);
            }
        }

        private void PopulateMonthComboBox()
        {
            var months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
            foreach (string month in months)
            {
                if (!string.IsNullOrEmpty(month))
                {
                    monthComboBox.Items.Add(month);
                }
            }
        }

        private void PopulateYearComboBox()
        {
            int startYear = DateTime.Now.Year - 17;
            int endYear = startYear - 100;

            for (int year = startYear; year >= endYear; year--)
            {
                yearComboBox.Items.Add(year);
            }
        }

        private void ConfirmAge()
        {
            if (dayComboBox.SelectedItem == null || monthComboBox.SelectedItem == null || yearComboBox.SelectedItem == null)
                return; 

            DateTime selectedDate = new DateTime((int)yearComboBox.SelectedItem, monthComboBox.SelectedIndex + 1, (int)dayComboBox.SelectedItem);
            DateTime today = DateTime.Today;
            TimeSpan age = today - selectedDate;

            if (age.TotalDays / 365.25 < 18)
            {
                Console.WriteLine("Underage");
            }
            else
            {
                Console.WriteLine("Confirmed adult");
            }
        }
    }
}
