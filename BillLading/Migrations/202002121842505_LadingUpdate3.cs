namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LadingUpdate3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ladings", "LadingChildName", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ladings", "LadingChildName");
        }
    }
}
