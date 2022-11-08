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
    /// Interaction logic for ExitSure.xaml
    /// </summary>
    public partial class ExitSure : Window
    {
        public ExitSure(string theme)
        {
            InitializeComponent();
            if (theme == "light")
            {
                exit_sure_main_panel.Background = Brushes.White;
                yes_btn.Background = Brushes.White;
                no_btn.Background = Brushes.White;
                main_lbl.Background = Brushes.White;                
            }
            else if (theme == "dark")
            {
                exit_sure_main_panel.Background = Brushes.DarkGray;
                yes_btn.Background = Brushes.DarkGray;
                no_btn.Background = Brushes.DarkGray;
                main_lbl.Background = Brushes.DarkGray;
            }
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void yes_btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void no_btn_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
