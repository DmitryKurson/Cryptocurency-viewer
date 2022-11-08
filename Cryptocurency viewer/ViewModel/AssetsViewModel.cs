using Cryptocurency_viewer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows;

namespace Cryptocurency_viewer.ViewModel
{
    class AssetsViewModel : DependencyObject
    {
        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(AssetsViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as AssetsViewModel;
            if (current != null)
            {
                current.AssetsItems.Filter = null;
                current.AssetsItems.Filter = current.FilterAssets;
            }
        }

        public ICollectionView AssetsItems
        {
            get { return (ICollectionView)GetValue(AssetsItemsProperty); }
            set { SetValue(AssetsItemsProperty, value); }
        }
        public static readonly DependencyProperty AssetsItemsProperty =
            DependencyProperty.Register("AssetsItems", typeof(ICollectionView), typeof(AssetsViewModel), new PropertyMetadata(null));

        public AssetsViewModel()
        {
            AssetsItems = CollectionViewSource.GetDefaultView(Assets.GetAssets());
            AssetsItems.Filter = FilterAssets;
        }

        private bool FilterAssets(object obj)
        {
            bool result = true;
            Assets current = obj as Assets;
            if (!string.IsNullOrWhiteSpace(FilterText) && current != null && !current.asset_id.Contains(FilterText) && !current.name.Contains(FilterText) && !current.price.Contains(FilterText) && !current.volume_24h.Contains(FilterText) && !current.change_1h.Contains(FilterText) && !current.change_24h.Contains(FilterText) && !current.change_7d.Contains(FilterText)  && !current.status.Contains(FilterText) && !current.created_at.Contains(FilterText) && !current.updated_at.Contains(FilterText))
            {
                result = false;
            }
            return result;
        }
    }
}
