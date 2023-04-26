using Developer_Project.Models;
using Developer_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Project.Commands
{
    public class AddContactCommand : CommandBase
    {
        private readonly AddContactViewModel _addContactViewModel;
        private readonly Phonebook _phonebook;
        public AddContactCommand(ViewModel.AddContactViewModel addContactViewModel, Phonebook phonebook)
        {
            _addContactViewModel = addContactViewModel;
            _phonebook = phonebook;
        }

        public override void Execute(object parameter)
        {
            Acquaintance acquaintance = new Acquaintance("", _addContactViewModel.Email, _addContactViewModel.Address, _addContactViewModel.PhoneNumber);
            _phonebook.MakeContact(acquaintance);
        }
    }
}
 