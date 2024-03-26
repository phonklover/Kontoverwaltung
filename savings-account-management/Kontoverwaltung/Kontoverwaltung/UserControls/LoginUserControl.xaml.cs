using System.Windows;
using System.Windows.Controls;

namespace Kontoverwaltung
{
    public partial class LoginUserControl : UserControl
    {
        private MainWindow parent;
        public LoginUserControl(MainWindow parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void DeleteFromPersonalNumberField_Click(object sender, RoutedEventArgs e)
        {
            PersonalNumberField.Text = string.Empty;
        }

        private void DeleteFromPinField_Click(object sender, RoutedEventArgs e)
        {
            PinField.Password = string.Empty;
        }



    }
}