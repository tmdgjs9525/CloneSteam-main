using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace CloneSteam.Library.UI.Units.Side
{

    public class GameCategoryToggle : ToggleButton
    {
        static GameCategoryToggle()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameCategoryToggle), new FrameworkPropertyMetadata(typeof(GameCategoryToggle)));
        }


    }
}
