using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
                Console.WriteLine(champions.Select(c => c.Numbers[3]).Average());
            }

            //5.feladat
            {
                Console.WriteLine(
                    champions.Where(c => c.Classes.SingleOrDefault() == "Mage").Count() > champions.Where(c => c.Classes.SingleOrDefault() == "Support").Count() 
                    ? "Mage" 
                    : "Support"
                    );
            }
        }
    }
}
