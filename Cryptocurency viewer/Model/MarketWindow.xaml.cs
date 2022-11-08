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
using System.Windows.Shapes;

namespace Cryptocurency_viewer
{
    /// <summary>
    /// Interaction logic for MarketWindow.xaml
    /// </summary>
    public partial class MarketWindow : Window
    {
        public MarketWindow(string theme)
        {
            InitializeComponent();
            if (theme == "dark")
            {
                market_window.Background = Brushes.DarkGray;
                MW_filter_lbl.Background = Brushes.DarkGray;
                MW_textbox.Background = Brushes.DarkGray;
                MW_datagrid.Background = Brushes.DarkGray;
            }
            else if (theme == "light")
            {
                market_window.Background = Brushes.White;
                MW_filter_lbl.Background = Brushes.White;
                MW_textbox.Background = Brushes.White;
                MW_datagrid.Background = Brushes.White;
            }
            Loaded += MarketWindow_Loaded;
        }

        private void MarketWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new MarketViewModel();
        }
    }
}
