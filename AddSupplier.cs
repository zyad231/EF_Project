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

        public string SupplierName 
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                    return textBox2.Text;
                MessageBox.Show("Please enter a valid Supplier Name.");
                return string.Empty; // Return an empty string if validation fails
            }
        }

        public string SupplierEmail 
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox3.Text))
                    return textBox3.Text;
                MessageBox.Show("Please enter a valid Supplier Email.");
                return string.Empty; // Return an empty string if validation fails
            }
        }

        public string SupplierPhone 
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox4.Text))
                    return textBox4.Text;
                MessageBox.Show("Please enter a valid Supplier Phone Number.");
                return string.Empty; // Return an empty string if validation fails
            }
        }

        public string SupplierWebsite 
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox5.Text))
                    return textBox5.Text;
                MessageBox.Show("Please enter a valid Supplier Website.");
                return string.Empty; // Return an empty string if validation fails
            }
        }

        public string SupplierMobile
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(textBox6.Text))
                    return textBox6.Text;
                MessageBox.Show("Please enter a valid Supplier Mobile Number.");
                return string.Empty; // Return an empty string if validation fails
            }
        }

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
            }
        }
    }
}
