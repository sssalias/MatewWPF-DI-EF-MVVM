using System.Windows;
using System.Windows.Controls;
using WpfApp1.ViewModels;


namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для ProductTypesView.xaml
    /// </summary>
    public partial class ProductTypesView : UserControl
    {
        public ProductTypesView(ProductTypeViewModel productTypeViewModel)
        {
            InitializeComponent();
            this.DataContext = productTypeViewModel;
        }

        private void Wiew_Loaded(object sender, RoutedEventArgs e)
        {
            var vm = (ProductTypeViewModel)DataContext;
            vm.LoadProductTypes();
        }
    }
}
