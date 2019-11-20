namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lading : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ladings", "PlaceOfIssue", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "Sender", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "SenderAddress", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "SenderPhone", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "Receiver", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "ReceiverAddress", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "ReceiverPhone", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "Carrier", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "CarrierAddress", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "CarrierPhone", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "Forwarder", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "ForwarderAddress", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "ForwarderPhone", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "TakingOverGoodsPlace", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "DeliveryGoodsPlace", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "VehicleType", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "VehicleClass", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "VehicleNumber", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "VehicleDriver", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "ForwarderObservation", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "RouteFinalDestination", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "CustomsDeclarationNo", c => c.String(maxLength: 255));
            AlterColumn("dbo.Ladings", "AnnexedDocments", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ladings", "AnnexedDocments", c => c.String());
            AlterColumn("dbo.Ladings", "CustomsDeclarationNo", c => c.String());
            AlterColumn("dbo.Ladings", "RouteFinalDestination", c => c.String());
            AlterColumn("dbo.Ladings", "ForwarderObservation", c => c.String());
            AlterColumn("dbo.Ladings", "VehicleDriver", c => c.String());
            AlterColumn("dbo.Ladings", "VehicleNumber", c => c.String());
            AlterColumn("dbo.Ladings", "VehicleClass", c => c.String());
            AlterColumn("dbo.Ladings", "VehicleType", c => c.String());
            AlterColumn("dbo.Ladings", "DeliveryGoodsPlace", c => c.String());
            AlterColumn("dbo.Ladings", "TakingOverGoodsPlace", c => c.String());
            AlterColumn("dbo.Ladings", "ForwarderPhone", c => c.String());
            AlterColumn("dbo.Ladings", "ForwarderAddress", c => c.String());
            AlterColumn("dbo.Ladings", "Forwarder", c => c.String());
            AlterColumn("dbo.Ladings", "CarrierPhone", c => c.String());
            AlterColumn("dbo.Ladings", "CarrierAddress", c => c.String());
            AlterColumn("dbo.Ladings", "Carrier", c => c.String());
            AlterColumn("dbo.Ladings", "ReceiverPhone", c => c.String());
            AlterColumn("dbo.Ladings", "ReceiverAddress", c => c.String());
            AlterColumn("dbo.Ladings", "Receiver", c => c.String());
            AlterColumn("dbo.Ladings", "SenderPhone", c => c.String());
            AlterColumn("dbo.Ladings", "SenderAddress", c => c.String());
            AlterColumn("dbo.Ladings", "Sender", c => c.String());
            AlterColumn("dbo.Ladings", "PlaceOfIssue", c => c.String());
        }
    }
}
