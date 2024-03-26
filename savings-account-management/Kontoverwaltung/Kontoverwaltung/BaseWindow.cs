using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Kontoverwaltung
{
    public class BaseWindow : Window
    {
        private Stack<UserControl> navigationHistory = new Stack<UserControl>();

        public BaseWindow()
        {

        }

        public void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 1)
            {
                this.DragMove();
            }
            else if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                AdjustWindowState();
            }
        }

        public void AdjustWindowState()
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        public void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        public void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        public void NavigateTo(UserControl page)
        {
            navigationHistory.Push(page);
            Content = page;
        }

        public void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (navigationHistory.Count > 1)
            {
                navigationHistory.Pop();
                UserControl previousPage = navigationHistory.Peek();
                Content = previousPage;
            }
        }
    }
}
