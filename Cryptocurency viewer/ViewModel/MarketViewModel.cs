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
    class MarketViewModel : DependencyObject
    {
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(MarketViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as MarketViewModel;
            if (current != null)
            {
                current.MarketItems.Filter = null;
                current.MarketItems.Filter = current.FilterMarket;
            }
        }

        public ICollectionView MarketItems
        {
            get { return (ICollectionView)GetValue(MarketItemsProperty); }
            set { SetValue(MarketItemsProperty, value); }
        }
        public static readonly DependencyProperty MarketItemsProperty =
            DependencyProperty.Register("MarketItems", typeof(ICollectionView), typeof(MarketViewModel), new PropertyMetadata(null));

        public MarketViewModel()
        {
            MarketItems = CollectionViewSource.GetDefaultView(Market.GetMarket());
            MarketItems.Filter = FilterMarket;
        }
        private bool FilterMarket(object obj)
        {
            bool result = true;
            Market current = obj as Market;
            if (!string.IsNullOrWhiteSpace(FilterText) && current != null && !current.exchange_id.Contains(FilterText) && !current.symbol.Contains(FilterText) && !current.base_asset.Contains(FilterText) && !current.quote_asset.Contains(FilterText) && !current.price_unconverted.Contains(FilterText) && !current.price.Contains(FilterText) && !current.change_24h.Contains(FilterText) && !current.spread.Contains(FilterText) && !current.volume_24h.Contains(FilterText) && !current.status.Contains(FilterText) && !current.created_at.Contains(FilterText) && !current.updated_at.Contains(FilterText))
            {
                result = false;
            }
            return result;
        }
    }
}
 
    //!string.IsNullOrWhiteSpace(FilterText) && current != null && !current.exchange_id.Contains(FilterText) && !current.symbol.Contains(FilterText) && !current.base_asset.Contains(FilterText) && !current.quote_asset.Contains(FilterText) && !current.price_unconverted.Contains(FilterText) && !current.price.Contains(FilterText) && !current.change_24h.Contains(FilterText) && !current.spread.Contains(FilterText) && !current.volume_24h.Contains(FilterText) && !current.status.Contains(FilterText) && !current.created_at.Contains(FilterText) && !current.updated_at.Contains(FilterText))

