using System.Windows;
using System.Windows.Controls;

namespace Kontoverwaltung.UserControls
{
    public partial class MainUserControl : UserControl
    {
        private MainWindow parent;
        public MainUserControl(MainWindow parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            parent.SetUserControl(new LoginUserControl(parent));
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            parent.SetUserControl(new RegisterUserControl(parent));
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            parent.SetUserControl(new HelpUserControl(parent));
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            parent.CloseButton_Click(sender, e);
        }

    }
}