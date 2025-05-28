using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF_Project
{
    [Table("Warehouse")]
    class Warehouse
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string Manager { get; set; }

        // Navigation property to represent the relationship with Product
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<DeliveryOrder> DeliveryOrders { get; set; }

        public virtual ICollection<SellingOrder> SellingOrders { get; set; }

        public virtual ICollection<Transfer> ToTransfer { get; set; }

        public virtual ICollection<Transfer> FromTransfer { get; set; }

    }
}
