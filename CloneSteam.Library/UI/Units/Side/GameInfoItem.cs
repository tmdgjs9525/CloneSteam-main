using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CloneSteam.Library.UI.Units.Side
{

    public class GameInfoItem : TreeViewItem
    {
        static GameInfoItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameInfoItem), new FrameworkPropertyMetadata(typeof(GameInfoItem)));
        }


    }
}
