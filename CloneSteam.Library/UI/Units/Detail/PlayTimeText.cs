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

namespace CloneSteam.Library.UI.Units.Detail
{

    public class PlayTimeText : Control
    {
        public static readonly DependencyProperty TextProperty =
                  DependencyProperty.Register("Text", typeof(string), typeof(PlayTimeText), new PropertyMetadata(""));

        public static readonly DependencyProperty ChildTextProperty =
                  DependencyProperty.Register("ChildText", typeof(string), typeof(PlayTimeText), new PropertyMetadata(""));
        static PlayTimeText()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PlayTimeText), new FrameworkPropertyMetadata(typeof(PlayTimeText)));
        }
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        public string ChildText
        {
            get => (string)GetValue(ChildTextProperty);
            set => SetValue(ChildTextProperty, value);
        }
    }
}
