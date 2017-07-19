using System.Collections.Generic;

namespace BudgetMax2000.Models
{
    public class BudgetGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BudgetItem> BudgetItems { get; set; }
    }
}