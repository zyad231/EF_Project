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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }
        public int SupplierID 
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Supplier ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }

        public string SupplierName => textBox2.Text;

        public string SupplierEmail => textBox3.Text;

        public string SupplierPhone => textBox4.Text;

        public string SupplierWebsite => textBox5.Text;

        public string SupplierMobile => textBox6.Text;

        private void button1_Click(object sender, EventArgs e)
        {
            if (SupplierID == -1)
                return; // Invalid ID check
            EF_Trading_Company company = new EF_Trading_Company();
            var supplier = new Supplier
            {
                Name = SupplierName,
                Email = SupplierEmail,
                PhoneNumber = SupplierPhone,
                Website = SupplierWebsite,
                Mobile = SupplierMobile
            };
            company.Suppliers.Add(supplier);
            company.SaveChanges();
            MessageBox.Show("Supplier added successfully.");
            AddSupplier.ActiveForm.Close(); // Close the form after adding
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SupplierID == -1)
                return; // Invalid ID check
            EF_Trading_Company company = new EF_Trading_Company();
            var found = company.Suppliers.FirstOrDefault(c => c.ID == SupplierID);
            if (found == null)
            {
                MessageBox.Show("Supplier not found.");
                return;
            }
            else
            {
                found.Name = SupplierName;
                found.Email = SupplierEmail;
                found.PhoneNumber = SupplierPhone;
                found.Website = SupplierWebsite;
                found.Mobile = SupplierMobile;
                company.SaveChanges();
                MessageBox.Show("Supplier updated successfully.");
                AddSupplier.ActiveForm.Close(); // Close the form after updating
            }
        }
    }
}
