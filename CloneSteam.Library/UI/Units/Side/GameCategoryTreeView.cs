using CloneSteam.Core.Models;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CloneSteam.Library.UI.Units.Side
{
    public class GameCategoryTreeView : TreeView
    {
        //하위 item의 하위 item~~ 의 selecteditem은 상위 treeview에 액세스 되기 때문에 여기에 selectionCommand

        public static readonly DependencyProperty SelectionCommandProperty = DependencyProperty.Register("SelectionCommand", typeof(ICommand), typeof(GameCategoryTreeView));

        static GameCategoryTreeView()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GameCategoryTreeView), new FrameworkPropertyMetadata(typeof(GameCategoryTreeView)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new GameCategoryItem();
        }

        public ICommand SelectionCommand
        {
            get => (ICommand)GetValue(SelectionCommandProperty);
            set => SetValue(SelectionCommandProperty, value);
        }

        public GameCategoryTreeView()
        {
            SelectedItemChanged += TreeView_SelectedItemChanged;
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (SelectedItem is GameInfo item)
            {
                SelectionCommand?.Execute(item);
            }
        }
    }
}
