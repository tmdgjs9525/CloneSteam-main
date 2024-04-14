using CloneSteam.Core.Helpers;
using CloneSteam.Login.UI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Login.Local.ViewModels
{
    public partial class LoginWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        string? id;

        [ObservableProperty]
        string? rememberLoginTooltip;

        private readonly IRegionManager _regionManager;
        public readonly NavigationService _navigationService;

        public LoginWindowViewModel(IRegionManager regionManager, NavigationService navigationService)
        {
            _regionManager = regionManager;
            Id = "test";
            RememberLoginTooltip = getRememberLoginTooltip();
            _navigationService = navigationService;
        }

        [RelayCommand]
        private void Login(string para)
        {
            Navigation(para);
        }

        [RelayCommand]
        private void SignUp()
        {

        }

        private string getRememberLoginTooltip()
        {
            return "다음에 Steam을 시작할 때 비밀번호를 입력하거나\n" +
                                   "로그인을 확인할 필요가 없습니다."; 
        }

        private void Navigation(string para)
        {
            _navigationService.NavigationMainRegion(para);
        }
    }
}
