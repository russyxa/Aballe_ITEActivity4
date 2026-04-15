using Aballe_ITEActivity4.DTOs;
using Aballe_ITEActivity4;
using Aballe_ITEActivity4.Domain;
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
    public partial class EditUserForm : Form
    {
        private readonly int _userId;

        public EditUserForm(int userId, string fullName,
                            string username, string roleName)
        {
            InitializeComponent();
            _userId = userId;

            // Pre-fill fields
            txtFullName.Text = fullName;
            txtUsername.Text = username;
            _initialRole = roleName;
        }

        private readonly string _initialRole;

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            LoadRoles();
        }

        private void LoadRoles()
        {
            try
            {
                List<Role> roles = StarbukoDataStore.GetAllRoles();
                cboRole.DisplayMember = "RoleName";
                cboRole.ValueMember = "RoleId";
                cboRole.DataSource = roles;

                // Pre-select current role
                foreach (Role r in roles)
                {
                    if (r.RoleName == _initialRole)
                    {
                        cboRole.SelectedItem = r;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load roles:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = System.Drawing.Color.Red;

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                lblMessage.Text = "Full name is required.";
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblMessage.Text = "Username is required.";
                txtUsername.Focus();
                return;
            }

            // Password is optional on edit — only update if filled
            string? newPassword = string.IsNullOrWhiteSpace(txtPassword.Text)
                ? null
                : txtPassword.Text;

            if (newPassword != null && newPassword.Length < 6)
            {
                lblMessage.Text = "Password must be at least 6 characters.";
                txtPassword.Focus();
                return;
            }

            try
            {
                bool saved = StarbukoDataStore.UpdateUser(
                    _userId,
                    txtFullName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    newPassword,
                    (int)cboRole.SelectedValue!
                );

                if (saved)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = "✓ User updated successfully!";
                    System.Threading.Thread.Sleep(800);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblMessage.Text = "Failed to update user.";
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                lblMessage.Text = ex.Number == 1062
                    ? "Username already exists."
                    : $"Database error: {ex.Message}";
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
    }
}
