using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;

namespace ModuleA.ViewModels
{
    public class ViewDViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        string _title = "View E";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand NavigateCommand { get; set; }
        public ViewDViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            //NavigateCommand = new DelegateCommand(Navigate);
            NavigateCommand = new DelegateCommand(async () => await Navigate());
        }

        async Task Navigate()
        {
            await _navigationService.NavigateAsync("ViewE");

            Debug.WriteLine("After _navigationService.NavigateAsync(ViewE) ...");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }
    }
}
