namespace CS4790Assignment4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Fruits", "Contributor", c => c.String(maxLength: 45));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Fruits", "Contributor", c => c.String());
        }
    }
}
