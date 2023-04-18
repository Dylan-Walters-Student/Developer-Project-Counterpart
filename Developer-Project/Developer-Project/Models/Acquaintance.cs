using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Project.Models
{
    internal class Acquaintance
    {
        public string Name { get; }
        public string Email { get; }
        public string PhoneNumber { get; }
        public string Address { get; }

        public Acquaintance(string name, string email, string phoneNumber, string address)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
