using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EF_Project
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            EF_Trading_Company company = new EF_Trading_Company();
            var query = from Warehouse in company.Warehouses
                        select new
                        {
                            Warehouse.ID,
                            Warehouse.Name
                        };
            checkedListBox1.DataSource = query.ToList();
            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "ID";
        }
        public int RemainingDays
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int days))
                    return days;
                return -1; // Return an invalid number if parsing fails
            }
        }
        public int TimePeriod
        {
            get
            {
                if (int.TryParse(textBox2.Text, out int period))
                    return period;
                return -1; // Return an invalid number if parsing fails
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {


            EF_Trading_Company company = new EF_Trading_Company();
            if (RemainingDays < 0)
            {
                MessageBox.Show("Please enter a valid number of days greater than or equal to zero.");
                return;
            }
            var query = from item in company.Items
                        join DI in company.DeliveryItems on new { item.ID, item.WarehouseID }
                        equals new { ID = DI.ItemID, WarehouseID = DI.WarehouseID }
                        join DO in company.DeliveryOrders on DI.DeliveryOrderID equals DO.ID
                        where DO.ExpDate <= DateTime.Now.AddDays(RemainingDays)
                        select new
                        {
                            item.ID,
                            item.Name,
                            item.WarehouseID,
                            DO.DeliveryDate,
                            DO.ExpDate,
                            DI.Quantity,
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TimePeriod < 0)
            {
                MessageBox.Show("Please enter a valid time period greater than or equal to zero.");
                return;
            }
            EF_Trading_Company company = new EF_Trading_Company();
            var query = from item in company.Items
                        join DI in company.DeliveryItems on new { item.ID, item.WarehouseID }
                        equals new { ID = DI.ItemID, WarehouseID = DI.WarehouseID }
                        join DO in company.DeliveryOrders on DI.DeliveryOrderID equals DO.ID
                        where (DateTime.Now - DO.DeliveryDate).Days >= TimePeriod
                        select new
                        {
                            item.ID,
                            item.Name,
                            item.WarehouseID,
                            DO.DeliveryDate,
                            DO.ExpDate,
                            DaysInWarehouse = (DateTime.Now - DO.DeliveryDate).Days,
                            DI.Quantity,
                        };
            dataGridView1.DataSource = query.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var selectedWarehouses = checkedListBox1.CheckedItems.Cast<dynamic>().Select(item => item.Name).ToList();
            if (selectedWarehouses.Count == 0)
            {
                MessageBox.Show("Please select at least one warehouse.");
                return;
            }
            var query = from Transfer in company.Transfer
                        join TI in company.TransferItems on Transfer.ID equals TI.TransferID
                        join item in company.Items on new { ItemID = TI.ItemID, WarehouseID = TI.WarehouseID } equals new { ItemID = item.ID, WarehouseID = item.WarehouseID }
                        where selectedWarehouses.Contains(item.Warehouse.Name) &&
                        Transfer.TransferDate <= dateTimePicker1.Value.ToUniversalTime() &&
                        Transfer.TransferDate >= dateTimePicker2.Value.ToUniversalTime()
                        select new
                        {
                            TransferID = Transfer.ID,
                            Transfer.ProdDate,
                            Transfer.ExpDate,
                            ItemID = item.ID,
                            ItemName = item.Name,
                            TI.Quantity,
                            item.WarehouseID
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var selectedWarehouses = checkedListBox1.CheckedItems.Cast<dynamic>().Select(warehouse => warehouse.ID).ToList();
            if (selectedWarehouses.Count == 0)
            {
                MessageBox.Show("Please select at least one warehouse.");
                return;
            }
            var query = from DO in company.DeliveryOrders
                        join Supplier in company.Suppliers on DO.SupplierID equals Supplier.ID
                        where selectedWarehouses.Contains(DO.WarehouseID) &&
                        DO.DeliveryDate >= dateTimePicker1.Value &&
                        DO.DeliveryDate <= dateTimePicker2.Value
                        select new
                        {
                            DO.ID,
                            DO.DeliveryDate,
                            DO.ExpDate,
                            DO.WarehouseID,
                            Supplier.Name,
                        };
            dataGridView1.DataSource = query.ToList();
            var query2 = from T in company.Transfer
                         join Supplier in company.Suppliers on T.SupplierID equals Supplier.ID
                         join Warehouse in company.Warehouses on T.WarehouseFromID equals Warehouse.ID
                         where selectedWarehouses.Contains(T.WarehouseFromID) &&
                         T.TransferDate >= dateTimePicker1.Value &&
                         T.TransferDate <= dateTimePicker2.Value
                         select new
                         {
                             T.ID,
                             T.TransferDate,
                             T.ExpDate,
                             WarehouseName = Warehouse.Name,
                             SupplierName = Supplier.Name
                         };
            dataGridView2.DataSource = query2.ToList();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            EF_Trading_Company company = new EF_Trading_Company();
            var selectedWarehouses = checkedListBox1.CheckedItems.Cast<dynamic>().Select(item => item.Name).ToList();
            if (selectedWarehouses.Count == 0)
            {
                MessageBox.Show("Please select at least one warehouse.");
                return;
            }
            var query = from D in company.DeliveryOrders
                        join DI in company.DeliveryItems on D.ID equals DI.DeliveryOrderID
                        join item in company.Items on new { ItemID = DI.ItemID, WarehouseID = DI.WarehouseID } equals new { ItemID = item.ID, WarehouseID = item.WarehouseID }
                        join W in company.Warehouses on item.WarehouseID equals W.ID
                        where selectedWarehouses.Contains(item.Warehouse.Name) &&
                        D.DeliveryDate >= dateTimePicker1.Value.ToUniversalTime() &&
                        D.DeliveryDate <= dateTimePicker2.Value.ToUniversalTime()
                        select new
                        {
                            D.ID,
                            D.DeliveryDate,
                            D.ExpDate,
                            ITEMID = item.ID,
                            item.Name,
                            DI.Quantity,
                            item.WarehouseID
                        };
            dataGridView1.DataSource = query.ToList();
            var query2 = from S in company.SellingOrders
                        join SI in company.SellingItems on S.ID equals SI.SellingOrderID
                        join item in company.Items on new { ItemID = SI.ItemID, WarehouseID = SI.WarehouseID } equals new { ItemID = item.ID, WarehouseID = item.WarehouseID }
                        join W in company.Warehouses on item.WarehouseID equals W.ID
                         where selectedWarehouses.Contains(item.Warehouse.Name) &&
                        S.OrderDate >= dateTimePicker1.Value.ToUniversalTime() &&
                        S.OrderDate <= dateTimePicker2.Value.ToUniversalTime()
                        select new
                        {
                            S.ID,
                            Item_Name = item.Name,
                            S.OrderDate,
                            W.Name,
                            SI.Quantity
                            
                        };
            dataGridView2.DataSource = query2.ToList();
        }
    }
}
