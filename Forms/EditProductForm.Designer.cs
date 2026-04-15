namespace Aballe_ITEActivity4
{
    partial class EditProductForm
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
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtImagePath = new TextBox();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 55);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 106);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Price (₱)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 161);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Image Path";
            // 
            // button1
            // 
            button1.Location = new Point(234, 179);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnBrowse_Click;
            // 
            // button2
            // 
            button2.Location = new Point(51, 224);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Save ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSave_Click;
            // 
            // button3
            // 
            button3.Location = new Point(132, 224);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnCancel_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(51, 73);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(188, 23);
            txtProductName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(51, 124);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(188, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtImagePath
            // 
            txtImagePath.Location = new Point(51, 179);
            txtImagePath.Name = "txtImagePath";
            txtImagePath.Size = new Size(188, 23);
            txtImagePath.TabIndex = 8;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(51, 263);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 9;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 312);
            Controls.Add(lblMessage);
            Controls.Add(txtImagePath);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditProductForm";
            Text = "Edit Product";
            Load += EditProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtImagePath;
        private Label lblMessage;
    }
}