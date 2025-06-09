using System.Windows;
using System.Windows.Controls;
using WpfApp1.ViewModels;
namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для StaffsView.xaml
    /// </summary>
    public partial class StaffsView : UserControl
    {
        public StaffViewModel ViewModel { get; set; }
        public StaffsView(StaffViewModel staffViewModel)
        {
            InitializeComponent();
            this.ViewModel = staffViewModel;
            this.DataContext = ViewModel;
        }

        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            var vm = (StaffViewModel)DataContext;
            vm.LoadStaffs();
        }
    }
}
