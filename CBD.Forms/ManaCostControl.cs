using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBD.Forms
{
    public partial class ManaCostControl : UserControl
    {
        private ManaCost internalCost;
        public ManaCost Cost
        {
            get { return internalCost; }
            set
            {
                if (value.Equals(null))
                    return;
                if (!value.Equals(internalCost))
                {
                    CostWhite = value.CostWhite;
                    CostBlue = value.CostBlue;
                    CostBlack = value.CostBlack;
                    CostRed = value.CostRed;
                    CostGreen = value.CostGreen;
                    CostColorless = value.CostColorless;
                    CostAny = value.CostAny;
                }
            }
        }

        public int CostWhite
        {
            get => internalCost.CostWhite;
            set
            {
                if (internalCost.CostWhite != value)
                {
                    internalCost.CostWhite = value;
                    nudWhite.Value = value;
                }
            }
        }
        public int CostBlue
        {
            get => internalCost.CostBlue;
            set
            {
                if (internalCost.CostBlue != value)
                {
                    internalCost.CostBlue = value;
                    nudBlue.Value = value;
                }
            }
        }
        public int CostBlack
        {
            get => internalCost.CostBlack;
            set
            {
                if (internalCost.CostBlack != value)
                {
                    internalCost.CostBlack = value;
                    nudBlack.Value = value;
                }
            }
        }
        public int CostRed
        {
            get => internalCost.CostRed;
            set
            {
                if (internalCost.CostRed != value)
                {
                    internalCost.CostRed = value;
                    nudRed.Value = value;
                }
            }
        }
        public int CostGreen
        {
            get => internalCost.CostGreen;
            set
            {
                if (internalCost.CostGreen != value)
                {
                    internalCost.CostGreen = value;
                    nudGreen.Value = value;
                }
            }
        }
        public int CostColorless
        {
            get => internalCost.CostColorless;
            set
            {
                if (internalCost.CostColorless != value)
                {
                    internalCost.CostColorless = value;
                    nudColorless.Value = value;
                }
            }
        }
        public int CostAny
        {
            get => internalCost.CostAny;
            set
            {
                if (internalCost.CostAny != value)
                {
                    internalCost.CostAny = value;
                    nudAnyColor.Value = value;
                }
            }
        }

        public ManaCostControl()
        {
            InitializeComponent();
            Cost = new();
        }

        public ManaCostControl(ManaCost cost)
        {
            InitializeComponent();
            Cost = cost;
        }

        private void nudWhite_ValueChanged(object sender, EventArgs e)
        {
            CostWhite = (int)nudWhite.Value;
        }
        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            CostBlue = (int)nudBlue.Value;
        }
        private void nudBlack_ValueChanged(object sender, EventArgs e)
        {
            CostBlack = (int)nudBlack.Value;
        }
        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
            CostRed = (int)nudRed.Value;
        }
        private void nudGreen_ValueChanged(object sender, EventArgs e)
        {
            CostGreen = (int)nudGreen.Value;
        }
        private void nudColorless_ValueChanged(object sender, EventArgs e)
        {
            CostColorless = (int)nudColorless.Value;
        }
        private void nudAnyColor_ValueChanged(object sender, EventArgs e)
        {
            CostAny = (int)nudAnyColor.Value;
        }
    }
}
