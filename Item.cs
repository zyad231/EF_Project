using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Project
{
    [Table("Item")]
    internal class Item
    {
        
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        
        [ForeignKey("Warehouse")]
        public int WarehouseID { get; set; }

        public int Item_UnitsID { get; set; } 

        // Navigation property to represent the relationship with Warehouse
        public virtual Warehouse Warehouse { get; set; }

        //Navigation property to represent the relationship with Item_Units
        public virtual Item_Units Item_Units { get; set; }
    }
}
