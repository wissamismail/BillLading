using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillLading
{
    public class Lading
    {
        [Key]
        public int LadingID { get; set; }
        [StringLength(15)]
        public string LadingType { get; set; }
        [Index]
        public int LadingCode { get; set; }
        [Index]
        public Boolean isLading { get; set; }
        [Index]
        public Boolean isLadingChild { get; set; }

        [StringLength(5)]
        public string LadingChildName { get; set; }

        [StringLength(255)]
        public string PlaceOfIssue2 { get; set; }

        public Nullable<DateTime> DateOfIssue3 { get; set; }

        [StringLength(255)]
        public string Sender4 { get; set; }

        [StringLength(255)]
        public string SenderAddress4 { get; set; }

        [StringLength(255)]
        public string SenderPhone4 { get; set; }

        [StringLength(255)]
        public string Receiver5 { get; set; }

        [StringLength(255)]
        public string ReceiverAddress5 { get; set; }

        [StringLength(255)]
        public string ReceiverPhone5 { get; set; }

        [StringLength(255)]
        public string Carrier6 { get; set; }
        [StringLength(255)]
        public string CarrierAddress6 { get; set; }
        [StringLength(255)]
        public string CarrierPhone6 { get; set; }

        [StringLength(255)]
        public string Forwarder7 { get; set; }
        [StringLength(255)]
        public string ForwarderAddress7 { get; set; }
        [StringLength(255)]
        public string ForwarderPhone7 { get; set; }

        [StringLength(255)]
        public string TakingOverGoodsPlace8 { get; set; }
        public Nullable<DateTime> TakingOverGoodsDate8 { get; set; }

        [StringLength(255)]
        public string DeliveryGoodsPlace9 { get; set; }
        public Nullable<DateTime> DeliveryGoodsDate9 { get; set; }

        [StringLength(255)]
        public string VehicleType10 { get; set; }
        [StringLength(255)]
        public string VehicleClass10 { get; set; }
        [StringLength(255)]
        public string VehicleNumber10 { get; set; }
        [StringLength(255)]
        public string VehicleDriver10 { get; set; }

        [StringLength(255)]
        public string ForwarderObservation11 { get; set; }
        [StringLength(255)]
        public string RouteFinalDestination12 { get; set; }
        [StringLength(255)]
        public string CustomsDeclarationNo13 { get; set; }
        [StringLength(255)]
        public string AnnexedDocments14 { get; set; }

        [StringLength(255)]
        public string MarksNos15 { get; set; }
        [StringLength(255)]
        public string NoOfPackages16 { get; set; }
        [StringLength(255)]
        public string MethodOfPacking17 { get; set; }
        [StringLength(255)]
        public string NatureOfGoods18 { get; set; }
        [StringLength(100)]
        public string TariffCode19_1 { get; set; }
        [StringLength(100)]
        public string GrossWeight20_1 { get; set; }
        [StringLength(100)]
        public string Volume21_1 { get; set; }
        [StringLength(100)]
        public string TariffCode19_2 { get; set; }
        [StringLength(100)]
        public string GrossWeight20_2 { get; set; }
        [StringLength(100)]
        public string Volume21_2 { get; set; }
        [StringLength(100)]
        public string TariffCode19_3 { get; set; }
        [StringLength(100)]
        public string GrossWeight20_3 { get; set; }
        [StringLength(100)]
        public string Volume21_3 { get; set; }
        [StringLength(100)]
        public string TariffCode19_4 { get; set; }
        [StringLength(100)]
        public string GrossWeight20_4 { get; set; }
        [StringLength(100)]
        public string Volume21_4 { get; set; }

        [StringLength(255)]
        public string DangerousGoodsInstructions22 { get; set; }
        [StringLength(255)]
        public string DangerousGoodsClass22 { get; set; }
        [StringLength(255)]
        public string DangerousGoodsCode22 { get; set; }

        [StringLength(255)]
        public string SendersInstructions23 { get; set; }
        [StringLength(255)]
        public string DemurrageLoading24 { get; set; }
        [StringLength(255)]
        public string DemurrageDischarge25 { get; set; }

        [StringLength(150)]
        public string CarriageInstructions26 { get; set; }
        [StringLength(150)]
        public string CarriagePaid26 { get; set; }
        [StringLength(150)]
        public string CarriageForward26 { get; set; }
        [StringLength(255)]
        public string SpecialAgreements28 { get; set; }
        [StringLength(100)]
        public string CachonDelivery29 { get; set; }

        [StringLength(15)]
        public string CarriageChargesSender27 { get; set; }
        [StringLength(15)]
        public string CarriageChargesCurrency27 { get; set; }
        [StringLength(50)]
        public string CarriageChargesConsignee27 { get; set; }
        [StringLength(15)]
        public string DeductionsSender27 { get; set; }
        [StringLength(15)]
        public string DeductionsCurrency27 { get; set; }
        [StringLength(50)]
        public string DeductionsConsignee27 { get; set; }
        [StringLength(15)]
        public string SupplChargesSender27 { get; set; }
        [StringLength(15)]
        public string SupplChargesCurrency27 { get; set; }
        [StringLength(50)]
        public string SupplChargesConsignee27 { get; set; }
        [StringLength(15)]
        public string OtherChargesSender27 { get; set; }
        [StringLength(15)]
        public string OtherChargesCurrency27 { get; set; }
        [StringLength(50)]
        public string OtherChargesConsignee27 { get; set; }
        [StringLength(100)]
        public string GoodsReceivedPlace32 { get; set; }
        public Nullable<DateTime> GoodsReceivedDate32 { get; set; }
        [StringLength(30)]
        public string NoCopies33 { get; set; }

        public int SP_Code { get; set; }
        [StringLength(50)]
        public string SP_Reference { get; set; }
        public Nullable<DateTime> SP_AdvanceDate { get; set; }
        [StringLength(150)]
        public string SP_AdvanceValue { get; set; }
        [StringLength(10)]
        public string SP_AdvanceType { get; set; }
        public Boolean SP_AdvanceDelivered { get; set; }

        [StringLength(100)]
        public string SQ_Reference { get; set; }
        [StringLength(150)]
        public string SQ_Customer { get; set; }
        public int SQ_Code { get; set; }
    }
}
