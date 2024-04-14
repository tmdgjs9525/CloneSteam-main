using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CloneSteam.Main.UI.Units
{
    public class PopupItem : Button
    {
        static PopupItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PopupItem), new FrameworkPropertyMetadata(typeof(PopupItem)));
        }
    }
}
