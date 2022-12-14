using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBD
{
    public class Card
    {
        public string Name { get; init; }
        public ManaCost? Cost { get; set; }
        public string? Description { get; set; }
        public List<int>? MajorTypes { get; set; }
        public List<int>? MinorTypes { get; set; }

        public int Power { get; set; }
        public int Toughness { get; set; }

        public List<int>? GameTags { get; set; }
        public string? FlavorText { get; set; }

        public List<CardAbility>? Abilities { get; set; }

        public Card(string name)
        {
            Name = name;
        }
    }
}
