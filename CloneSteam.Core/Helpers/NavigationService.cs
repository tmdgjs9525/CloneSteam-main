using CloneSteam.Core.Events;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Helpers
{
    public class NavigationService
    {

        private readonly IRegionManager _regionManager;
        public WindowSizeHelper _windowSizeHelper;
        public NavigationService(IRegionManager regionManager, WindowSizeHelper windowSizeHelper)
        {
            _regionManager = regionManager;
            _windowSizeHelper = windowSizeHelper;
        }

        
        public void NavigationMainRegion(string para)
        {
            switch (para)
            {
                //Back이란 문자열이 들어오면..
                case "Back":
                    {
                        //Back을 구현하기 위해서 ContentRegion의 Journal을 가져오고, 뒤로가기가 가능한지 확인 후 실행
                        IRegionNavigationJournal journal = _regionManager.Regions["MainWindowRegion"]
                                                                .NavigationService.Journal;
                        if (journal.CanGoBack)
                        {
                            journal.GoBack();
                        }
                    }
                    break;
                //그외 일반 문자열이 들어오면    
                default:
                    //ContentRegion에 para가 지정하는 화면으로 네비게이트 해라
                    _regionManager.RequestNavigate("MainWindowRegion", para);
                    _windowSizeHelper.OnRegionChanged(para);
                    break;
            }
        }
        public void NavigationMainContentRegion(string para)
        {
            switch (para)
            {
                //Back이란 문자열이 들어오면..
                case "Back":
                    {
                        //Back을 구현하기 위해서 ContentRegion의 Journal을 가져오고, 뒤로가기가 가능한지 확인 후 실행
                        IRegionNavigationJournal journal = _regionManager.Regions["MainContentRegion"]
                                                                .NavigationService.Journal;
                        if (journal.CanGoBack)
                        {
                            journal.GoBack();
                        }
                    }
                    break;
                //그외 일반 문자열이 들어오면    
                default:
                    //ContentRegion에 para가 지정하는 화면으로 네비게이트 해라
                    _regionManager.RequestNavigate("MainContentRegion", para);
                    break;
            }
        }
    }
}
