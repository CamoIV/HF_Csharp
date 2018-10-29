using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }

        public decimal Cost
        {
            get
            {
                decimal totalCost;
                totalCost = CalculateCostOfDecorations() + (CalculateCostOfBeveragePerPerson() + 25) * NumberOfPeople;

                if (HealthyOption)
                {
                    return totalCost * .95m;
                }
                else
                {
                    return totalCost;
                }
            }
        }

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecoration;

            if (FancyDecorations)
            {
                costOfDecoration = (NumberOfPeople * 15m) + 50m;
            }
            else
            {
                costOfDecoration = (NumberOfPeople * 7.50m) + 30m;
            }

            return costOfDecoration;
        }
        private decimal CalculateCostOfBeveragePerPerson()
        {
            decimal costOfBeverage;

            if (HealthyOption)
            {
                costOfBeverage = 5.00m;
            }
            else
            {
                costOfBeverage = 20.00m;
            }

            return costOfBeverage;
        }
    }
}
