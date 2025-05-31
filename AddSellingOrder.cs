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
    public partial class AddSellingOrder : Form
    {
        public AddSellingOrder()
        {
            InitializeComponent();
        }

        public int OrderID
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Order ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public int ClientID
        {
            get
            {
                if (int.TryParse(textBox2.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Client ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public int SupplierID
        {
            get
            {
                if (int.TryParse(textBox3.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Supplier ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public int WarehouseID
        {
            get
            {
                if (int.TryParse(textBox4.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Warehouse ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public DateTime OrderDate => dateTimePicker1.Value;

        private void button1_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            if (OrderID == -1 || ClientID == -1 || SupplierID == -1 || WarehouseID == -1)
                return; // Invalid ID check
            SellingOrder sellingOrder = new SellingOrder
            {
                ClientID = ClientID,
                SupplierID = SupplierID,
                WarehouseID = WarehouseID,
                OrderDate = OrderDate
            };
            company.SellingOrders.Add(sellingOrder);
            company.SaveChanges();
            MessageBox.Show("Selling Order added successfully.");
            AddSellingOrder.ActiveForm.Close(); // Close the form after adding
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            if (OrderID == -1 || ClientID == -1 || SupplierID == -1 || WarehouseID == -1)
                return; // Invalid ID check
            var found = company.SellingOrders.FirstOrDefault(o => o.ID == OrderID && o.ClientID == ClientID && o.SupplierID == SupplierID && o.WarehouseID == WarehouseID);
            if (found != null)
            {
                found.ClientID = ClientID;
                found.SupplierID = SupplierID;
                found.WarehouseID = WarehouseID;
                found.OrderDate = OrderDate;
                company.SaveChanges();
                MessageBox.Show("Selling Order updated successfully.");
            }
            else
            {
                MessageBox.Show("Selling Order not found.");
            }

        }
    }
}
