namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LadingV3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ladings", "DateOfIssue3", c => c.DateTime());
            AlterColumn("dbo.Ladings", "TakingOverGoodsDate8", c => c.DateTime());
            AlterColumn("dbo.Ladings", "DeliveryGoodsDate9", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ladings", "DeliveryGoodsDate9", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ladings", "TakingOverGoodsDate8", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Ladings", "DateOfIssue3", c => c.DateTime(nullable: false));
        }
    }
}
