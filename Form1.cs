
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
                    dataGridView1.DataSource = company.ItemUnits.ToList();
                    break;
                case "Suppliers":
                    dataGridView1.DataSource = company.Suppliers.Select(w => new
                    {
                        w.ID,
                        w.Name,
                        w.Mobile,
                        w.PhoneNumber,
                        w.Website
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
                        w.Website
                    }
                    ).ToList();
                    break;
                case "DeliveryOrders":
                    dataGridView1.DataSource = company.DeliveryOrders.ToList();
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
            }
        }

    }

}
