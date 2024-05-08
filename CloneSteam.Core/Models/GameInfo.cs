using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace CloneSteam.Core.Models
{
    public partial class GameInfo : ObservableObject
    {
        [ObservableProperty]
        private bool isDenied;

        [ObservableProperty]
        private bool isInstalled;

        public string Type { get; set; }
        public string Name { get; set; }
        public int SteamAppID { get; set; }
        public int RequiredAge { get; set; }
        public bool IsFree { get; set; }
        public string DetailedDescription { get; set; }
        public string AboutTheGame { get; set; }
        public string ShortDescription { get; set; }
        public string SupportedLanguages { get; set; }
        public string BackgroundImage { get; set; }
        public string HeaderImage { get; set; }
        public string CapsuleImage { get; set; }
        public string CapsuleImagev5 { get; set; }
        public string Website { get; set; }
        public string PCMinimumRequirements { get; set; }
        public string PCMaximumRequirements { get; set; }
        public string Developers { get; set; }
        public string Publishers { get; set; }
        public string PriceCurrency { get; set; }
        public decimal PriceInitial { get; set; }
        public decimal PriceFinal { get; set; }
        public int PriceDiscountPercent { get; set; }

        public bool Windows { get; set; }
        public bool Mac { get; set; }
        public bool Linux { get; set; }
        public string Metacritic { get; set; }
        public string Categories { get; set; }
        public string Genres { get; set; }
        public List<string> Screenshots { get; set; }
        public long Length { get; set; }

        public List<News> News { get; set; } = new List<News>();
        public GameInfo(string? type, string? name, int steamAppID, int requiredAge, string? detailedDescription, string? headerImage,bool isInstalled)
        {
            Type = type;
            Name = name;
            SteamAppID = steamAppID;
            RequiredAge = requiredAge;
            DetailedDescription = detailedDescription;
            HeaderImage = headerImage;
            IsInstalled = isInstalled;
            string tempContent = "Today, we’re bringing you an update with some balance changes and dev comments on future changes to both the Stun Gun and the Cloaking Device!\r\n\r\nThe second Community Challenge has come to an end. Congratulations on reaching the goal! We were never worried (maybe a little worried), enjoy your brand new Boombox — and special shout out to player \"Goo and Sledge\" for pushing the platform an astounding 185km!";
            DateTime dateTime = DateTime.Now;
            for (int i = 0; i < 10; i++)
            {
                News.Add(new News(NewsType.MAIN_UPDATE, dateTime.AddDays(-i), $"{Name} Update {i}", tempContent, null, 0));
            }
        }
        public GameInfo(string type, string name, int steamAppID, int requiredAge, bool isFree, string detailedDescription, string aboutTheGame, string shortDescription, string supportedLanguages, string headerImage, string capsuleImage, string capsuleImagev5, string website, string pcMinimumRequirements, string pcMaximumRequirements, string developers, string publishers, string priceCurrency, decimal priceInitial, decimal priceFinal, int priceDiscountPercent, bool windows, bool mac, bool linux, string metacritic, string categories, string genres,bool isInstalled)
        {
            Type = type;
            Name = name;
            SteamAppID = steamAppID;
            RequiredAge = requiredAge;
            IsFree = isFree;
            DetailedDescription = detailedDescription;
            AboutTheGame = aboutTheGame;
            ShortDescription = shortDescription;
            SupportedLanguages = supportedLanguages;
            HeaderImage = headerImage;
            CapsuleImage = capsuleImage;
            CapsuleImagev5 = capsuleImagev5;
            Website = website;
            PCMinimumRequirements = pcMinimumRequirements;
            PCMaximumRequirements = pcMaximumRequirements;
            Developers = developers;
            Publishers = publishers;
            PriceCurrency = priceCurrency;
            PriceInitial = priceInitial;
            PriceFinal = priceFinal;
            PriceDiscountPercent = priceDiscountPercent;
            Windows = windows;
            Mac = mac;
            Linux = linux;
            Metacritic = metacritic;
            Categories = categories;
            Genres = genres;
            IsInstalled = isInstalled;
        }


    }
}
