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
using System.Windows.Input;

namespace CloneSteam.Library.Local.ViewModels
{
    public partial class LibraryWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        List<LibraryCategory> games = new List<LibraryCategory>();

        [ObservableProperty]
        private GameInfoDetail selectedGame;

        public LibraryWindowViewModel(GameInfoService gameInfoService,FriendData friendData)
        {
            selectedGame = new(friendData);
            Games = gameInfoService.GenerateCategoryNodes();
            SelectedGame.CurrentGameInfo = Games[0].Children[0];
        }

        [RelayCommand]
        private void GameChanged(GameInfo gameInfo)
        {
            SelectedGame.CurrentGameInfo = gameInfo;
        }
    }
}
