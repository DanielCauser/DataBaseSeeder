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
        public MainPageViewModel(INavigationService navigationService,
            IDbSeeder dbSeeder)
            : base(navigationService)
        {
            Title = "Main Page";
        }
    }
}
