using CloneSteam.Core.Helpers;
using CloneSteam.Core.Icons;
using CloneSteam.Library.UI.Views;
using CloneSteam.Main.Local.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Main.Local.ViewModels
{
    public partial class MainContentViewModel :ObservableObject
    {
        [ObservableProperty]
        List<TopMenuModel> topMenus = new List<TopMenuModel>();

        [ObservableProperty]
        List<MainContentMenuModel> mainContentMenus = new List<MainContentMenuModel>();

        public readonly IRegionManager _regionManager;
        public readonly NavigationService _navigationService;
        public MainContentViewModel(IRegionManager regionManager,NavigationService navigationService)
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion("MainContentRegion", typeof(LibraryWindow));
            _navigationService = navigationService;

            SetTopMenuDumpData();
            SetMainMenuDumpData();
           
        }
        [RelayCommand]
        private void Logout()
        {
            _navigationService.NavigationMainRegion("LoginWindow");
        }
        [RelayCommand]
        private void Navigation(string para)
        {
            _navigationService.NavigationMainContentRegion(para);
        }

        #region GenData
        private void SetMainMenuDumpData()
        {

            List<PopupItem> 상점 = new List<PopupItem>()
            {
                new PopupItem("특집"),new PopupItem("맞춤 대기열"),
                new PopupItem("찜 목록"),new PopupItem("포인트 상점"),
                new PopupItem("뉴스"),new PopupItem("통계")
            };
            List<PopupItem> 라이브러리 = new List<PopupItem>()
            {
               new PopupItem("홈"),new PopupItem("모음집"),
                new PopupItem("다운로드"),
            };
            List<PopupItem> 커뮤니티 = new List<PopupItem>()
            {
                new PopupItem("홈"),new PopupItem("토론")
                ,new PopupItem("창작마당"),new PopupItem("장터")
                ,new PopupItem("방송")
            };
            List<PopupItem> User = new List<PopupItem>()
            {
                new PopupItem("활동"),new PopupItem("프로필"),
                new PopupItem("친구"),new PopupItem("그룹"),
                new PopupItem("콘텐츠"),new PopupItem("배지"),
                new PopupItem("보관함"),new PopupItem("돌아보기")
            };
            MainContentMenus.Add(new MainContentMenuModel("상점").SetPopupItems(상점));
            MainContentMenus.Add(new MainContentMenuModel("라이브러리").SetPopupItems(라이브러리).SetIsChekced(true));
            MainContentMenus.Add(new MainContentMenuModel("커뮤니티").SetPopupItems(커뮤니티));
            MainContentMenus.Add(new MainContentMenuModel("UserNickName").SetPopupItems(User));
        }
        private void SetTopMenuDumpData()
        {
            List<PopupItem> Steam = new List<PopupItem>()
            {
                new PopupItem("계정변경..."),new PopupItem("로그아웃...",LogoutCommand),
                new PopupItem("오프라인으로 전환..."),new PopupItem("Steam Client 업데이트 확인...")
               ,new PopupItem("게임 백업 복원..."),new PopupItem("설정"),new PopupItem("종료")
            };
            List<PopupItem> 보기 = new List<PopupItem>()
            {
                new PopupItem("라이브러리"),new PopupItem("숨겨진 게임"),
                new PopupItem("사운드 트랙"),new PopupItem("다운로드")
            };
            List<PopupItem> 친구 = new List<PopupItem>()
            {
                new PopupItem("온라인"),new PopupItem("자리비움"),
                new PopupItem("숨기"),new PopupItem("오프라인")                
            };
            TopMenus.Add(new TopMenuModel("Steam", Icons.SteamIcon).setPopupItems(Steam));
            TopMenus.Add(new TopMenuModel("보기").setPopupItems(보기));
            TopMenus.Add(new TopMenuModel("친구").setPopupItems(친구));
            TopMenus.Add(new TopMenuModel("게임"));
            TopMenus.Add(new TopMenuModel("지원"));
        }
        #endregion
    }
}
