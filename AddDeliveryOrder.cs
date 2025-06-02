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
    public partial class AddDeliveryOrder : Form
    {
        public AddDeliveryOrder()
        {
            InitializeComponent();
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
        public DateTime DeliveryDate => dateTimePicker3.Value;

        public DateTime ExpiryDate => dateTimePicker2.Value;

        public DateTime ProductionDate => dateTimePicker1.Value;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var deliveryOrder = new DeliveryOrder
            {
                WarehouseID = WarehouseID,
                SupplierID = SupplierID,
                DeliveryDate = DeliveryDate,
                ExpDate = ExpiryDate,
                ProdDate = ProductionDate
            };
            company.DeliveryOrders.Add(deliveryOrder);
            company.SaveChanges();
            MessageBox.Show("Delivery Order added successfully.");
            AddDeliveryOrder.ActiveForm.Close(); // Close the form after adding
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var deliveryOrder = company.DeliveryOrders.FirstOrDefault(d => d.ID == DeliveryOrderID);
            if (deliveryOrder != null)
            {
                deliveryOrder.WarehouseID = WarehouseID;
                deliveryOrder.SupplierID = SupplierID;
                deliveryOrder.DeliveryDate = DeliveryDate;
                deliveryOrder.ExpDate = ExpiryDate;
                deliveryOrder.ProdDate = ProductionDate;
                company.SaveChanges();
                MessageBox.Show("Delivery Order updated successfully.");
            }
            else
            {
                MessageBox.Show("Delivery Order not found.");
            }
        }
    }
}
