namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLadingV4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ladings", "CarriageChargesSender27", c => c.String(maxLength: 15));
            AddColumn("dbo.Ladings", "CarriageChargesCurrency27", c => c.String(maxLength: 15));
            AddColumn("dbo.Ladings", "CarriageChargesConsignee27", c => c.String(maxLength: 50));
            AddColumn("dbo.Ladings", "DeductionsSender27", c => c.String(maxLength: 15));
            AddColumn("dbo.Ladings", "DeductionsCurrency27", c => c.String(maxLength: 15));
            AddColumn("dbo.Ladings", "DeductionsConsignee27", c => c.String(maxLength: 50));
            AddColumn("dbo.Ladings", "SupplChargesSender27", c => c.String(maxLength: 15));
            AddColumn("dbo.Ladings", "SupplChargesCurrency27", c => c.String(maxLength: 15));
            AddColumn("dbo.Ladings", "SupplChargesConsignee27", c => c.String(maxLength: 50));
            AddColumn("dbo.Ladings", "OtherChargesSender27", c => c.String(maxLength: 15));
            AddColumn("dbo.Ladings", "OtherChargesCurrency27", c => c.String(maxLength: 15));
            AddColumn("dbo.Ladings", "OtherChargesConsignee27", c => c.String(maxLength: 50));
            AddColumn("dbo.Ladings", "GoodsReceivedPlace32", c => c.String(maxLength: 100));
            AddColumn("dbo.Ladings", "GoodsReceivedDate32", c => c.DateTime());
            AddColumn("dbo.Ladings", "NoCopies33", c => c.String(maxLength: 30));
            AlterColumn("dbo.Ladings", "CarriageInstructions26", c => c.String(maxLength: 150));
            AlterColumn("dbo.Ladings", "CarriagePaid26", c => c.String(maxLength: 150));
            AlterColumn("dbo.Ladings", "CarriageForward26", c => c.String(maxLength: 150));
            AlterColumn("dbo.Ladings", "CachonDelivery29", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ladings", "CachonDelivery29", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "CarriageForward26", c => c.String(maxLength: 1));
            AlterColumn("dbo.Ladings", "CarriagePaid26", c => c.String(maxLength: 1));
            AlterColumn("dbo.Ladings", "CarriageInstructions26", c => c.String(maxLength: 255));
            DropColumn("dbo.Ladings", "NoCopies33");
            DropColumn("dbo.Ladings", "GoodsReceivedDate32");
            DropColumn("dbo.Ladings", "GoodsReceivedPlace32");
            DropColumn("dbo.Ladings", "OtherChargesConsignee27");
            DropColumn("dbo.Ladings", "OtherChargesCurrency27");
            DropColumn("dbo.Ladings", "OtherChargesSender27");
            DropColumn("dbo.Ladings", "SupplChargesConsignee27");
            DropColumn("dbo.Ladings", "SupplChargesCurrency27");
            DropColumn("dbo.Ladings", "SupplChargesSender27");
            DropColumn("dbo.Ladings", "DeductionsConsignee27");
            DropColumn("dbo.Ladings", "DeductionsCurrency27");
            DropColumn("dbo.Ladings", "DeductionsSender27");
            DropColumn("dbo.Ladings", "CarriageChargesConsignee27");
            DropColumn("dbo.Ladings", "CarriageChargesCurrency27");
            DropColumn("dbo.Ladings", "CarriageChargesSender27");
        }
    }
}
