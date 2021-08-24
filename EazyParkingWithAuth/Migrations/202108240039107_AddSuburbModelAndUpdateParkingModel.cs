namespace EazyParkingWithAuth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSuburbModelAndUpdateParkingModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Parkings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        SuburbId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suburbs", t => t.SuburbId, cascadeDelete: true)
                .Index(t => t.SuburbId);
            
            CreateTable(
                "dbo.Suburbs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            Sql("INSERT INTO Suburbs (Name) VALUES ('Caulfield')");
            Sql("INSERT INTO Suburbs (Name) VALUES ('Clayton')");
            Sql("INSERT INTO Suburbs (Name) VALUES ('Melbourne')");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parkings", "SuburbId", "dbo.Suburbs");
            DropIndex("dbo.Parkings", new[] { "SuburbId" });
            DropTable("dbo.Suburbs");
            DropTable("dbo.Parkings");
        }
    }
}
