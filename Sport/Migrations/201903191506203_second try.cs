namespace Sport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondtry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        StreetAddress = c.String(nullable: false, maxLength: 50),
                        StreetNo = c.String(nullable: false, maxLength: 10),
                        RegionId = c.Int(nullable: false),
                        StationId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        DailyPrice = c.Decimal(nullable: false, storeType: "money"),
                        MonthlyPrice = c.Decimal(nullable: false, storeType: "money"),
                        Image = c.String(nullable: false),
                        
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .ForeignKey("dbo.Stations", t => t.StationId, cascadeDelete: true)
                .Index(t => t.RegionId)
                .Index(t => t.StationId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 200),
                        DateOfBirth = c.DateTime(nullable: false, storeType: "date"),
                        Sex = c.Int(nullable: false),
                        StreetAddress = c.String(nullable: false, maxLength: 50),
                        StreetNo = c.String(nullable: false, maxLength: 10),
                        RegionId = c.Int(nullable: false),
                        StationId = c.Int(nullable: false),
                        Phone = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.RegionId, cascadeDelete: true)
                .ForeignKey("dbo.Stations", t => t.StationId, cascadeDelete: true)
                .Index(t => t.RegionId)
                .Index(t => t.StationId);
            
            CreateTable(
                "dbo.Stations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "StationId", "dbo.Stations");
            DropForeignKey("dbo.Locations", "StationId", "dbo.Stations");
            DropForeignKey("dbo.Users", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Locations", "RegionId", "dbo.Regions");
            DropForeignKey("dbo.Locations", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Users", new[] { "StationId" });
            DropIndex("dbo.Users", new[] { "RegionId" });
            DropIndex("dbo.Locations", new[] { "CategoryId" });
            DropIndex("dbo.Locations", new[] { "StationId" });
            DropIndex("dbo.Locations", new[] { "RegionId" });
            DropTable("dbo.Stations");
            DropTable("dbo.Users");
            DropTable("dbo.Regions");
            DropTable("dbo.Locations");
            DropTable("dbo.Categories");
        }
    }
}
