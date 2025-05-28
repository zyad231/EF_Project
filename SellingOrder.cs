using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Project
{
    [Table("selling_orders")]
    internal class SellingOrder
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Client")]
        public int ClientID { get; set; }

        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }
        public DateTime OrderDate { get; set; }

        // Navigation properties to represent the relationships
        public virtual Client Client { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Selling_Items> Selling_Items { get; set; } 

    }
}
