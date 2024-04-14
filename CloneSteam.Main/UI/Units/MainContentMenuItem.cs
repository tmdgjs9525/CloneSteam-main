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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CloneSteam.Main.UI.Units
{
   
    public class MainContentMenuItem : RadioButton
    {
        private Storyboard? OnCheckedAni;
        private TextBlock? header;
        static MainContentMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainContentMenuItem), new FrameworkPropertyMetadata(typeof(MainContentMenuItem)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (header != null)
            {
                return;
            }
            header = this.Template.FindName("header", this) as TextBlock;
            Grid? border = this.Template.FindName("BorderGrid", this) as Grid;
            DoubleAnimation animation = new();
            animation.From = 0;
            animation.To = header.ActualWidth;
            animation.Duration = TimeSpan.FromSeconds(0.1); // 애니메이션 지속 시간

            OnCheckedAni = new Storyboard();
            OnCheckedAni.Children.Add(animation);
            Storyboard.SetTarget(animation, border);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Grid.WidthProperty));
        }
        protected override void OnChecked(RoutedEventArgs e)
        {
            base.OnChecked(e);

            if (OnCheckedAni != null)
            {
                OnCheckedAni.Begin(this);
            }
            
        }

        protected override void OnUnchecked(RoutedEventArgs e)
        {
            base.OnUnchecked(e);
            Grid? border = this.Template.FindName("BorderGrid", this) as Grid;
            DoubleAnimation animation = new();

            animation.To = 0;
            animation.Duration = TimeSpan.FromSeconds(0.1); // 애니메이션 지속 시간

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTarget(animation, border);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Grid.WidthProperty));
            storyboard.Begin(this);
        }
    }
}
