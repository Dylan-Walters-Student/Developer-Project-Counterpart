using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Project.Models
{
    internal class Phonebook
    {
        private readonly Contacts _contact;

        public string Name { get; }

        public Phonebook(string name)
        {
            _contact = new Contacts();
            Name = name;
        }

        public IEnumerable<Acquaintance> GetAcquaintances(string name)
        {
            return _contact.GetAcquaintance(name);
        }

        public void MakeContact(Acquaintance acquaintance)
        {
            _contact.AddAcquaitance(acquaintance);
        }
    }
}
