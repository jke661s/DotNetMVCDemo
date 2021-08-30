namespace EazyParkingWithAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAvailableAmountForParking : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Parkings", "AvailableAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Parkings", "AvailableAmount");
        }
    }
}
