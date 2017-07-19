using System.Diagnostics;

namespace BudgetMax2000.Models
{
    public class BudgetItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal AnnualCost { get; set; }

        public decimal MonthlyCost { get; set; }

        public decimal WeeklyCost { get; set; }

        public BudgetItem(decimal AnnualCost)
        {
            //if (AnnualCost != 0)
            //{
            this.AnnualCost = AnnualCost;
            this.MonthlyCost = AnnualCost / 12;
            this.WeeklyCost = AnnualCost / 52;
            Debug.Write("Set MonthlyCost = " + MonthlyCost);
            Debug.Write("Set this.MonthlyCost = " + this.MonthlyCost);

            //}
            //else
            //{
            //    this.MonthlyCost = 0;
            //    this.WeeklyCost = 0;
            //}


        }


    }


}