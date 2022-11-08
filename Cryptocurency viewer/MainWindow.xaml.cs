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
            AssetsWindow assetswindow_obj = new AssetsWindow();
            assetswindow_obj.ShowDialog();
        }

        private void exchanges_btn_Click(object sender, RoutedEventArgs e)
        {
            ExchangesWindow exchangeswindow_obj = new ExchangesWindow();
            exchangeswindow_obj.ShowDialog();
        }

        private void markets_btn_Click(object sender, RoutedEventArgs e)
        {
            MarketWindow marketwindow_obj = new MarketWindow();
            marketwindow_obj.ShowDialog();
        }

        private void exit_btn_Click(object sender, RoutedEventArgs e)
        {
            //AssetsWindow assetswindow_obj = new AssetsWindow();
            //assetswindow_obj.ShowDialog();
        }
    }
}
