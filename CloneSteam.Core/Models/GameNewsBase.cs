using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Models
{
    public class GameNewsBase
    {
        private DateTime dateOrigin;

        public GameNewsBase(DateTime dateOrigin, string title, string content, List<Comment> comment, int like)
        {
            this.dateOrigin = dateOrigin;
            Title = title;
            Content = content;
            Comment = comment;
            Like = like;
        }

        public string Date 
        { 
            get 
            { 
                return dateOrigin.Month.ToString() +"월"+dateOrigin.Day+"일";
            } 
            set { Date = value; } }
        public string Title { get; set; }

        public string Content { get; set; }
        public List<Comment> Comment { get; set; } = new List<Comment>();
        public int Like { get; set; }

       
    }
}
