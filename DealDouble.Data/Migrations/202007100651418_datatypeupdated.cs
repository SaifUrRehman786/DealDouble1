namespace DealDouble.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datatypeupdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Auctions", "ActualAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Auctions", "ActualAmount", c => c.String());
        }
    }
}
