using CloneSteam.Core.Models;
using CloneSteam.Core.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CloneSteam.Library.Local.ViewModels
{
    public partial class GameInfoDetail : ObservableObject
    {
        [ObservableProperty]
        private GameInfo currentGameInfo;

        [ObservableProperty]
        private List<User> playedRecentlyList;

        private FriendData _friendData;
        public GameInfoDetail(FriendData friendData)
        {
           _friendData = friendData;

            PlayedRecentlyList = _friendData.friends;
        }

        #region Command
        [RelayCommand]
        private void SettingBtn()
        {
            MessageBox.Show("SettingBtn Check");
        }

        [RelayCommand]
        private void InfoBtn()
        {
            MessageBox.Show("InfoBtnCommand Check");
        }
        [RelayCommand]
        private void BookmarkBtn()
        {
            MessageBox.Show("BookmarkBtnCommand Check");
        }
        [RelayCommand]
        void ShowPage()
        {
            MessageBox.Show("ShowPage Command Check");
        }
        [RelayCommand]
        void Cummunityhub()
        {
            MessageBox.Show("CummunityhubCommand Check");
        }
        [RelayCommand]
        void Debate()
        {
            MessageBox.Show("DebateCommand Check");
        }
        [RelayCommand]
        void Guide()
        {
            MessageBox.Show("GuideCommand Check");
        }
        [RelayCommand]
        void Support()
        {
            MessageBox.Show("SupportCommand Check");
        }
        #endregion
    }
}
