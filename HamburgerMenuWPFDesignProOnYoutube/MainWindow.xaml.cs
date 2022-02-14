using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HamburgerMenuWPFDesignProOnYoutube
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Move / Drag the window
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }
        private void ChangeWindowState()
        {
            if (WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
                Window_Edge.Visibility = Visibility.Collapsed;
            }
            else
            {
                if (WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Normal;
                    Window_Edge.Visibility = Visibility.Visible;
                }
            }
        }
        // Change Window State on Left Mouse Button Double Click.
        private void Main_Window_Panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                ChangeWindowState();
            }
        }
    }
}
