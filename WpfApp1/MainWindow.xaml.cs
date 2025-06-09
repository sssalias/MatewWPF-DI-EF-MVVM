using System.Windows;
using WpfApp1.Core;
using WpfApp1.Views;


namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(
            DBContext _dBContext, 
            PositionsView _positionsView,
            StaffsView _staffsView,
            ProductTypesView _productTypesView
        )
        {
            InitializeComponent();
            firstTab.Children.Add(_positionsView);
            secondTab.Children.Add(_staffsView);
            productTypeTab.Children.Add(_productTypesView);
        }
       
    }
}