using System.Windows;
using System.Windows.Controls;
namespace CloneSteam.Login.UI.Views
{
    public class LoginWindow : Control
    {
        static LoginWindow()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginWindow), new FrameworkPropertyMetadata(typeof(LoginWindow)));
        }

    }
}
