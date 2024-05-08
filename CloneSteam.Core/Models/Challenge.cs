using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Models
{
    public class Challenge : GameNewsBase
    {
        public Challenge(DateTime dateOrigin, string title, string content, List<Comment> comment, int like) : base(dateOrigin, title, content, comment, like)
        {
        }
    }
}
