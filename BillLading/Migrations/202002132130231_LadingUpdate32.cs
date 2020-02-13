namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LadingUpdate32 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ladings", "SP_AdvanceDelivered", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ladings", "SP_AdvanceDelivered");
        }
    }
}
