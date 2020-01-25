namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLadingV8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ladings", "SQ_Reference", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "SQ_Customer", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ladings", "SQ_Customer");
            DropColumn("dbo.Ladings", "SQ_Reference");
        }
    }
}
