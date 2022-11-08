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
    /// Interaction logic for AssetsWindow.xaml
    /// </summary>
    public partial class AssetsWindow : Window
    {
        public AssetsWindow(string theme)
        {
            InitializeComponent();
            if (theme == "dark")
            {
                assets_window.Background = Brushes.DarkGray;
                AW_filter_lbl.Background = Brushes.DarkGray;
                AW_textbox.Background = Brushes.DarkGray;   
                AW_datagrid.Background = Brushes.DarkGray;
            }
            else if (theme == "light")
            {
                assets_window.Background = Brushes.White;
                AW_filter_lbl.Background = Brushes.White;
                AW_textbox.Background = Brushes.White;
                AW_datagrid.Background = Brushes.White;
            }            
            Loaded += AssetsWindow_Loaded;
        }
        private void AssetsWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new AssetsViewModel();
        }
    }
}
