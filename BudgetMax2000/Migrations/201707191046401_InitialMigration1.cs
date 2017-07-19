namespace BudgetMax2000.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BudgetItems", "AnnualCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.BudgetItems", "MonthlyCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.BudgetItems", "WeeklyCost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BudgetItems", "WeeklyCost", c => c.Double(nullable: false));
            AlterColumn("dbo.BudgetItems", "MonthlyCost", c => c.Double(nullable: false));
            AlterColumn("dbo.BudgetItems", "AnnualCost", c => c.Double(nullable: false));
        }
    }
}
