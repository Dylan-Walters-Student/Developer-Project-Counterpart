using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Developer_Project.ViewModel
{
    public class ContactListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<AcquaintanceViewModel> _acquaintances;
        public IEnumerable<AcquaintanceViewModel> Acquaintances => _acquaintances;
        public ICommand AddContactCommand { get; }

        ContactListViewModel() 
        {
            _acquaintances = new ObservableCollection<AcquaintanceViewModel>
            {
                new AcquaintanceViewModel(new Models.Acquaintance("name", "email", "number", "address")),
                new AcquaintanceViewModel(new Models.Acquaintance("name", "email", "number", "address")),
                new AcquaintanceViewModel(new Models.Acquaintance("name", "email", "number", "address"))
            };
        }

    }
}
