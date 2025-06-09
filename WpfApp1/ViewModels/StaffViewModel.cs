using System.Collections.ObjectModel;
using WpfApp1.Core;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class StaffViewModel: BaseViewModel
    {
        public DBContext Context;

        private ObservableCollection<Staff> _staffs;

        public StaffViewModel(DBContext context)
        {
            Context = context;
        }

        public ObservableCollection<Staff> Staffs
        {
            get => _staffs;
            set => SetField(ref _staffs, value);
        }

        public void LoadStaffs()
        {
            var staffs = Context.Staffs.ToList();
            Staffs = new ObservableCollection<Staff>(staffs);
        }
    }
}
