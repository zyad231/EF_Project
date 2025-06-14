﻿using System;
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
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        public int ClientID 
        {
            get
            {
                if (int.TryParse(textBox1.Text, out int id))
                    return id;
                MessageBox.Show("Please enter a valid Client ID.");
                return -1; // Return an invalid ID if parsing fails
            }
        }

        public string ClientName => textBox2.Text;

        public string ClientEmail => textBox3.Text;

        public string ClientPhone => textBox4.Text;

        public string ClientWebsite => textBox5.Text;

        public string ClientMobile => textBox6.Text;

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClientID == -1)
                return; // Invalid ID check
            EF_Trading_Company company = new EF_Trading_Company();
            var client = new Client
            {
                Name = ClientName,
                Email = ClientEmail,
                PhoneNumber = ClientPhone,
                Website = ClientWebsite,
                Mobile = ClientMobile
            };
            company.Clients.Add(client);
            company.SaveChanges();
            MessageBox.Show("Client added successfully.");
            AddItem.ActiveForm.Close(); // Close the form after adding
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ClientID == -1)
                return; // Invalid ID check
            EF_Trading_Company company = new EF_Trading_Company();
            var found = company.Clients.FirstOrDefault(c => c.ID == ClientID);
            if (found == null)
            {
                MessageBox.Show("Client not found.");
                return;
            }
            else
            {
                found.Name = ClientName;
                found.Email = ClientEmail;
                found.PhoneNumber = ClientPhone;
                found.Website = ClientWebsite;
                found.Mobile = ClientMobile;
                company.SaveChanges();
                MessageBox.Show("Client updated successfully.");
            }
        }
    }
}
