using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public decimal CostOfBeveragesPerPerson { get; set; }
        public decimal CostOfDecorations { get; set; }


        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00m;
            }
            else
            {
                CostOfBeveragesPerPerson = 25.00m;
            }
        }
        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            if (fancyDecorations)
            {
                CostOfDecorations = (NumberOfPeople * 15m) + 50m;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50m) + 30m;
            }
        }
        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            if (healthyOption)
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
