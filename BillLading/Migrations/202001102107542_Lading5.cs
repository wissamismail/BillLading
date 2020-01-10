namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lading5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ladings", "TariffCode19_2", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "GrossWeight20_2", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "Volume21_2", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "TariffCode19_3", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "GrossWeight20_3", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "Volume21_3", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "TariffCode19_4", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "GrossWeight20_4", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "Volume21_4", c => c.String(maxLength: 100));
            AlterColumn("dbo.Ladings", "TariffCode19_1", c => c.String(maxLength: 100));
            AlterColumn("dbo.Ladings", "GrossWeight20_1", c => c.String(maxLength: 100));
            AlterColumn("dbo.Ladings", "Volume21_1", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ladings", "Volume21_1", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "GrossWeight20_1", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "TariffCode19_1", c => c.String(maxLength: 255));
            DropColumn("dbo.Ladings", "Volume21_4");
            DropColumn("dbo.Ladings", "GrossWeight20_4");
            DropColumn("dbo.Ladings", "TariffCode19_4");
            DropColumn("dbo.Ladings", "Volume21_3");
            DropColumn("dbo.Ladings", "GrossWeight20_3");
            DropColumn("dbo.Ladings", "TariffCode19_3");
            DropColumn("dbo.Ladings", "Volume21_2");
            DropColumn("dbo.Ladings", "GrossWeight20_2");
            DropColumn("dbo.Ladings", "TariffCode19_2");
        }
    }
}
