namespace CBD.Cards
{
    public struct ManaCost
    {
        public int CostWhite { get; set; } = 0;
        public int CostBlue { get; set; } = 0;
        public int CostBlack { get; set; } = 0;
        public int CostRed { get; set; } = 0;
        public int CostGreen { get; set; } = 0;
        public int CostColorless { get; set; } = 0;
        public int CostAny { get; set; } = 0;
        public ManaCost()
        {
            CostWhite = 0;
            CostBlue = 0;
            CostBlack = 0;
            CostRed = 0;
            CostGreen = 0;
            CostColorless = 0;
            CostAny = 0;
        }
        public ManaCost(int white, int blue, int black, int red, int green, int colorless, int any)
        {
            CostWhite = white;
            CostBlue = blue;
            CostBlack = black;
            CostRed = red;
            CostGreen = green;
            CostColorless = colorless;
            CostAny = any;
        }
        public int ConvertedCost { get
            {
                return CostWhite + CostBlue + CostBlack + CostRed + CostGreen + CostColorless + CostAny;
            } }
    }

    public class CardAbility
    {
        public ManaCost Cost;
        public string? Description;
        public bool IsTap;
        public List<int>? GameTags;
    }

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

        public Card(string name)
        {
            Name = name;
        }
    }

    public class CardDictionary
    {
        public Dictionary<string, Card> Dictionary { get; set; } = new();
    }

    public class CardLibrary
    {
        public Dictionary<string, int> Library { get; set; } = new();
    }
}