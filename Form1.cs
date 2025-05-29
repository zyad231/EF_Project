
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
                        w.Unit

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
                    var query = from order in company.DeliveryOrders
                                join supplier in company.Suppliers on order.SupplierID equals supplier.ID
                                select new
                                {
                                    order.ID,
                                    order.ExpDate,
                                    order.ProdDate,
                                    SupplierName = supplier.Name
                                };
                    dataGridView1.DataSource = query.ToList();
                    break;
                case "DeliveryItems":
                    dataGridView1.DataSource = company.DeliveryItems.ToList();
                    break;
                case "SellingOrders":
                    dataGridView1.DataSource = company.SellingOrders.ToList();
                    break;
                case "SellingItems":
                    dataGridView1.DataSource = company.SellingItems.ToList();
                    break;
                case "Transfer":
                    dataGridView1.DataSource = company.Transfer.ToList();
                    break;
                case "TransferItems":
                    dataGridView1.DataSource = company.TransferItems.ToList();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem.ToString())
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
                    break ;
            }
        }

    }

}
