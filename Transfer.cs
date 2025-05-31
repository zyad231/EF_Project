using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Project
{
    [Table("Transfer")]
    internal class Transfer
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(WarehouseFromID))]
        public int WarehouseFromID { get; set; }

        [ForeignKey(nameof(WarehouseToID))]
        public int WarehouseToID { get; set; }

        [ForeignKey("Supplier")]
        public int SupplierID { get; set; }

        public DateTime ProdDate { get; set; }

        public DateTime ExpDate { get; set; }

        public DateTime TransferDate { get; set; }

        // Navigation properties to represent the relationships
        public virtual Warehouse WarehouseFrom { get; set; }
        public virtual Warehouse WarehouseTo { get; set; }
        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<Transfer_Items> Transfer_Items { get; set; }

    }
}
