using BudgetMax2000.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BudgetMax2000.Controllers
{
    public class BudgetItemsController : Controller
    {
        // GET: BudgetItems
        public ActionResult Index()
        {
            //List<BudgetItem>  budgetItems
            List<BudgetItem> budgetItemsList = new List<BudgetItem>();
            budgetItemsList.Add(new BudgetItem(27500) { Name = "Mortgage Repayments" });
            budgetItemsList.Add(new BudgetItem(3800) { Name = "Council Rates" });
            budgetItemsList.Add(new BudgetItem(500) { Name = "Furniture and Appliances" });
            budgetItemsList.Add(new BudgetItem(1000) { Name = "Reno and Maintenance" });
            budgetItemsList.Add(new BudgetItem(4000) { Name = "Electricity" });
            budgetItemsList.Add(new BudgetItem(1560) { Name = "Phone and internet" });
            budgetItemsList.Add(new BudgetItem(600) { Name = "Steve mobile" });
            budgetItemsList.Add(new BudgetItem(600) { Name = "Katie mobile" });
            budgetItemsList.Add(new BudgetItem(2755) { Name = "Home insurance" });



            var budgetGroupHomeAndUtilities = new BudgetGroup() { Name = "Home and Utilities", BudgetItems = budgetItemsList };

            //ViewBag.BudgetGroup = budgetGroupHomeAndUtilities;

            return View(budgetGroupHomeAndUtilities);
        }
    }
}