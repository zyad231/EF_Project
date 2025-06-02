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
    public partial class AddItemUnit : Form
    {
        public AddItemUnit()
        {
            InitializeComponent();
        }
        public int ItemID
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Item ID.");
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
        public string Unit
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    return textBox3.Text;
                MessageBox.Show("Please enter a valid Unit.");
                return string.Empty; // Return an empty string if validation fails
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
            if (ItemID == -1 || WarehouseID == -1 || string.IsNullOrWhiteSpace(Unit) || Quantity == -1)
            {
                return;
            }
            Item_Units newItemUnit = new Item_Units
            {
                ItemID = ItemID,
                warehouseID = WarehouseID,
                Unit = Unit,
                Quantity = Quantity
            };
            company.ItemUnits.Add(newItemUnit);
            company.SaveChanges();
            MessageBox.Show("Item Unit added successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            if (ItemID == -1 || WarehouseID == -1 || string.IsNullOrWhiteSpace(Unit) || Quantity == -1)
            {
                return;
            }
            Item_Units existingItemUnit = company.ItemUnits.FirstOrDefault(iu => iu.ItemID == ItemID && iu.warehouseID == WarehouseID && iu.Unit == Unit);
            if (existingItemUnit != null)
            {
                existingItemUnit.Quantity = Quantity;
                company.SaveChanges();
                MessageBox.Show("Item Unit updated successfully!");
            }
            else
            {
                MessageBox.Show("Item Unit not found for the given Item ID, Warehouse ID, and Unit.");
            }
        }
    }
}
