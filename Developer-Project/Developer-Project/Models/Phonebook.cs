using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Project.Models
{
    public class Phonebook
    {
        private readonly Contacts _contact;

        public string Name { get; }

        public Phonebook(string name)
        {
            _contact = new Contacts();
            Name = name;
        }

        public IEnumerable<Acquaintance> GetAcquaintances()
        {
            return _contact.GetAcquaintance();
        }

        public void MakeContact(Acquaintance acquaintance)
        {
            _contact.AddAcquaitance(acquaintance);
        }
    }
}
