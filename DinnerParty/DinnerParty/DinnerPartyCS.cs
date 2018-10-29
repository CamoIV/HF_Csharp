using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty1._2
{
    class DinnerPartyCS
    {
        public int NumberOfPeople { get; set; }
        public bool HealthyOption { get; set; }
        public bool FancyDecorations { get; set; }


        public DinnerPartyCS(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.HealthyOption = healthyOption;
            this.FancyDecorations = fancyDecorations;
        }

        private decimal calculateCostOfDecorations()
        {
            decimal costOfDecorations;

            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15m) + 50m;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50m) + 30m;
            }

            return costOfDecorations;
        }
        private decimal calculateCostOfBeveragePerPerson()
        {
            decimal costOfBeverage;

            if (HealthyOption)
            {
                costOfBeverage = 5.00m;
            }
            else
            {
                costOfBeverage = 25.00m;
            }

            return costOfBeverage;
        }

        public decimal Cost
        {
            get
            {
                decimal totalCost;
                totalCost = calculateCostOfDecorations() + ((calculateCostOfBeveragePerPerson() + 25m) * NumberOfPeople);

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
    }
}
