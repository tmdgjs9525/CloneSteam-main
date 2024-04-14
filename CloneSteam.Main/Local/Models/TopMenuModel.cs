using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CloneSteam.Main.Local.Models
{
    public class TopMenuModel
    {
        public string? Header { get; set; }
        public Geometry? Icon { get; set; }
        public  List<PopupItem> PopupItems { get; set; } = new List<PopupItem>();

        public TopMenuModel(string? header, Geometry? icon = null)
        {
            Header = header;
            Icon = icon;
        }

        public TopMenuModel setPopupItems(List<PopupItem> popupItems)
        {
            PopupItems = popupItems;
            return this;
        }
    }
}
