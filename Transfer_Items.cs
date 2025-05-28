using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Project
{
    [Table("transfer_items")]
    internal class Transfer_Items
    {
        [ForeignKey("Transfer")]
        public int TransferID { get; set; }
        
        public int WarehouseID { get; set; }

        public int ItemID { get; set; }
        
        public int Quantity { get; set; }
        
        // Navigation properties to represent the relationships
        public virtual Transfer Transfer { get; set; }
        
        public virtual Item Item { get; set; }
    }
}
