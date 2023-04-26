using Developer_Project.Commands;
using Developer_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Developer_Project.ViewModel
{
    public class AddContactViewModel : ViewModelBase
    {
        private string _name;
        public string Name { 
            get 
            { return _name; }
            set
            { 
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        } 

        private string _email;
        public string Email
        {
            get
            { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string _address;
        public string Address
        {
            get
            { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get
            { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }
        public ICommand DeleteCommand { get; }

        public AddContactViewModel(Phonebook phonebook)
        {
            SubmitCommand = new AddContactCommand(this, phonebook);
        }
    }
}
