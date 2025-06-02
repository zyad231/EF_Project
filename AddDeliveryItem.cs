using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class AddDeliveryItem : Form
    {
        public AddDeliveryItem()
        {
            InitializeComponent();
        }
        public int DeliveryOrderID
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Delivery Order ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public int WarehouseID
        {
            get
            {
                if (int.TryParse(textBox2.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Warehouse ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public int ItemID
        {
            get
            {
                if (int.TryParse(textBox3.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Item ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public int Quantity
        {
            get
            {
                if (int.TryParse(textBox4.Text, out int quantity))
                    return quantity;
                MessageBox.Show("Please enter a valid Quantity.");
                return -1; // Return an invalid quantity if parsing fails
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var deliveryItem = new Delivery_Items
            {
                DeliveryOrderID = DeliveryOrderID,
                WarehouseID = WarehouseID,
                ItemID = ItemID,
                Quantity = Quantity
            };
            company.DeliveryItems.Add(deliveryItem);
            var inventoryItem = company.ItemUnits.FirstOrDefault(i => i.ItemID == ItemID && i.warehouseID == WarehouseID);
            if (inventoryItem != null)
            {
                inventoryItem.Quantity += Quantity;
            }
            else
            {
                MessageBox.Show("Item not found in the specified warehouse.");
                return; // Exit if item not found
            }
            company.SaveChanges();
            MessageBox.Show("Delivery Item added successfully.");
            AddDeliveryItem.ActiveForm.Close(); // Close the form after adding
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            if (DeliveryOrderID == -1 || WarehouseID == -1 || ItemID == -1 || Quantity == -1)
                return; // Invalid ID check
            var found = company.DeliveryItems.FirstOrDefault(di => di.DeliveryOrderID == DeliveryOrderID && di.WarehouseID == WarehouseID && di.ItemID == ItemID);
            if (found == null)
            {
                MessageBox.Show("Delivery Item not found.");
                return;
            }
            found.Quantity = Quantity; // Update the quantity
            company.DeliveryItems.Add(found);
            company.SaveChanges();
            MessageBox.Show("Delivery Item updated successfully.");

        }
    }
}
