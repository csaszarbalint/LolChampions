using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolChampions
{
    class Champion
    {
        public string Id;
        public string Name;
        public List<string> Classes;
        public List<int> Numbers;

        public Champion(string line)
        {
            string[] tokens = line.Split(';');

            this.Id = tokens[0];
            this.Name = tokens[1];
            this.Classes = tokens[5].
                Trim(new char[] { '[', ']' }).
                Split(',').
                ToList();
            this.Numbers = tokens[6].
                Trim(new char[] { '[', ']' }).
                Split(',').
                Select(e => int.Parse(e)).
                ToList();
        }
    }
}
