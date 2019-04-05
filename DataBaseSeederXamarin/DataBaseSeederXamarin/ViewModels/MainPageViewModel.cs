using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataBaseSeeder;

namespace DataBaseSeederXamarin.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IDbSeeder _dbSeeder;

        public MainPageViewModel(INavigationService navigationService,
            IDbSeeder dbSeeder)
            : base(navigationService)
        {
            _dbSeeder = dbSeeder;
            Title = "Main Page";
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            _dbSeeder.Seed();
        }
    }
}
