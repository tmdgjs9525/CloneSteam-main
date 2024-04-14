using CloneSteam.Core.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CloneSteam.Library.UI.Units.Side
{

    public class GameCategoryItem : TreeViewItem
    {
        //이 item은 GameInfoItem의 부모로 사용됨



        static GameCategoryItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameCategoryItem), new FrameworkPropertyMetadata(typeof(GameCategoryItem)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new GameInfoItem();
        }

      
    }
}
