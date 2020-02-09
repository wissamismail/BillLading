namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LadingUpdate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ladings", "SP_AdvanceValue", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ladings", "SP_AdvanceValue", c => c.Int(nullable: false));
        }
    }
}
