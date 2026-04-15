namespace Aballe_ITEActivity4
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblProductName = new Label();
            lblPrice = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Location = new Point(7, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.White;
            lblProductName.Location = new Point(207, 19);
            lblProductName.Name = "lblProductName";
            lblProductName.RightToLeft = RightToLeft.Yes;
            lblProductName.Size = new Size(292, 127);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name";
            lblProductName.TextAlign = ContentAlignment.TopRight;
            lblProductName.Click += lblProductName_Click;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(443, 169);
            lblPrice.Name = "lblPrice";
            lblPrice.RightToLeft = RightToLeft.Yes;
            lblPrice.Size = new Size(56, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleRight;
            lblPrice.Click += lblPrice_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(172, 185);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(253, 185);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 53, 44);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserControl1";
            Size = new Size(536, 223);
            Click += OnProductClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblProductName;
        private Label lblPrice;
        private Button btnEdit;
        private Button btnDelete;
    }
}
