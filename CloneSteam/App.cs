using CloneSteam.Login.UI.Views;
using CloneSteam.Main.Themes.Views;
using CloneSteam.Properties;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Reflection;
using System.Windows;

namespace CloneSteam
{
    internal class App : PrismApplication
    {
        private List<IModule> _modules;

        public App()
        {
            _modules = new();
        }
        protected override Window CreateShell()
        {
            return new MainWindow();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LoginWindow>();
            containerRegistry.RegisterForNavigation<MainContent>();
        }

        internal App AddInversionModule<T>() where T : IModule, new()
        {
            HelperModules module = new HelperModules();
            _modules.Add(module);

            return this;
        }
        internal App WireViewModel()
        {
            WireDataContext.WireVIewModelModule();
            return this;
        }

 
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();
            Prism.Mvvm.ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                string? viewName = viewType.FullName;
                if (viewName == null)
                {
                    return null;
                }

                if (viewName.EndsWith("View"))
                {
                    viewName = viewName.Substring(0, viewName.Length - 4);
                }

                viewName = viewName.Replace(".Views.", ".Local.ViewModels.").Replace(".Themes","").Replace(".UI", "");
                //viewName = viewName.Replace(".Controls.", ".ControlViewModels.");
                string? viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                string viewModelName = $"{viewName}ViewModel, {viewAssemblyName}";
                return Type.GetType(viewModelName);
            });
        }
    }
    
}
