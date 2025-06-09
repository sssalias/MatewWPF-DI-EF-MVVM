using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public class HomeViewModel: BaseViewModel
    {
        private string _title;


        public HomeViewModel() {
            _title = "It's HomePage";
        }

        public string Title { 
            get { return _title; }
            set { SetField(ref _title, value); }
        }
    }
}
