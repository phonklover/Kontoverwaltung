using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Kontoverwaltung.UserControls;

namespace Kontoverwaltung
{
    public partial class MainWindow : BaseWindow
    {

        public void SetUserControl(UserControl newUserControl)
        {
            this.contentControl.Content = newUserControl;
        }
        
        public MainWindow()
        {
            InitializeComponent();
            SetUserControl(new MainUserControl(this));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
