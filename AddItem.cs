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
    public partial class AddItem : Form
    {
        public AddItem()
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

        public string ItemName 
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    return textBox3.Text;
                MessageBox.Show("Please enter a valid Item Name.");
                return string.Empty; // Return an empty string if validation fails
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            if (WarehouseID == -1 || ItemID == -1)
                return; // Invalid ID check
            var found = company.Items.FirstOrDefault(i => i.ID == ItemID && i.WarehouseID == WarehouseID);
            if (found == null)
            {
                MessageBox.Show("Item not found in the specified warehouse.");
                return;
            }
            else
            {
                found.Name = ItemName;
                company.SaveChanges();
                MessageBox.Show("Item updated successfully.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (WarehouseID == -1 || ItemID == -1)
                return; // Invalid ID check
            EF_Trading_Company company = new EF_Trading_Company();
            Item item = new Item
            {
                ID = ItemID,
                WarehouseID = WarehouseID,
                Name = ItemName
            };
            company.Items.Add(item);
            company.SaveChanges();
            MessageBox.Show("Item added successfully.");
        }
    }
}
