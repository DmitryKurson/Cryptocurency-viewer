using Cryptocurency_viewer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Cryptocurency_viewer.ViewModel
{
    class ExchangesViewModel:DependencyObject
    {
        public int FilterText
        {
            get { return (int)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(ExchangesViewModel), new PropertyMetadata(""));

        public ICollectionView ExchangesItems
        {
            get { return (ICollectionView)GetValue(ExchangesItemProperty); }
            set { SetValue(ExchangesItemProperty, value); }
        }
        public static readonly DependencyProperty ExchangesItemProperty =
            DependencyProperty.Register("ExchangesItems", typeof(ICollectionView), typeof(ExchangesViewModel), new PropertyMetadata(0));

        public ExchangesViewModel()
        {
            ExchangesItems = CollectionViewSource.GetDefaultView(Exchanges.GetExchanges());
        }
    }
}
 