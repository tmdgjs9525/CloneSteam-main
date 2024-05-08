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
        public User(string name, string email, string profileImage, int steamLevel, DateTime lastLoginTime, State state, List<Challenge> challenges)
        {
            Name = name;
            Email = email;
            ProfileImage = profileImage;
            SteamLevel = steamLevel;
            LastLoginTime = lastLoginTime;
            State = state;
            Challenges = challenges;


            /////temp
            Random r = new Random();
            int playedTime = r.Next(1,30);
            RecentlyPlayedTime = "최근 플레이 시간: " + playedTime + "시간";
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string ProfileImage { get; set; }
        public int SteamLevel { get; set; }

        public DateTime LastLoginTime { get; set; }
        public State State { get; set; } = State.None;

        public List<Challenge> Challenges { get; set; } = new List<Challenge>();

        public List<UserGameData> GameDatas { get; set; } = new List<UserGameData>();


        ///temp
        public string RecentlyPlayedTime { get; set; }
    }

    public class UserGameData
    {
        public UserGameData(int appId, DateTime recentlyPlayedTime, DateTime totalPlayTime)
        {
            this.appId = appId;
            RecentlyPlayedTime = recentlyPlayedTime;
            TotalPlayTime = totalPlayTime;
        }

        public int appId { get; init; }
        public DateTime RecentlyPlayedTime { get; set; }
        public DateTime TotalPlayTime { get; set; }

    }
}
