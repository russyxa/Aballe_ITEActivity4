namespace Aballe_ITEActivity4
{
    partial class EditUserForm
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
            label4 = new Label();
            label5 = new Label();
            lblMessage = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            cboRole = new ComboBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtFullName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 43);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 116);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(42, 190);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 285);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(42, 247);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 4;
            label5.Text = "(leave blank to keep current)";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(53, 425);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(3, 53, 44);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(42, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 35);
            btnSave.TabIndex = 6;
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
            btnCancel.Location = new Point(164, 351);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 35);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // cboRole
            // 
            cboRole.BackColor = SystemColors.ControlLightLight;
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(43, 308);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(241, 28);
            cboRole.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.ControlLightLight;
            txtPassword.Location = new Point(43, 213);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.ControlLightLight;
            txtUsername.Location = new Point(43, 139);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 27);
            txtUsername.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.ControlLightLight;
            txtFullName.Location = new Point(43, 66);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(241, 27);
            txtFullName.TabIndex = 11;
            // 
            // EditUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 472);
            Controls.Add(txtFullName);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(cboRole);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblMessage);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EditUserForm";
            Text = "Edit User";
            Load += EditUserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblMessage;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox cboRole;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtFullName;
    }
}