namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LadingUpdate31 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Ladings", "LadingCode");
            CreateIndex("dbo.Ladings", "isLading");
            CreateIndex("dbo.Ladings", "isLadingChild");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Ladings", new[] { "isLadingChild" });
            DropIndex("dbo.Ladings", new[] { "isLading" });
            DropIndex("dbo.Ladings", new[] { "LadingCode" });
        }
    }
}
