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

        public int ItemID => int.Parse(textBox1.Text);

        public int WarehouseId => int.Parse(textBox2.Text);

        public string ItemName => textBox3.Text;

        public string ItemUnit => textBox4.Text;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var IU = new Item_Units();
            var foundID = company.Items.FirstOrDefault(i => i.ID == ItemID && i.WarehouseID == WarehouseId);
            if (foundID == null)
            {
                MessageBox.Show("Item not found in the specified warehouse.");
                return;
            }
            else
            {
                IU.ItemID = ItemID;
                IU.Unit = ItemUnit;
                IU.warehouseID = WarehouseId;
                company.ItemUnits.Add(IU);
                company.SaveChanges();
                MessageBox.Show("Unit added successfully.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var found = company.Items.FirstOrDefault(i => i.ID == ItemID && i.WarehouseID == WarehouseId);
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
            EF_Trading_Company company = new EF_Trading_Company();
            Item item = new Item
            {
                ID = ItemID,
                WarehouseID = WarehouseId,
                Name = ItemName
            };
            company.Items.Add(item);
            company.SaveChanges();
            MessageBox.Show("Item added successfully.");
        }
    }
}
