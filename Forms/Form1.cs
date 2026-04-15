using Aballe_ITEActivity4;
using Aballe_ITEActivity4.Domain;
using Aballe_ITEActivity4.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aballe_ITEActivity4
{
    public partial class Form1 : Form
    {
        private User? _currentUser;
        private List<CartItemDto> _cart = new List<CartItemDto>();

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(User user) : this()
        {
            _currentUser = user;
        }

        // ── Form Load ─────────────────────────────────────────────────────────
        private void Form1_Load(object sender, EventArgs e)
        {
            txtChange.Text = "0.00";
            SetupUserAccess();
            LoadMenu();
        }

        // ── Show/hide Admin buttons based on role ─────────────────────────────
        private void SetupUserAccess()
        {
            if (_currentUser == null) return;

            lblWelcome.Text = $"Welcome, {_currentUser.FullName}!";
            btnNewProduct.Visible = _currentUser.IsAdmin;
            btnManageUsers.Visible = _currentUser.IsAdmin;
        }

        // ── Load menu from database ───────────────────────────────────────────
        private void LoadMenu()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                List<ProductDto> products = StarbukoDataStore.GetAllProducts();

                foreach (ProductDto product in products)
                {
                    var card = new UserControl1();
                    card.DisplayName = product.Name;
                    card.Price = product.FormattedPrice;
                    card.ProductId = product.ProductId;
                    card.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                    // ── THIS LINE makes Edit/Delete show for Admin only ───────────
                    card.SetAdminMode(_currentUser?.IsAdmin ?? false);

                    string imagePath = Path.Combine(Application.StartupPath, product.ImagePath);
                    if (File.Exists(imagePath))
                        card.ProductImage = Image.FromFile(imagePath);

                    flowLayoutPanel1.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load menu:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Cup size popup ────────────────────────────────────────────────────
        private string ShowSizeSelectionPopup()
        {
            var result = MessageBox.Show(
                "Choose Cup Size:\n\n" +
                "Yes for Grande (+₱20)\n" +
                "No for Venti (+₱30)\n" +
                "Cancel for Regular",
                "Select Cup Size",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes) return "Grande";
            if (result == DialogResult.No) return "Venti";
            return "Regular";
        }

        // ── Called by UserControl1 when card is clicked ───────────────────────
        public void AddToCart(int productId, string displayName, string priceText)
        {
            if (!decimal.TryParse(priceText.Replace("₱", "").Trim(), out decimal basePrice))
            {
                MessageBox.Show("Invalid price format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cupSize = ShowSizeSelectionPopup();
            decimal finalPrice = basePrice;

            if (cupSize == "Grande") finalPrice += 20;
            else if (cupSize == "Venti") finalPrice += 30;

            CartItemDto? existing = _cart.Find(
                c => c.ProductId == productId && c.CupSize == cupSize);

            if (existing != null)
                existing.Quantity++;
            else
                _cart.Add(new CartItemDto
                {
                    ProductId = productId,
                    ProductName = displayName,
                    CupSize = cupSize,
                    Quantity = 1,
                    UnitPrice = finalPrice
                });

            RefreshOrderGrid();
            RecalculateTotal();
        }

        // ── Called by UserControl1 Edit button ────────────────────────────────
        public void EditProduct(int productId, string displayName, string priceText)
        {
            decimal.TryParse(priceText.Replace("₱", "").Trim(), out decimal price);
            var form = new EditProductForm(productId, displayName, price);
            if (form.ShowDialog() == DialogResult.OK)
                LoadMenu();
        }

        // ── Called by UserControl1 Delete button ──────────────────────────────
        public void DeleteProduct(int productId, string displayName)
        {
            var confirm = MessageBox.Show(
                $"Are you sure you want to remove \"{displayName}\" from the menu?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                // NEW — hard delete
                bool deleted = StarbukoDataStore.DeleteProduct(productId);

                if (deleted)
                {
                    MessageBox.Show($"\"{displayName}\" has been removed from the menu.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMenu();
                }
                else
                {
                    MessageBox.Show("Failed to remove product.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Sync _cart to DataGridView ────────────────────────────────────────
        private void RefreshOrderGrid()
        {
            dgvOrder.Rows.Clear();
            foreach (CartItemDto item in _cart)
                dgvOrder.Rows.Add(
                    item.DisplayName,
                    item.Quantity,
                    item.FormattedUnitPrice,
                    item.FormattedTotalPrice);
        }

        // ── Totals ────────────────────────────────────────────────────────────
        private void RecalculateTotal()
        {
            decimal total = 0;
            foreach (CartItemDto item in _cart)
                total += item.TotalPrice;

            txtTotal.Text = $"₱{total:F2}";
            CalculateChange();
        }

        private void CalculateChange()
        {
            if (decimal.TryParse(txtTotal.Text.Replace("₱", "").Trim(), out decimal total) &&
                decimal.TryParse(txtTendered.Text.Trim(), out decimal tendered))
            {
                decimal change = tendered - total;
                txtChange.Text = change >= 0 ? $"₱{change:F2}" : "Insufficient amount";
            }
            else
            {
                txtChange.Text = "0.00";
            }
        }

        // ── New Transaction ───────────────────────────────────────────────────
        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            dgvOrder.Rows.Clear();
            txtTotal.Clear();
            txtTendered.Clear();
            txtChange.Text = "0.00";
        }

        // ── Checkout ──────────────────────────────────────────────────────────
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Cart is empty.", "Checkout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTendered.Text.Trim(), out decimal tendered))
            {
                MessageBox.Show("Please enter a valid tendered amount.", "Checkout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendered.Focus();
                return;
            }

            if (!decimal.TryParse(txtTotal.Text.Replace("₱", "").Trim(), out decimal total))
                return;

            if (tendered < total)
            {
                MessageBox.Show("Tendered amount is less than the total.", "Checkout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendered.Focus();
                return;
            }

            var checkout = new CheckoutDto
            {
                CashierId = _currentUser!.UserId,
                TotalAmount = total,
                Tendered = tendered
            };
            checkout.Items.AddRange(_cart);

            try
            {
                // Now it returns the ID integer instead of a boolean!
                int newTransactionId = StarbukoDataStore.SaveTransaction(checkout);

                if (newTransactionId > 0) // If it's greater than 0, it saved successfully
                {
                    MessageBox.Show(
                        $"Transaction saved!\nChange: ₱{checkout.ChangeAmount:F2}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Pass the REAL newTransactionId instead of 0!
                    ReceiptForm receipt = new ReceiptForm(checkout, newTransactionId, _currentUser.FullName);
                    receipt.ShowDialog();

                    btnNewTransaction_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Failed to save transaction.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Admin buttons ─────────────────────────────────────────────────────
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            var form = new AddProductForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadMenu();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            var form = new ManageUsersForm();
            form.ShowDialog();
        }

        // ── Logout ────────────────────────────────────────────────────────────
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _cart.Clear();
                _currentUser = null;
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        // ── Designer-wired empty handlers ─────────────────────────────────────
        private void TxtTendered_TextChanged(object sender, EventArgs e) { CalculateChange(); }
        private void label1_Click(object sender, EventArgs e) { }
        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panelTop_Paint(object sender, PaintEventArgs e) { }
        private void panelOrder_Paint(object sender, PaintEventArgs e) { }
        private void panelPayment_Paint(object sender, PaintEventArgs e) { }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void lblWelcome_Click(object sender, EventArgs e) { }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            SalesReportForm reportForm = new SalesReportForm();
            reportForm.ShowDialog();
        }
    }
}