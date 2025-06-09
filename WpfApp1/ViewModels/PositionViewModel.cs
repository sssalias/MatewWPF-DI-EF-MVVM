using System.Collections.ObjectModel;
using WpfApp1.Core;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class PositionViewModel: BaseViewModel
    {
        public DBContext Context;

        private ObservableCollection<Position> _positions;

        public PositionViewModel(DBContext context)
        {
            Context = context;
        }

        public ObservableCollection<Position> Positions
        {
            get => _positions;
            set => SetField(ref _positions, value);
        }

        public void LoadPositions()
        {
            var positions = Context.Positions.ToList();
            Positions = new ObservableCollection<Position>(positions);
        }
    }
}
