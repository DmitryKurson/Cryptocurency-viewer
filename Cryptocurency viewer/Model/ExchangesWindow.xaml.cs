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
    /// Interaction logic for Exchanges.xaml
    /// </summary>
    public partial class ExchangesWindow : Window
    {
        public ExchangesWindow(string theme)
        {
            InitializeComponent();
            if (theme == "dark")
            {
                exchange_window.Background = Brushes.DarkGray;
                EW_filter_lbl.Background = Brushes.DarkGray;
                EW_textbox.Background = Brushes.DarkGray;
                EW_datagrid.Background = Brushes.DarkGray;
            }
            else if (theme == "light")
            {
                exchange_window.Background = Brushes.White;
                EW_filter_lbl.Background = Brushes.White;
                EW_textbox.Background = Brushes.White;
                EW_datagrid.Background = Brushes.White;
            }
            Loaded += ExchangesWindow_Loaded;
        }

        private void ExchangesWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new ExchangesViewModel();
        }
    }
}
