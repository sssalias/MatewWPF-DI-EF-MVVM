using System.Windows;
using System.Windows.Controls;
using WpfApp1.ViewModels;

namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для PositionsView.xaml
    /// </summary>
    public partial class PositionsView : UserControl
    {
        public PositionViewModel ViewModel { get; set; }
        public PositionsView(PositionViewModel positionViewModel)
        {
            InitializeComponent();
            this.ViewModel = positionViewModel;
            this.DataContext = ViewModel;
        }
        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            var vm = (PositionViewModel)DataContext;
            vm.LoadPositions(); 
        }
    }
}
