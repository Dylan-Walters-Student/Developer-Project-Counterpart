using Developer_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Project.ViewModel
{
    internal class AcquaintanceViewModel
    {
        private readonly Acquaintance _acquaintance;
        public string Name => _acquaintance.Name;
        public string Email => _acquaintance.Email;
        public string PhoneNumber => _acquaintance.PhoneNumber;
        public string Address =>  _acquaintance.Address;

        public AcquaintanceViewModel(Acquaintance acquaintance)
        {
            _acquaintance = acquaintance;
        }
    }
}
