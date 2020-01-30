namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLading9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ladings", "SQ_Code", c => c.Int(nullable: false));
            AlterColumn("dbo.Ladings", "SP_Code", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ladings", "SP_Code", c => c.String(maxLength: 20));
            DropColumn("dbo.Ladings", "SQ_Code");
        }
    }
}
