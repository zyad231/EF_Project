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
        public int WarehouseID
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Warehouse ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }

        public string WarehouseName 
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    return textBox2.Text;
                MessageBox.Show("Please enter a valid Warehouse Name.");
                return string.Empty; // Return an empty string if validation fails
            }
        }

        public string WarehouseAddress 
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    return textBox3.Text;
                MessageBox.Show("Please enter a valid Warehouse Address.");
                return string.Empty; // Return an empty string if validation fails
            }
        }

        public string WarehouseManager 
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                    return textBox4.Text;
                MessageBox.Show("Please enter a valid Warehouse Manager.");
                return string.Empty; // Return an empty string if validation fails
            }
        }

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
            if (WarehouseID == -1) 
                return; // Invalid ID check
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
                AddWarehouses.ActiveForm.Close(); // Close the form after updating
            }

        }
    }
}
