using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CloneSteam.Main.Local.Models
{
    public class PopupItem
    {
        public string ItemName { get; set; }
        public ICommand? Command { get; set; }
        public PopupItem(string itemName, ICommand? command = null)
        {
            ItemName = itemName;
            Command = command;
        }
    }
}
