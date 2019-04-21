using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataBaseSeeder;
using System.Windows.Input;
using Xamarin.Forms;

namespace DataBaseSeederXamarin.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IDbSeeder _dbSeeder;
        public ICommand SeedCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService,
            IDbSeeder dbSeeder)
            : base(navigationService)
        {
            _dbSeeder = dbSeeder;
            SeedCommand = new Command(Seed);
            Title = "Main Page";
        }

        private void Seed()
        {
            _dbSeeder.Seed();
        }
    }
}
