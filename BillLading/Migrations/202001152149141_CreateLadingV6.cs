namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLadingV6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ladings", "LadingType", c => c.Short());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ladings", "LadingType", c => c.Short(nullable: false));
        }
    }
}
