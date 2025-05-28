using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace EF_Project
{
    [Table("Delivery_Orders")]
    internal class DeliveryOrder
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }

        public DateTime ProdDate { get; set; }

        public DateTime ExpDate { get; set; }

        // Navigation properties to represent the relationships
        public virtual Supplier Supplier { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<Delivery_Items> Delivery_Items { get; set; }
    }
}
