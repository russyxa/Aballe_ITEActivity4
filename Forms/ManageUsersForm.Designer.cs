namespace Aballe_ITEActivity4
{
    partial class ManageUsersForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnAddUser = new Button();
            btnToggleActive = new Button();
            btnEdit = new Button();
            dgvUsers = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            btnDeleteUser = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddUser.BackColor = Color.White;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.ControlText;
            btnAddUser.Location = new Point(24, 17);
            btnAddUser.Margin = new Padding(3, 2, 3, 2);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(120, 28);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnToggleActive
            // 
            btnToggleActive.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnToggleActive.BackColor = Color.White;
            btnToggleActive.FlatStyle = FlatStyle.Flat;
            btnToggleActive.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToggleActive.Location = new Point(149, 17);
            btnToggleActive.Margin = new Padding(3, 2, 3, 2);
            btnToggleActive.Name = "btnToggleActive";
            btnToggleActive.Size = new Size(120, 28);
            btnToggleActive.TabIndex = 2;
            btnToggleActive.Text = "Enable / Disable";
            btnToggleActive.UseVisualStyleBackColor = false;
            btnToggleActive.Click += btnToggleActive_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEdit.BackColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(274, 17);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 28);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit User";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colUserId, colFullName, colUsername, colRole, colStatus });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.Location = new Point(0, 0);
            dgvUsers.Margin = new Padding(3, 2, 3, 2);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(700, 338);
            dgvUsers.TabIndex = 0;
            // 
            // colUserId
            // 
            colUserId.DataPropertyName = "UserId";
            colUserId.HeaderText = "ID";
            colUserId.MinimumWidth = 6;
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            colUserId.Visible = false;
            colUserId.Width = 125;
            // 
            // colFullName
            // 
            colFullName.DataPropertyName = "FullName";
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.Width = 125;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 6;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 125;
            // 
            // colRole
            // 
            colRole.DataPropertyName = "RoleName";
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 125;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "StatusDisplay";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 53, 44);
            panel1.Controls.Add(btnDeleteUser);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(btnToggleActive);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 274);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 64);
            panel1.TabIndex = 4;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.White;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.Location = new Point(400, 17);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(120, 28);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            Controls.Add(dgvUsers);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageUsersForm";
            Text = "Manage Users";
            Load += ManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddUser;
        private Button btnToggleActive;
        private Button btnEdit;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colStatus;
        private Panel panel1;
        private Button btnDeleteUser;
    }
}