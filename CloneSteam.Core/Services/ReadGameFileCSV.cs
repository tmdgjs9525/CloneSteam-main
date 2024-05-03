using CloneSteam.Core.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneSteam.Core.Services
{
    public class ReadGameFileCSV
    {
        public static string[]? GetFiles()
        {
            string directoryPath = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName.Replace(@"\bin", @"\CSV");


            // 지정된 경로의 모든 파일 가져오기
            string[] files = Directory.GetFiles(directoryPath);

            if (files.Length > 0)
            {
                return files;
            }
            else
            {
                return null;
            }
       
          

        }
        public static GameInfo ReadGameInfosFromCSV(string filePath)
        {

            List<string> lines = File.ReadAllLines(filePath).ToList();
            Random random = new Random();
            bool isinstall;
            if (random.Next(0, 2) == 0)
            {
                isinstall = true;
            }
            else
            {
                isinstall = false;
            }
            List<string> fields = new List<string>();

            string? temppath = null;
            foreach (string line in lines) // Skip header line
            {
                try
                {
                    if (line.Split(',')[0].Contains("Screenshot Path Full") && temppath == null)
                    {
                        temppath = line.Split(",")[1];
                    }
                    string a = line.Split(',')[1] ?? "N/A";
                    fields.Add(a);
                }
                catch
                {

                } 
            }
           
            GameInfo game = new GameInfo(
                type: fields[0], name: fields[1], steamAppID: int.Parse(fields[2]),
                requiredAge: int.Parse(fields[3]),
                detailedDescription: fields[5], headerImage: fields[9], isInstalled: isinstall
            );
            game.BackgroundImage = temppath;
            return game;

        }
    }
}
