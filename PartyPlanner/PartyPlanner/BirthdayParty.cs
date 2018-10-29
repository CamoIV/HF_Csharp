using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public decimal Cost { get; set; }
        public string CakeWriting { get; set; }
        public bool CakeWritingToLong { get; set; }
        private int actualLength { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
    }
}
