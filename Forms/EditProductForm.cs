using Aballe_ITEActivity4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aballe_ITEActivity4
{
    public partial class EditProductForm : Form
    {
        private readonly int _productId;

        public EditProductForm(int productId, string name, decimal price)
        {
            InitializeComponent();
            _productId = productId;
            txtProductName.Text = name;
            txtPrice.Text = price.ToString("F2");
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {
            // fields pre-filled in constructor
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Product Image";
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
                dialog.InitialDirectory = Path.Combine(
                    Application.StartupPath, "StarbukoImages");

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string fullPath = dialog.FileName;
                    string startupPath = Application.StartupPath;

                    txtImagePath.Text = fullPath.StartsWith(startupPath)
                        ? fullPath.Substring(startupPath.Length).TrimStart('\\', '/')
                        : fullPath;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = System.Drawing.Color.Red;

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                lblMessage.Text = "Product name is required.";
                txtProductName.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price) || price <= 0)
            {
                lblMessage.Text = "Please enter a valid price.";
                txtPrice.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtImagePath.Text))
            {
                lblMessage.Text = "Image path is required.";
                return;
            }

            try
            {
                bool saved = StarbukoDataStore.UpdateProduct(
                    _productId,
                    txtProductName.Text.Trim(),
                    price,
                    txtImagePath.Text.Trim()
                );

                if (saved)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "✓ Product updated successfully!";
                    System.Threading.Thread.Sleep(800);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblMessage.Text = "Failed to update product.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error: {ex.Message}";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.' &&
                !char.IsControl(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == '.' && txtPrice.Text.Contains("."))
                e.Handled = true;
        }
    }
}