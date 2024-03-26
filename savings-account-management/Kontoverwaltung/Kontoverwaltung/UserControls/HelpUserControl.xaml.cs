using System.Windows;
using System.Windows.Controls;

namespace Kontoverwaltung
{
    public partial class HelpUserControl : UserControl
    {
        private MainWindow parent;
        public HelpUserControl(MainWindow parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
    }
}