namespace EazyParkingWithAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (10, 3, 10)");
            Sql("INSERT INTO MembershipTypes (SignUpFee, DurationInMonths, DiscountRate) VALUES (30, 12, 15)");
        }

        public override void Down()
        {
        }
    }
}
