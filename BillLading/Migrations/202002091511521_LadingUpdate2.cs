namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LadingUpdate2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ladings", "isLadingChild", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ladings", "isLadingChild");
        }
    }
}
