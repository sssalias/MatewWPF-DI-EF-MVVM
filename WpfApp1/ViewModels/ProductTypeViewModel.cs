using System.Collections.ObjectModel;
using WpfApp1.Core;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class ProductTypeViewModel: BaseViewModel
    {
        public DBContext Context;

        private ObservableCollection<ProductType> _productTypes;

        public ProductTypeViewModel(DBContext context)
        {
            Context = context;
        }

        public ObservableCollection<ProductType> ProductTypes
        {
            get => _productTypes;
            set => SetField(ref _productTypes, value);
        }

        public void LoadProductTypes()
        {
            List<ProductType> productTypes = Context.ProductTypes.ToList();
            ProductTypes = new ObservableCollection<ProductType>(productTypes);
        }
    }
}
