using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Models
{
    public enum FriendState 
    {
        ONLINE,
        OFFLINE,
        AWAY_FROM_KEYBOARD, //자리비움
        HIDING,
    }

    public class Friend
    {
        FriendState state;
        private string? name;

    }
}
