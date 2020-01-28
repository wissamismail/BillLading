namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLading1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ladings", "LadingCode", c => c.Int(nullable: false));
            AddColumn("dbo.Ladings", "isLading", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ladings", "isLading");
            DropColumn("dbo.Ladings", "LadingCode");
        }
    }
}
