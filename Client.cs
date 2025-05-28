using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project
{
    [Table("Client")]
    internal class Client
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

        // Navigation property to represent the relationship with Item
        public virtual ICollection<SellingOrder> SellingOrders { get; set; }

    }
}
