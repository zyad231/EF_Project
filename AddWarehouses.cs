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
    public partial class AddWarehouses : Form
    {
        public AddWarehouses()
        {
            InitializeComponent();
        }
        public int WarehouseID => int.Parse(textBox1.Text);

        public string WarehouseName => textBox2.Text;

        public string WarehouseAddress => textBox3.Text;

        public string WarehouseManager => textBox4.Text;

        private void button1_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var warehouse = new Warehouse
            {
                Name = WarehouseName,
                Address = WarehouseAddress,
                Manager = WarehouseManager
            };
            company.Warehouses.Add(warehouse);
            company.SaveChanges();
            MessageBox.Show("Warehouse added successfully.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var found = company.Warehouses.FirstOrDefault(w => w.ID == WarehouseID);
            if (found == null)
            {
                MessageBox.Show("Warehouse not found.");
                return;
            }
            else
            {
                found.Name = WarehouseName;
                found.Address = WarehouseAddress;
                found.Manager = WarehouseManager;
                company.SaveChanges();
                MessageBox.Show("Warehouse updated successfully.");
            }

        }
    }
}
