using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Main.Local.Models
{
    public class MainContentMenuModel
    {
        public string? Header { get; set; }
        public bool IsChecked { get; set; } = false;
        public List<PopupItem> PopupItems { get; set; } = new List<PopupItem>();

        public MainContentMenuModel(string? header)
        {
            Header = header;
        }
           
        public MainContentMenuModel SetPopupItems(List<PopupItem> PopupItems)
        {
            this.PopupItems = PopupItems;
            return this;
        }
        public MainContentMenuModel SetIsChekced(bool IsChecked)
        {
            this.IsChecked = IsChecked;
            return this;
        }
    }
}
