using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Project
{
    [Table("Delivery_Items")]
    internal class Delivery_Items
    {
        [ForeignKey("DeliveryOrder")]
        public int DeliveryOrderID { get; set; }


        public int WarehouseID { get; set; }
        public int ItemID { get; set; }

        public int Quantity { get; set; }

        // Navigation properties to represent the relationships
        public virtual DeliveryOrder DeliveryOrder { get; set; }

        public virtual Item Item { get; set; }
    }
}
