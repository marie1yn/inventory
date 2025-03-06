using inventory.Domain.Models;
using inventory.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }
        private void taskbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern void SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Get the input values from the form
            string productName = txtProductName.Text;
            string category = cboCategory.SelectedItem?.ToString(); // Assuming ComboBox has items like "Food", "Drinks"
            int quantity = (int)nudQuantity.Value; // NumericUpDown for quantity
            string priceText = txtPrice.Text; // TextBox for price
            DateTime dateAdded = dtpDateAdded.Value; // Guna DatePicker for DateAdded

            // Validate the price input
            decimal price = 0;
            if (!decimal.TryParse(priceText, out price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate other fields
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new product object
            var newProduct = new Product
            {
                Name = productName,
                Category = category,
                Quantity = quantity,
                Price = price,
                DateAdded = dateAdded // The DatePicker will give us a DateTime value
            };

            // Add product to the database
            using (var context = new AppDbContext())
            {
                context.Products.Add(newProduct); // Adds the product to the DbSet
                context.SaveChanges(); // Saves changes to the database
            }

            // Optionally, show a success message or clear the form
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm(); // Clear the form for the next entry
        }

        private void ClearForm()
        {
            // Clears the form fields after adding a product
            txtProductName.Clear();
            cboCategory.SelectedIndex = -1;
            nudQuantity.Value = 1;
            txtPrice.Clear();
            dtpDateAdded.Value = DateTime.Now;
        }
    }
}
