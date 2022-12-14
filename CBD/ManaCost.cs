using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBD
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
        public int ConvertedCost
        {
            get
            {
                return CostWhite + CostBlue + CostBlack + CostRed + CostGreen + CostColorless + CostAny;
            }
        }
    }
}
