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
    public partial class AddTransferOrder : Form
    {
        public AddTransferOrder()
        {
            InitializeComponent();
        }
        public int TransferOrderID
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Transfer Order ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public int SourceWarehouseID
        {
            get
            {
                if (int.TryParse(textBox2.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Source Warehouse ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public int DestinationWarehouseID
        {
            get
            {
                if (int.TryParse(textBox3.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Destination Warehouse ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public int SupplierID
        {
            get
            {
                if (int.TryParse(textBox4.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Supplier ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }
        public DateTime ProdDate => dateTimePicker1.Value;
        public DateTime ExpDate => dateTimePicker2.Value;
        public DateTime TransferDate => dateTimePicker3.Value;

        private void button1_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            if (SourceWarehouseID == -1 || DestinationWarehouseID == -1 || SupplierID == -1 || TransferOrderID == -1)
                return; // Invalid ID check
            var transferOrder = new Transfer
            {
                WarehouseFromID = SourceWarehouseID,
                WarehouseToID = DestinationWarehouseID,
                SupplierID = SupplierID,
                ProdDate = ProdDate,
                ExpDate = ExpDate,
                TransferDate = TransferDate
            };
            company.Transfer.Add(transferOrder);
            company.SaveChanges();
            MessageBox.Show("Transfer Order added successfully.");
            AddTransferOrder.ActiveForm.Close(); // Close the form after adding
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            if (TransferOrderID == -1)
                return; // Invalid ID check
            var found = company.Transfer.FirstOrDefault(t => t.ID == TransferOrderID);
            if (found != null)
            {
                found.WarehouseFromID = SourceWarehouseID;
                found.WarehouseToID = DestinationWarehouseID;
                found.SupplierID = SupplierID;
                found.ProdDate = ProdDate;
                found.ExpDate = ExpDate;
                found.TransferDate = TransferDate;
                company.SaveChanges();
                MessageBox.Show("Transfer Order updated successfully.");
            }
            else
            {
                MessageBox.Show("Transfer Order not found.");
            }
        }
    }
}
