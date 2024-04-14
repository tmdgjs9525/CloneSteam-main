using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Models
{
    public partial class LibraryCategory : ObservableObject
    {
        [ObservableProperty]
        private bool isFolderExpanded;
        [ObservableProperty]
        private bool isSelected;

        
        public string Name { get; set; } = "카테고리 없음";
        public ObservableCollection<GameInfo>? Children {  get; set; }
    }
}
