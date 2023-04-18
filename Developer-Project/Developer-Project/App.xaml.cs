using Developer_Project.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Developer_Project
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Phonebook contactslist = new Phonebook("Clayton");

            contactslist.MakeContact(new Acquaintance("Dylan", "ddwalters987@gmail.com", "6162017277", "8491 South Maple Ct"));

            contactslist.MakeContact(new Acquaintance("kira", "kirasEmail@gmail.com", "616-something-something", "next to vitales"));

            IEnumerable<Acquaintance> contact = contactslist.GetAcquaintances("Dylan");
            Console.WriteLine(contact);

            base.OnStartup(e);
        }
    }
}
