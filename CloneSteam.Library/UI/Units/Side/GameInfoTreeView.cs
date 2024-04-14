using CloneSteam.Core.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CloneSteam.Library.UI.Units.Side
{
    public class GameInfoTreeView : TreeView
    {
        public static readonly DependencyProperty SelectionCommandProperty = DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(GameInfoTreeView));

        static GameInfoTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameInfoTreeView), new FrameworkPropertyMetadata(typeof(GameInfoTreeView)));
        }

        public ICommand SelectionCommand
        {
            get => (ICommand)GetValue(SelectionCommandProperty);
            set => SetValue(SelectionCommandProperty, value);
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new GameInfoItem();
        }

        public GameInfoTreeView()
        {
              
        }

        private void TreeView_SelectedItemChanged(object sender , RoutedPropertyChangedEventArgs<object> e)
        {
            if (SelectedItem is GameInfo item)
            {
                SelectionCommand?.Execute(item);   
            }
        }
    }
}
