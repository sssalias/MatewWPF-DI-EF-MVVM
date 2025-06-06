using Microsoft.EntityFrameworkCore;
using System.Windows;
using WpfApp1.Core;
using WpfApp1.Models;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DBContext dBContext;
        private readonly MainViewModel mainViewModel;
        public MainWindow(DBContext _dBContext, MainViewModel _mainViewModel)
        {
            InitializeComponent();
            this.dBContext = _dBContext;
            this.mainViewModel = _mainViewModel;
            DataContext = mainViewModel;
            //MessageBox.Show(mainViewModel.PositionVm.Positions[0].Title);
            //this.LoadData();
        }

        public void LoadData()
        {
            //List<Staff> staffs = dBContext.Staffs
            //    .Include(s => s.Position)
            //    .ToList();
            //MessageBox.Show(staffs[0].Position.Title);
        }
    }
}