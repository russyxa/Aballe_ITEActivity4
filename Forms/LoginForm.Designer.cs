namespace Aballe_ITEActivity4
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblError = new Label();
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Top;
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(356, 224);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(359, 317);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 23);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top;
            txtUsername.Location = new Point(286, 254);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(228, 34);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.Location = new Point(286, 347);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(228, 34);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(286, 410);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(228, 46);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(633, 565);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 7;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Gill Sans Ultra Bold", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(142, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(515, 114);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "StarBuko";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblUsername, 0, 1);
            tableLayoutPanel1.Controls.Add(txtUsername, 0, 2);
            tableLayoutPanel1.Controls.Add(btnLogin, 0, 5);
            tableLayoutPanel1.Controls.Add(lblPassword, 0, 3);
            tableLayoutPanel1.Controls.Add(txtPassword, 0, 4);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 224F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 572);
            tableLayoutPanel1.TabIndex = 8;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 53, 44);
            ClientSize = new Size(800, 572);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblError);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StarBuko Login";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblError;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel1;
    }
}