
namespace EF_Project
{
    public partial class Form1 : Form
    {
        EF_Trading_Company company;
        public Form1()
        {
            InitializeComponent();
            company = new EF_Trading_Company();

            // Load ComboBox with table names
            var tableNames = typeof(EF_Trading_Company)
                .GetProperties()
                .Where(p => p.PropertyType.Name.Contains("DbSet"))
                .Select(p => p.Name)
                .ToList();

            comboBox1.Items.AddRange(tableNames.ToArray());
            comboBox1.SelectedIndex = 0; // Set default selection to the first item

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData(comboBox1.SelectedItem.ToString());
        }
        private void DisplayData(string tableName)
        {
            switch (tableName)
            {
                case "Items":
                    dataGridView1.DataSource = company.Items.Select(w => new
                    {
                        w.ID,
                        w.WarehouseID,
                        w.Name
                    }).ToList();
                    break;
                case "Warehouses":
                    dataGridView1.DataSource = company.Warehouses.Select(w => new
                    {
                        w.ID,
                        w.Name,
                        w.Address,
                        w.Manager
                    }).ToList();
                    break;
                case "ItemUnits":
                    dataGridView1.DataSource = company.ItemUnits.Select(w => new
                    {
                        w.ItemID,
                        w.warehouseID,
                        w.Unit,
                        w.Quantity

                    }).ToList();
                    break;
                case "Suppliers":
                    dataGridView1.DataSource = company.Suppliers.Select(w => new
                    {
                        w.ID,
                        w.Name,
                        w.Mobile,
                        w.PhoneNumber,
                        w.Website,
                        w.Email
                    }
                    ).ToList();
                    break;
                case "Clients":
                    dataGridView1.DataSource = company.Clients.Select(w => new
                    {
                        w.ID,
                        w.Name,
                        w.Mobile,
                        w.PhoneNumber,
                        w.Website,
                        w.Email
                    }
                    ).ToList();
                    break;
                case "DeliveryOrders":
                    var queryDO = from order in company.DeliveryOrders
                                  join supplier in company.Suppliers on order.SupplierID equals supplier.ID
                                  select new
                                  {
                                      order.ID,
                                      SupplierName = supplier.Name,
                                      order.DeliveryDate,
                                      order.ExpDate,
                                      order.ProdDate
                                  };
                    dataGridView1.DataSource = queryDO.ToList();
                    break;
                case "DeliveryItems":
                    var queryDI = from item in company.DeliveryItems
                                  join order in company.DeliveryOrders on item.DeliveryOrderID equals order.ID
                                  join warehouse in company.Warehouses on order.WarehouseID equals warehouse.ID
                                  select new
                                  {
                                      DeliveryOrderID = order.ID,
                                      item.ItemID,
                                      item.Quantity,
                                      WarehouseName = warehouse.Name
                                  };
                    dataGridView1.DataSource = queryDI.ToList();
                    break;
                case "SellingOrders":
                    var querySO = from order in company.SellingOrders
                                  join client in company.Clients on order.ClientID equals client.ID
                                  select new
                                  {
                                      order.ID,
                                      ClientName = client.Name,
                                      order.OrderDate,
                                      order.WarehouseID
                                  };
                    dataGridView1.DataSource = querySO.ToList();
                    break;
                case "SellingItems":
                    var querySI = from item in company.SellingItems
                                  join order in company.SellingOrders on item.SellingOrderID equals order.ID
                                  join warehouse in company.Warehouses on order.WarehouseID equals warehouse.ID
                                  select new
                                  {
                                      SellingOrderID = order.ID,
                                      item.ItemID,
                                      item.Quantity,
                                      WarehouseName = warehouse.Name
                                  };
                    dataGridView1.DataSource = querySI.ToList();
                    break;
                case "Transfer":
                    var queryTransfer = from transfer in company.Transfer
                                        join sourceWarehouse in company.Warehouses on transfer.WarehouseFromID equals sourceWarehouse.ID
                                        join destinationWarehouse in company.Warehouses on transfer.WarehouseToID equals destinationWarehouse.ID
                                        select new
                                        {
                                            transfer.ID,
                                            SourceWarehouseName = sourceWarehouse.Name,
                                            DestinationWarehouseName = destinationWarehouse.Name,
                                            transfer.ProdDate,
                                            transfer.ExpDate,
                                            transfer.TransferDate
                                        };
                    dataGridView1.DataSource = queryTransfer.ToList();
                    break;
                case "TransferItems":
                    var queryTransferItems = from item in company.TransferItems
                                             join transfer in company.Transfer on item.TransferID equals transfer.ID
                                             join warehouse in company.Warehouses on transfer.WarehouseFromID equals warehouse.ID
                                             select new
                                             {
                                                 TransferID = transfer.ID,
                                                 item.ItemID,
                                                 item.Quantity,
                                                 WarehouseName = warehouse.Name
                                             };
                    dataGridView1.DataSource = queryTransferItems.ToList();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case ("Items"):
                    using (var form = new AddItem())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {

                        }
                        DisplayData("Items"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 0; // Reset ComboBox selection
                    }

                    break;
                case ("Warehouses"):
                    using (var form = new AddWarehouses())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {

                        }
                        DisplayData("Warehouses"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 1; // Reset ComboBox selection
                    }
                    break;
                case ("Clients"):
                    using (var form = new AddClient())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                        DisplayData("Clients"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 4; // Reset ComboBox selection
                    }
                    break;
                case ("Suppliers"):
                    using (var form = new AddSupplier())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                        DisplayData("Suppliers"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 3; // Reset ComboBox selection
                    }
                    break;
                case ("DeliveryOrders"):
                    using (var form = new AddDeliveryOrder())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                        DisplayData("DeliveryOrders"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 5; // Reset ComboBox selection
                    }
                    break;
                case ("DeliveryItems"):
                    using (var form = new AddDeliveryItem())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                        DisplayData("DeliveryItems"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 6; // Reset ComboBox selection
                    }
                    break;
                case ("SellingOrders"):
                    using (var form = new AddSellingOrder())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                        DisplayData("SellingOrders"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 7; // Reset ComboBox selection
                    }
                    break;
                case ("SellingItems"):
                    using (var form = new AddSellingItem())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                        DisplayData("SellingItems"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 8; // Reset ComboBox selection
                    }
                    break;
                case ("Transfer"):
                    using (var form = new AddTransferOrder())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                        DisplayData("Transfer"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 9; // Reset ComboBox selection
                    }
                    break;
                case ("TransferItems"):
                    using (var form = new AddTransferItem())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                        DisplayData("TransferItems"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 10; // Reset ComboBox selection
                    }
                    break;
                    case ("ItemUnits"):
                    using (var form = new AddItemUnit())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                        }
                        DisplayData("ItemUnits"); // Refresh DataGridView
                        comboBox1.SelectedIndex = 2; // Reset ComboBox selection
                    }
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new Reports())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }
    }

}
