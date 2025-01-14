using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolChampions
{
    struct ChampRating
    {
        public double Rating;
        public Champion Champion;
    }
    class Champion
    {
        public string Tag;
        public string Name;
        public List<string> Classes;

        public double Attack;
        public double Defense;
        public double Magic;
        public double Difficulty;

        public Champion(string line) : base()
        {
            string[] tokens = line.Split(';');

            this.Tag = tokens[0];
            this.Name = tokens[1];
            this.Classes = tokens[5].
                Trim(new char[] { '[', ']' }).
                Split(',').
                ToList();

            var numbers = tokens[6].
                Trim(new char[] { '[', ']' }).
                Split(',').
                Select(e => int.Parse(e)).
                ToList();
            this.Attack = numbers[0];
            this.Defense = numbers[1];
            this.Magic = numbers[2];
            this.Difficulty = numbers[3];
        }

        public Champion() 
        {
            Classes = new List<string>();
        }
    }
}
