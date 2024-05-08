using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Models
{
    public enum NewsType 
    {
        NEWS,
        MAIN_UPDATE,
        COMMON_UPDATE,
        SMALL_UPDATE,
        ACCOMPLISHED_CHALLENGE,
    }

    public class News :GameNewsBase
    {
        public News(NewsType newsType, DateTime dateOrigin, string title, string content, List<Comment> comment, int like) : base(dateOrigin, title, content, comment, like)
        {
            NewsType = newsType;
        }

        public NewsType NewsType { get; set; }

        
        
    }
}
