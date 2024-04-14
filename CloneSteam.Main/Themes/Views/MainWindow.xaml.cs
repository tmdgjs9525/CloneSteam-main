using CloneSteam.Main.Local.ViewModels;
using Prism.Regions;
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
using System.Windows.Shapes;

namespace CloneSteam.Main.Themes.Views
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SetBinding(Window.WidthProperty, new Binding("Width") { Source = this.DataContext, Mode = BindingMode.TwoWay });
            this.SetBinding(Window.HeightProperty, new Binding("Height") { Source = this.DataContext, Mode = BindingMode.TwoWay });
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

    }
}
