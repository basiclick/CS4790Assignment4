namespace CS4790Assignment4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vendorID : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fruits",
                c => new
                    {
                        FruitID = c.Int(nullable: false, identity: true),
                        FruitTitle = c.String(),
                        Contributor = c.String(),
                        Popularity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, storeType: "money"),
                        FruitPic = c.String(),
                        VendorID = c.Int(),
                    })
                .PrimaryKey(t => t.FruitID)
                .ForeignKey("dbo.Vendors", t => t.VendorID, cascadeDelete: true)
                .Index(t => t.VendorID);
            
            CreateTable(
                "dbo.Vendors",
                c => new
                    {
                        VendorID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        VendorName = c.String(nullable: false),
                        CreditCardNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VendorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fruits", "VendorID", "dbo.Vendors");
            DropIndex("dbo.Fruits", new[] { "VendorID" });
            DropTable("dbo.Vendors");
            DropTable("dbo.Fruits");
        }
    }
}
