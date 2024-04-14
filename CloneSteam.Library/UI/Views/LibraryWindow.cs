using System.Windows;
using System.Windows.Controls;

namespace CloneSteam.Library.UI.Views
{


    public class LibraryWindow : Control
    {
        static LibraryWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LibraryWindow), new FrameworkPropertyMetadata(typeof(LibraryWindow)));
        }
    }
}
