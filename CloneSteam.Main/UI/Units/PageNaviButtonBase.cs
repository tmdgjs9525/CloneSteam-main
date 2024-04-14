using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CloneSteam.Main.UI.Units
{

    public class PageNaviButtonBase : Button
    {
        public static readonly DependencyProperty MyIconProperty =
           DependencyProperty.Register("MyIcon", typeof(Geometry), typeof(PageNaviButtonBase), new PropertyMetadata(null));

        // 속성 래퍼
        public Geometry MyIcon
        {
            get { return (Geometry)GetValue(MyIconProperty); }
            set { SetValue(MyIconProperty, value); }
        }
        static PageNaviButtonBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PageNaviButtonBase), new FrameworkPropertyMetadata(typeof(PageNaviButtonBase)));
        }

       
    }
}
