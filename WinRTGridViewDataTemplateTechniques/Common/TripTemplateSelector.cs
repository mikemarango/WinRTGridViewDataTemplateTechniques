using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinRTGridViewDataTemplateTechniques.DataModel;

namespace WinRTGridViewDataTemplateTechniques.Common
{
    public class TripTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SaleTemplate { get; set; }
        public DataTemplate NotSaleTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var sale = item as Trip;

            if (sale != null && sale.IsSale)
                return SaleTemplate;

            return NotSaleTemplate;
        }
    }
}