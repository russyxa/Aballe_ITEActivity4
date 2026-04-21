namespace Aballe_ITEActivity4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelTop = new Panel();
            btnGenerateReport = new Button();
            btnCheckout = new Button();
            panel2 = new Panel();
            lblWelcome = new Label();
            panel1 = new Panel();
            btnLogout = new Button();
            btnNewProduct = new Button();
            btnManageUsers = new Button();
            panelOrder = new Panel();
            btnNewTransaction = new Button();
            title = new Label();
            txtTotal = new TextBox();
            label1 = new Label();
            txtTendered = new TextBox();
            label2 = new Label();
            txtChange = new TextBox();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvOrder = new DataGridView();
            productnamecolumn = new DataGridViewTextBoxColumn();
            qtycolumn = new DataGridViewTextBoxColumn();
            pricecolumn = new DataGridViewTextBoxColumn();
            totalpricecolumn = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTop.Controls.Add(btnGenerateReport);
            panelTop.Controls.Add(btnCheckout);
            panelTop.Controls.Add(panel2);
            panelTop.Controls.Add(panel1);
            panelTop.Controls.Add(panelOrder);
            panelTop.Controls.Add(btnNewTransaction);
            panelTop.Controls.Add(title);
            panelTop.Location = new Point(62, 15);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1495, 135);
            panelTop.TabIndex = 0;
            panelTop.Paint += panelTop_Paint;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerateReport.BackColor = Color.FromArgb(192, 192, 255);
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.Location = new Point(562, 85);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(144, 36);
            btnGenerateReport.TabIndex = 9;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCheckout.BackColor = Color.LawnGreen;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.Location = new Point(714, 85);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(173, 36);
            btnCheckout.TabIndex = 8;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(lblWelcome);
            panel2.Location = new Point(862, 15);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(619, 52);
            panel2.TabIndex = 7;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Dock = DockStyle.Right;
            lblWelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(355, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.RightToLeft = RightToLeft.No;
            lblWelcome.Size = new Size(264, 46);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome, user!";
            lblWelcome.TextAlign = ContentAlignment.TopRight;
            lblWelcome.Click += lblWelcome_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnNewProduct);
            panel1.Controls.Add(btnManageUsers);
            panel1.Location = new Point(1072, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 60);
            panel1.TabIndex = 6;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(274, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 36);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnNewProduct
            // 
            btnNewProduct.BackColor = Color.Gold;
            btnNewProduct.FlatStyle = FlatStyle.Flat;
            btnNewProduct.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewProduct.Location = new Point(17, 12);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(122, 36);
            btnNewProduct.TabIndex = 3;
            btnNewProduct.Text = "New Product";
            btnNewProduct.UseVisualStyleBackColor = false;
            btnNewProduct.Click += btnNewProduct_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.Gold;
            btnManageUsers.FlatStyle = FlatStyle.Flat;
            btnManageUsers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageUsers.Location = new Point(145, 12);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(123, 36);
            btnManageUsers.TabIndex = 4;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // panelOrder
            // 
            panelOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelOrder.BorderStyle = BorderStyle.FixedSingle;
            panelOrder.Location = new Point(614, 152);
            panelOrder.Name = "panelOrder";
            panelOrder.Size = new Size(936, 53);
            panelOrder.TabIndex = 1;
            panelOrder.Paint += panelOrder_Paint;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewTransaction.BackColor = Color.White;
            btnNewTransaction.FlatAppearance.BorderSize = 0;
            btnNewTransaction.FlatStyle = FlatStyle.Flat;
            btnNewTransaction.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewTransaction.ForeColor = Color.Black;
            btnNewTransaction.Location = new Point(893, 85);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Size = new Size(173, 36);
            btnNewTransaction.TabIndex = 0;
            btnNewTransaction.Text = "Add New Transaction";
            btnNewTransaction.UseVisualStyleBackColor = false;
            btnNewTransaction.Click += btnNewTransaction_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Gill Sans Ultra Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(17, 15);
            title.Name = "title";
            title.Size = new Size(255, 56);
            title.TabIndex = 1;
            title.Text = "Starbuko";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotal.BackColor = Color.FromArgb(3, 53, 44);
            txtTotal.BorderStyle = BorderStyle.None;
            txtTotal.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtTotal.ForeColor = Color.White;
            txtTotal.Location = new Point(556, 3);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(355, 31);
            txtTotal.TabIndex = 3;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(168, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 65);
            label1.TabIndex = 1;
            label1.Text = "Total Amount";
            label1.Click += label1_Click;
            // 
            // txtTendered
            // 
            txtTendered.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtTendered.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtTendered.Location = new Point(372, 68);
            txtTendered.Name = "txtTendered";
            txtTendered.Size = new Size(539, 38);
            txtTendered.TabIndex = 4;
            txtTendered.TextAlign = HorizontalAlignment.Right;
            txtTendered.TextChanged += TxtTendered_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(122, 65);
            label2.Name = "label2";
            label2.Size = new Size(200, 52);
            label2.TabIndex = 2;
            label2.Text = "Amount Tendered";
            // 
            // txtChange
            // 
            txtChange.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            txtChange.BackColor = Color.FromArgb(3, 53, 44);
            txtChange.BorderStyle = BorderStyle.None;
            txtChange.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            txtChange.ForeColor = Color.DarkOrange;
            txtChange.Location = new Point(556, 120);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(355, 31);
            txtChange.TabIndex = 4;
            txtChange.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(230, 117);
            label3.Name = "label3";
            label3.Size = new Size(92, 82);
            label3.TabIndex = 6;
            label3.Text = "Change";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.6552544F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.34475F));
            tableLayoutPanel1.Controls.Add(txtChange, 1, 2);
            tableLayoutPanel1.Controls.Add(txtTotal, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtTendered, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Location = new Point(637, 843);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55.22388F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 44.77612F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.Size = new Size(914, 199);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(575, 655);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 914F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(dgvOrder, 1, 0);
            tableLayoutPanel2.Location = new Point(58, 167);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1495, 661);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // dgvOrder
            // 
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.AllowUserToDeleteRows = false;
            dgvOrder.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.BackgroundColor = Color.FromArgb(3, 53, 44);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrder.ColumnHeadersHeight = 29;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { productnamecolumn, qtycolumn, pricecolumn, totalpricecolumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvOrder.DefaultCellStyle = dataGridViewCellStyle3;
            dgvOrder.EnableHeadersVisualStyles = false;
            dgvOrder.GridColor = Color.Black;
            dgvOrder.Location = new Point(584, 3);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(908, 655);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            // 
            // productnamecolumn
            // 
            productnamecolumn.FillWeight = 220F;
            productnamecolumn.HeaderText = "Product Name";
            productnamecolumn.MinimumWidth = 6;
            productnamecolumn.Name = "productnamecolumn";
            productnamecolumn.ReadOnly = true;
            // 
            // qtycolumn
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            qtycolumn.DefaultCellStyle = dataGridViewCellStyle2;
            qtycolumn.FillWeight = 25F;
            qtycolumn.HeaderText = "Qty";
            qtycolumn.MinimumWidth = 6;
            qtycolumn.Name = "qtycolumn";
            qtycolumn.ReadOnly = true;
            // 
            // pricecolumn
            // 
            pricecolumn.FillWeight = 65.6514359F;
            pricecolumn.HeaderText = "Price";
            pricecolumn.MinimumWidth = 6;
            pricecolumn.Name = "pricecolumn";
            pricecolumn.ReadOnly = true;
            // 
            // totalpricecolumn
            // 
            totalpricecolumn.FillWeight = 65.6514359F;
            totalpricecolumn.HeaderText = "Total";
            totalpricecolumn.MinimumWidth = 6;
            totalpricecolumn.Name = "totalpricecolumn";
            totalpricecolumn.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 53, 44);
            ClientSize = new Size(1570, 1055);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelTop);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Starbuko";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelOrder;
        private Button btnNewTransaction;
        private Label title;
        private TextBox txtTotal;
        private Label label1;
        private TextBox txtTendered;
        private Label label2;
        private TextBox txtChange;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dgvOrder;
        private DataGridViewTextBoxColumn productnamecolumn;
        private DataGridViewTextBoxColumn qtycolumn;
        private DataGridViewTextBoxColumn pricecolumn;
        private DataGridViewTextBoxColumn totalpricecolumn;
        private Label lblWelcome;
        private Button btnLogout;
        private Button btnManageUsers;
        private Button btnNewProduct;
        private Panel panel1;
        private Panel panel2;
        private Button btnCheckout;
        private Button btnGenerateReport;
    }
}
