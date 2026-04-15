namespace Aballe_ITEActivity4
{
    partial class AddProductForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtImagePath = new TextBox();
            btnBrowse = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(36, 68);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(250, 27);
            txtProductName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 122);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Price (₱)";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(36, 148);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 201);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Image Path";
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(36, 227);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(250, 27);
            txtImagePath.TabIndex = 5;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Black;
            btnBrowse.FlatAppearance.BorderSize = 0;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(283, 227);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 27);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(3, 53, 44);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(39, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 39);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(165, 289);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 39);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(39, 389);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 9;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnBrowse);
            Controls.Add(txtImagePath);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "Add New Product";
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private TextBox txtImagePath;
        private Button btnBrowse;
        private Button btnSave;
        private Button btnCancel;
        private Label lblMessage;
    }
}