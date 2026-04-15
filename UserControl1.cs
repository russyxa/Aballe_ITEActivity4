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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            lblProductName.AutoSize = false;
            lblProductName.AutoEllipsis = false;
            lblProductName.TextAlign = ContentAlignment.TopLeft;

            // Hide admin buttons by default
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }

        // ── Properties ────────────────────────────────────────────────────────
        public int ProductId { get; set; }

        [Category("Appearance")]
        [Description("The display name of the product")]
        [DefaultValue("Product Name")]
        [Browsable(true)]
        public string DisplayName
        {
            get => lblProductName.Text;
            set => lblProductName.Text = value;
        }

        public string Price
        {
            get => lblPrice.Text;
            set
            {
                if (!value.Trim().StartsWith("₱"))
                    lblPrice.Text = "₱ " + value.Trim();
                else
                    lblPrice.Text = value.Trim();
            }
        }

        public Image? ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        // ── Show/hide admin buttons based on role ─────────────────────────────
        public void SetAdminMode(bool isAdmin)
        {
            btnEdit.Visible = isAdmin;
            btnDelete.Visible = isAdmin;
        }

        // ── Card click — add to cart ──────────────────────────────────────────
        private void OnProductClick(object sender, EventArgs e)
        {
            if (ParentForm is Form1 mainForm)
                mainForm.AddToCart(ProductId, DisplayName, Price);
        }

        private void lblPrice_Click(object sender, EventArgs e) { OnProductClick(sender, e); }
        private void pictureBox1_Click(object sender, EventArgs e) { OnProductClick(sender, e); }
        private void lblProductName_Click(object sender, EventArgs e) { OnProductClick(sender, e); }

        // ── Edit button ───────────────────────────────────────────────────────
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ParentForm is Form1 mainForm)
                mainForm.EditProduct(ProductId, DisplayName, Price);
        }

        // ── Delete button ─────────────────────────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ParentForm is Form1 mainForm)
                mainForm.DeleteProduct(ProductId, DisplayName);
        }
    }
}