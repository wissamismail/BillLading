using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillLading
{
    public class Lading
    {
        [Key]
        public int LadingID { get; set; }

        [StringLength(255)]
        public string PlaceOfIssue { get; set; }

        public DateTime DateOfIssue { get; set; }

        [StringLength(255)]
        public string Sender { get; set; }

        [StringLength(255)]
        public string SenderAddress { get; set; }

        [StringLength(255)]
        public string SenderPhone { get; set; }

        [StringLength(255)]
        public string Receiver { get; set; }

        [StringLength(255)]
        public string ReceiverAddress { get; set; }

        [StringLength(255)]
        public string ReceiverPhone { get; set; }

        [StringLength(255)]
        public string Carrier { get; set; }
        [StringLength(255)]
        public string CarrierAddress { get; set; }
        [StringLength(255)]
        public string CarrierPhone { get; set; }

        [StringLength(255)]
        public string Forwarder { get; set; }
        [StringLength(255)]
        public string ForwarderAddress { get; set; }
        [StringLength(255)]
        public string ForwarderPhone { get; set; }

        [StringLength(255)]
        public string TakingOverGoodsPlace { get; set; }
        public DateTime TakingOverGoodsDate { get; set; }

        [StringLength(255)]
        public string DeliveryGoodsPlace { get; set; }
        public DateTime DeliveryGoodsDate { get; set; }

        [StringLength(255)]
        public string VehicleType { get; set; }
        [StringLength(255)]
        public string VehicleClass { get; set; }
        [StringLength(255)]
        public string VehicleNumber { get; set; }
        [StringLength(255)]
        public string VehicleDriver { get; set; }

        [StringLength(255)]
        public string ForwarderObservation { get; set; }
        [StringLength(255)]
        public string RouteFinalDestination { get; set; }
        [StringLength(255)]
        public string CustomsDeclarationNo { get; set; }
        [StringLength(255)]
        public string AnnexedDocments { get; set; }
    }
}
