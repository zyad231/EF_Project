using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Project
{
    [Table("Item_Units")]
    internal class Item_Units
    {
        public int ItemID { get; set; }

        public int warehouseID { get; set; }

        [MaxLength(50)]
        public string Unit { get; set; }

        //Navigation property to represent the relationship with Item
        public virtual Item Item { get; set; }

    }
}
