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

namespace CloneSteam.Login.UI.Units
{
    public class SignUpButton : Button
    {
        static SignUpButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SignUpButton), new FrameworkPropertyMetadata(typeof(SignUpButton)));
        }
    }
}
