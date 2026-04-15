using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aballe_ITEActivity4.DTOs;
using Aballe_ITEActivity4;

namespace Aballe_ITEActivity4
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        // ── Browse for image file ─────────────────────────────────────────────
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Product Image";
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                dialog.InitialDirectory = Path.Combine(
                    Application.StartupPath, "StarbukoImages"
                );

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Store only the relative path e.g. StarbukoImages/filename.jpg
                    string fullPath = dialog.FileName;
                    string startupPath = Application.StartupPath;

                    if (fullPath.StartsWith(startupPath))
                    {
                        // Make it relative
                        txtImagePath.Text = fullPath
                            .Substring(startupPath.Length)
                            .TrimStart('\\', '/');
                    }
                    else
                    {
                        // File is outside the project folder — just use full path
                        txtImagePath.Text = fullPath;
                    }
                }
            }
        }

        // ── Save button ───────────────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = System.Drawing.Color.Red;

            // ── Validation ────────────────────────────────────────────────────
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                lblMessage.Text = "Product name is required.";
                txtProductName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                lblMessage.Text = "Price is required.";
                txtPrice.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                lblMessage.Text = "Please enter a valid price (numbers only).";
                txtPrice.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtImagePath.Text))
            {
                lblMessage.Text = "Please select an image.";
                return;
            }

            // ── Build DTO and save ────────────────────────────────────────────
            var dto = new NewProductDto
            {
                Name = txtProductName.Text.Trim(),
                Price = price,
                ImagePath = txtImagePath.Text.Trim()
            };

            try
            {
                bool saved = StarbukoDataStore.AddProduct(dto);

                if (saved)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = $"✓ \"{dto.Name}\" added successfully!";

                    // Brief pause so user sees the success message
                    System.Threading.Thread.Sleep(800);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblMessage.Text = "Failed to save product. Try again.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Database error. Check connection.";
                MessageBox.Show(
                    $"Error:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ── Cancel button ─────────────────────────────────────────────────────
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // ── Only allow numbers and control keys in price field ────────────────
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, one decimal point, and control keys (backspace etc.)
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // block the key
            }

            // Block a second decimal point
            if (e.KeyChar == '.' && txtPrice.Text.Contains("."))
                e.Handled = true;
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            // nothing needed on load
        }
    }
}