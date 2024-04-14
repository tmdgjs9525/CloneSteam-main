using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Events
{
    public class RegionNameEventArgs
    {
        public RegionNameEventArgs(string message)
        {
            Message = message;
        }

        public string Message { get; set; }
    }
}
