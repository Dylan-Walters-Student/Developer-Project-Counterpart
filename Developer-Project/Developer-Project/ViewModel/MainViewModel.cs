using Developer_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Project.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }
        public MainViewModel(Phonebook phonebook) 
        {
            CurrentViewModel = new AddContactViewModel(phonebook);
        }
    }
}
