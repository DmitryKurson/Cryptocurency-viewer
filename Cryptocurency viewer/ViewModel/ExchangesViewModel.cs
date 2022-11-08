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
    class ExchangesViewModel : DependencyObject
    {
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(ExchangesViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as ExchangesViewModel;
            if (current != null)
            {
                current.ExchangesItems.Filter = null;
                current.ExchangesItems.Filter = current.FilterExchanges;
            }
        }

        public ICollectionView ExchangesItems
        {
            get { return (ICollectionView)GetValue(ExchangesItemsProperty); }
            set { SetValue(ExchangesItemsProperty, value); }
        }
        public static readonly DependencyProperty ExchangesItemsProperty =
            DependencyProperty.Register("ExchangesItems", typeof(ICollectionView), typeof(ExchangesViewModel), new PropertyMetadata(null));

        public ExchangesViewModel()
        {
            ExchangesItems = CollectionViewSource.GetDefaultView(Exchanges.GetExchanges());
            ExchangesItems.Filter = FilterExchanges;
        }

        private bool FilterExchanges(object obj)
        {
            bool result = true;
            Exchanges current = obj as Exchanges;
            if (!string.IsNullOrWhiteSpace(FilterText) && current != null && !current.exchange_id.Contains(FilterText) && !current.name.Contains(FilterText) && !current.website.Contains(FilterText) && !current.volume_24h.Contains(FilterText))
            {
                result = false;
            }
            return result;
        }
    }
}
 