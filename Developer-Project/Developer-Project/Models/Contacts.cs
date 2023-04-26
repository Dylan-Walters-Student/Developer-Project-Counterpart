using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Project.Models
{
    public class Contacts
    {
        private readonly List<Acquaintance> _aquaintanceToContacts;

        public Contacts()
        {
            _aquaintanceToContacts = new List<Acquaintance>();
        }

        public void AddAcquaitance(Acquaintance acquaintance)
        {
            _aquaintanceToContacts.Add(acquaintance);
        }

        public IEnumerable<Acquaintance> GetAcquaintance()
        {
            return _aquaintanceToContacts;
        }
    }
}
