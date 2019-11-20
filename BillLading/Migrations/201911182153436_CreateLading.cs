namespace BillLading.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLading : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ladings",
                c => new
                    {
                        LadingID = c.Int(nullable: false, identity: true),
                        PlaceOfIssue = c.String(),
                        DateOfIssue = c.DateTime(nullable: false),
                        Sender = c.String(),
                        SenderAddress = c.String(),
                        SenderPhone = c.String(),
                        Receiver = c.String(),
                        ReceiverAddress = c.String(),
                        ReceiverPhone = c.String(),
                        Carrier = c.String(),
                        CarrierAddress = c.String(),
                        CarrierPhone = c.String(),
                        Forwarder = c.String(),
                        ForwarderAddress = c.String(),
                        ForwarderPhone = c.String(),
                        TakingOverGoodsPlace = c.String(),
                        TakingOverGoodsDate = c.DateTime(nullable: false),
                        DeliveryGoodsPlace = c.String(),
                        DeliveryGoodsDate = c.DateTime(nullable: false),
                        VehicleType = c.String(),
                        VehicleClass = c.String(),
                        VehicleNumber = c.String(),
                        VehicleDriver = c.String(),
                        ForwarderObservation = c.String(),
                        RouteFinalDestination = c.String(),
                        CustomsDeclarationNo = c.String(),
                        AnnexedDocments = c.String(),
                    })
                .PrimaryKey(t => t.LadingID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ladings");
        }
    }
}
