using CloneSteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Services
{
    public class FriendData
    {
        public List<User> friends;

        public FriendData()
        {
            string imagePath = System.IO.Directory.GetParent(System.Environment.CurrentDirectory).Parent.FullName;
            imagePath = imagePath.Replace("bin","ProfileImage\\dog.png");

            friends = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                User user = new User($"User{i}", $"email{i}",
                    imagePath,
                    
                    i,
                    DateTime.Now, State.ONLINE, null);
                friends.Add(user);
            }
        }
    }
}
