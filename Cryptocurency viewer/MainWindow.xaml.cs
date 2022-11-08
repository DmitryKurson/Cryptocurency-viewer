using Cryptocurency_viewer.ViewModel;
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

namespace Cryptocurency_viewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string theme = "light";
        public MainWindow()
        {
            
            InitializeComponent();
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            //AssetsWindow win = new AssetsWindow();
            //MainWindow win = new MainWindow();
            //win.WindowState = System.Windows.WindowState.Maximized;
            //win.WindowStyle = System.Windows.WindowStyle.None;
            //win.Show();

        }

        private void assets_btn_Click(object sender, RoutedEventArgs e)
        {
            AssetsWindow assetswindow_obj = new AssetsWindow(theme);
            assetswindow_obj.ShowDialog();
        }

        private void exchanges_btn_Click(object sender, RoutedEventArgs e)
        {
            ExchangesWindow exchangeswindow_obj = new ExchangesWindow(theme);
            exchangeswindow_obj.ShowDialog();
        }

        private void markets_btn_Click(object sender, RoutedEventArgs e)
        {
            MarketWindow marketwindow_obj = new MarketWindow(theme);
            marketwindow_obj.ShowDialog();
        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            ExitSure exit_sure_obj = new ExitSure(theme);
            exit_sure_obj.ShowDialog();
            //AssetsWindow assetswindow_obj = new AssetsWindow();
            //assetswindow_obj.ShowDialog();
        }

        private void change_color_theme_btn_Click(object sender, RoutedEventArgs e)
        {
            if (theme == "light")
            {
                theme = "dark";
                MainWindowGrid.Background = Brushes.DarkGray;
                assets_btn.Background = Brushes.DarkGray;
                exchanges_btn.Background = Brushes.DarkGray;
                markets_btn.Background = Brushes.DarkGray;
                change_color_theme_btn.Background = Brushes.DarkGray;
                exit_btn.Background = Brushes.DarkGray;
            }
            else if (theme == "dark")
            {
                theme = "light";
                MainWindowGrid.Background = Brushes.White;
                assets_btn.Background = Brushes.White;
                exchanges_btn.Background = Brushes.White;
                markets_btn.Background = Brushes.White;
                change_color_theme_btn.Background = Brushes.White;
                exit_btn.Background = Brushes.White;
            }
        }
    }
}
