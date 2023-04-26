using Developer_Project.Models;
using Developer_Project.ViewModel;
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
        private readonly Phonebook _phonebook;
        public App()
        {
            _phonebook = new Phonebook("User1");
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_phonebook)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
