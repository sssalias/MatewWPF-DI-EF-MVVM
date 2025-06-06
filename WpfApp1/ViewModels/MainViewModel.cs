using System.Collections.ObjectModel;
using WpfApp1.Models;
using WpfApp1.ViewModels;


namespace WpfApp1.ViewModel
{
    public class MainViewModel: BaseViewModel
    {
        public PositionViewModel PositionVm;
        public ObservableCollection<Position> positions;

        public MainViewModel(PositionViewModel _PositionVM) {
            this.PositionVm = _PositionVM;

            this.onLoad();
        }

        public void onLoad()
        {
            this.positions = PositionVm.Positions;
        }
    }
}
