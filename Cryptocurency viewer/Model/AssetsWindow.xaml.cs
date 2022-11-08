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
        public AssetsWindow()
        {
            InitializeComponent();
            Loaded += AssetsWindow_Loaded;
        }
        private void AssetsWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = new AssetsViewModel();
        }
    }
}
