using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EF_Project
{
    [Table("Supplier")]
    internal class Supplier
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        public string Website { get; set; }

        [MaxLength(50)]
        public string Mobile { get; set; }

        // Navigation property to represent the relationships
        public virtual ICollection<DeliveryOrder> DeliveryOrders { get; set; }
        public virtual ICollection<SellingOrder> SellingOrders { get; set; }
        public virtual ICollection<Selling_Items> Selling_Items { get; set; }
    }
}
