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
        List<LibraryCategory> gameInfos = new List<LibraryCategory>();

        [ObservableProperty]
        private GameInfo currentGameInfo;

        public LibraryWindowViewModel(GameInfoService gameInfoService)
        {
            GameInfos = gameInfoService.GenerateCategoryNodes();
        }

        [RelayCommand]
        private void GameChanged(GameInfo gameInfo)
        {
            CurrentGameInfo = gameInfo;
        }
    }
}
