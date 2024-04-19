using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CloneSteam.Core.Models
{
    public enum State 
    {
        None,
        ONLINE,
        OFFLINE,
        PLAY_GAME,

    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Image ProfileImage { get; set; }
        public int SteamLevel { get; set; }

        public DateTime LastLoginTime { get; set; }
        public State State { get; set; } = State.None;

    }
}
