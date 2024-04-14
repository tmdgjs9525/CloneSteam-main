using CloneSteam.Core.Events;
using CloneSteam.Core.Helpers;
using CloneSteam.Login.UI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Regions;
using System.Windows;
using System.Windows.Media.Animation;

namespace CloneSteam.Main.Local.ViewModels
{
    public partial class MainWindowViewModel :ObservableObject
    {
        private readonly IRegionManager _regionManager;
        private WindowSizeHelper _windowSizeHelper;
        [ObservableProperty]
        private double width = 705;
        [ObservableProperty]
        private double height = 440;
        [ObservableProperty]
        private double minWidth = 705;
        [ObservableProperty]
        private double minHeight = 440;
        [ObservableProperty]
        private ResizeMode resizeMode = ResizeMode.NoResize;
        public MainWindowViewModel(IRegionManager regionManager,WindowSizeHelper windowSizeHelper) 
        {
            _regionManager = regionManager;
            _regionManager.RegisterViewWithRegion<LoginWindow>("MainWindowRegion");
            _windowSizeHelper = windowSizeHelper;
            WindowSizeHelper.OnRegionChangedEvent += OnRegionChagned;
        }

        private void OnRegionChagned(object? sender, RegionNameEventArgs e)
        {
            var CurruntView = _regionManager.Regions["MainWindowRegion"].ActiveViews.FirstOrDefault();
            if (CurruntView.ToString().Contains("LoginWindow"))
            {
                ResizeMode = ResizeMode.NoResize;
                MinWidth = 705;
                MinHeight = 440;
                Width = MinWidth;
                Height = MinHeight;
               
            }
            else if (CurruntView.ToString().Contains("MainContent"))
            {
                ResizeMode = ResizeMode.CanResize;
                MinWidth = 800;
                MinHeight = 600;
                Width = 1200;
                Height = 800;
            }
           
        }


    }
}
