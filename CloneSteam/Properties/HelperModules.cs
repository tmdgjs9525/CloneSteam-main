using CloneSteam.Core.Helpers;
using CloneSteam.Core.Services;
using Prism.Ioc;
using Prism.Modularity;
namespace CloneSteam.Properties
{
    internal class HelperModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
          

            containerRegistry.RegisterSingleton<WindowSizeHelper>();
            containerRegistry.RegisterSingleton<NavigationService>();
            containerRegistry.RegisterSingleton<GameInfoService>();

            //containerRegistry.RegisterSingleton<DirectoryManager>();
            //singleton으로 생성할 객체
        }
    }
}
