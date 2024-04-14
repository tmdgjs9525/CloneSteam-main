using System.Windows;
using System.Windows.Controls;

namespace CloneSteam.Login.UI.Units
{
    public class LoginProblemButton : Button
    {
        static LoginProblemButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginProblemButton), new FrameworkPropertyMetadata(typeof(LoginProblemButton)));
        }
    }
}
