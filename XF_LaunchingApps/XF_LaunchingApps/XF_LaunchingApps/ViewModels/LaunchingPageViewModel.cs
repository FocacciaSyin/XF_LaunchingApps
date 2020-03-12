using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XF_LaunchingApps.ViewModels
{
    public class LaunchingPageViewModel : ViewModelBase
    {
        private INavigationService _navigationService;
        public LaunchingPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Launching Page";
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
            //回到最原始的畫面而且沒有NavigationBar(根頁面其他頁面全部清空)
            await _navigationService.NavigateAsync("/NavigationPage/MainPage");
        }
    }
}
