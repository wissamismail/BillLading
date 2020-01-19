namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLadingV5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ladings", "LadingType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ladings", "LadingType");
        }
    }
}
