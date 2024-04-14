using CloneSteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CloneSteam.Core.Services
{
    public class GameInfoService
    {
        public List<LibraryCategory> GenerateCategoryNodes()
        {
            List<LibraryCategory> Categories = new()
            {
                CreateGameCategory("즐겨찾기"),
                CreateGameCategory("카테고리 없음"),
            };

            foreach (var category in Categories)
            {
                category.Children = GenerateGameInfos(category);
            }
            return Categories;
        }

        private static LibraryCategory CreateGameCategory(string name )
        {
            return new LibraryCategory
            {
                Name = name,
                Children = new()
            };
        }

        private static ObservableCollection<GameInfo> GenerateGameInfos(LibraryCategory parent)
        {
            ObservableCollection<GameInfo> GameInfos = new();
            string[]? files = ReadGameFileCSV.GetFiles();
            if (files !=null)
            {
                foreach (var file in files)
                {
                    if (file.Contains("Release") || file.Contains("Debug"))
                    {
                        continue;
                    }
                    GameInfo g = ReadGameFileCSV.ReadGameInfosFromCSV(file);
                    if (g != null)
                    {
                        GameInfos.Add(g);
                    }
                    
                }
            }
            return GameInfos;
;
        }

        private static GameInfo CreateGameInfo(GameInfo parent, string type, string name, int steamAppID, int requiredAge, bool isFree, string detailedDescription, string aboutTheGame, string shortDescription, string supportedLanguages, string headerImage, string capsuleImage, string capsuleImagev5, string website, string pCMinimumRequirements, string pCMaximumRequirements, string developers, string publishers, string priceCurrency, decimal priceInitial, decimal priceFinal, int priceDiscountPercent, bool windows, bool mac, bool linux, string metacritic, string categories, string genres, bool isInstalled = false)
        {
            return new GameInfo
            (
                type,
                name,
                steamAppID,
                requiredAge,
                isFree,
                detailedDescription,
                aboutTheGame,
                shortDescription,
                supportedLanguages,
                headerImage,
                capsuleImage,
                capsuleImagev5,
                website,
                pCMinimumRequirements,
                pCMaximumRequirements,
                developers,
                publishers,
                priceCurrency,
                priceInitial,
                priceFinal,
                priceDiscountPercent,    
                windows,
                mac,
                linux,
                metacritic,
                categories,
                genres,
                isInstalled
            );
        }
    }
}
