using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XF_LaunchingApps.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _naviateCommand;
        public DelegateCommand NavigateCommand => _naviateCommand ?? (_naviateCommand = new DelegateCommand(ExcuteNavigateCommand));

        async void ExcuteNavigateCommand()
        {
            await _navigationService.NavigateAsync("ChartPage");
        }
    }
}
