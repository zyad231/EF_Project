using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project
{
    [Table("selling_items")]
    internal class Selling_Items
    {
        [ForeignKey("SellingOrder")]
        public int SellingOrderID { get; set; }
        [ForeignKey("Item")]
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        // Navigation properties to represent the relationships
        public virtual SellingOrder SellingOrder { get; set; }
        
        public virtual Item Item { get; set; }

    }
}
