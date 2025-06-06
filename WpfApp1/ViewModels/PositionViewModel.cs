using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Core;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class PositionViewModel: BaseViewModel
    {
        private readonly DBContext dbContext;

        public ObservableCollection<Position> Positions { get; set; }

        public PositionViewModel(DBContext _dbContext)
        {
            this.dbContext = _dbContext;
            loadData();
        }

        private void loadData()
        {
            Positions = new ObservableCollection<Position>(this.dbContext.Positions);
        }
    }
}
