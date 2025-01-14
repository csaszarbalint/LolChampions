using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace LolChampions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Champion> champions = new List<Champion>();

            foreach(string row in File.ReadAllLines("champions.csv"))
            {
                champions.Add(new Champion(row));
            }

            //2.feladat
            {
                Console.WriteLine(champions.Count()); 
            }

            //3.feladat
            {
                Console.WriteLine(champions.Where(c => c.Classes.Contains("Fighter")).Count());
            }

            //4.feladat
            {
                Console.WriteLine(champions.Select(c => c.Difficulty).Average());
            }

            //5.feladat
            {
                Console.WriteLine(
                    champions.Where(c => c.Classes.Contains("Mage")).Count() 
                    >
                    champions.Where(c => c.Classes.Contains("Support")).Count() 
                    ? "Mage" : "Support");
            }

            //6.feladat
            {
                var result = champions
                    .OrderByDescending(c => c.Attack)
                    .GroupBy(c => c.Attack)
                    .First();
            }

            //7.feladat
            {
                var dict = champions.ToDictionary(c => c.Tag);
            }

            //8.feladat
            {
                var list = champions
                    .Select(c => new ChampRating
                    {
                        Champion = c,
                        Rating = c.Attack * 0.4 + c.Defense * 0.3 + c.Magic * 0.2 + c.Difficulty * 0.1
                    })
                    .OrderByDescending(r => r.Rating); //why not 
            }
        }
    }
}
