using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {
        // Inventory data stored as a list of Product objects
        private List<Product> inventory = new List<Product>();
        private const string filePath = "inventory.txt";

        public MainForm()
        {
            InitializeComponent();
            LoadInventory(); // Load existing inventory data from file
            RefreshGrid(); // Update the DataGridView
        }

        // Add a new product to the inventory
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtProductName.Text;
                int quantity = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text);

                // Add product to inventory list
                inventory.Add(new Product { Name = name, Quantity = quantity, Price = price });
                RefreshGrid(); // Refresh the DataGridView
                SaveInventory(); // Save the updated inventory to file
                MessageBox.Show("Product added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Update the stock of an existing product
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtProductName.Text;
                int quantity = int.Parse(txtQuantity.Text);

                var product = inventory.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (product != null)
                {
                    product.Quantity += quantity; // Update the quantity
                    RefreshGrid(); // Refresh the DataGridView
                    SaveInventory(); // Save the updated inventory to file
                    MessageBox.Show("Stock updated successfully.");
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Search for a product in the inventory
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            var product = inventory.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (product != null)
            {
                MessageBox.Show($"Product: {product.Name}\nQuantity: {product.Quantity}\nPrice: {product.Price:C}");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }

        // Refresh the DataGridView to display current inventory
        private void RefreshGrid()
        {
            dgvInventory.AutoGenerateColumns = true; // Ensure columns are auto-generated
            dgvInventory.DataSource = null; // Clear any previous bindings
            dgvInventory.DataSource = inventory; // Rebind with updated data
        }


        // Load inventory from file
        private void LoadInventory()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    inventory.Add(new Product
                    {
                        Name = parts[0],
                        Quantity = int.Parse(parts[1]),
                        Price = decimal.Parse(parts[2])
                    });
                }
            }
        }

        // Save inventory to file
        private void SaveInventory()
        {
            using (var writer = new StreamWriter(filePath))
            {
                foreach (var product in inventory)
                {
                    writer.WriteLine($"{product.Name},{product.Quantity},{product.Price}");
                }
            }
        }

        // Ensure application exits when MainForm is closed
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    // Product class to store inventory details
    public class Product
    {
        public required string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
