namespace CS4790Assignment4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class vendorID2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Fruits", "VendorID", "dbo.Vendors");
            DropIndex("dbo.Fruits", new[] { "VendorID" });
            AlterColumn("dbo.Fruits", "VendorID", c => c.Int());
            CreateIndex("dbo.Fruits", "VendorID");
            AddForeignKey("dbo.Fruits", "VendorID", "dbo.Vendors", "VendorID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Fruits", "VendorID", "dbo.Vendors");
            DropIndex("dbo.Fruits", new[] { "VendorID" });
            AlterColumn("dbo.Fruits", "VendorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Fruits", "VendorID");
            AddForeignKey("dbo.Fruits", "VendorID", "dbo.Vendors", "VendorID", cascadeDelete: true);
        }
    }
}
