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

    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        // ── Form Load — populate role dropdown ────────────────────────────────
        private void AddUserForm_Load(object sender, EventArgs e)
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
                cboRole.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load roles:\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ── Save button ───────────────────────────────────────────────────────
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = System.Drawing.Color.Red;

            // ── Validation ────────────────────────────────────────────────────
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

            if (txtUsername.Text.Trim().Length < 4)
            {
                lblMessage.Text = "Username must be at least 4 characters.";
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblMessage.Text = "Password is required.";
                txtPassword.Focus();
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                lblMessage.Text = "Password must be at least 6 characters.";
                txtPassword.Focus();
                return;
            }

            if (cboRole.SelectedItem == null)
            {
                lblMessage.Text = "Please select a role.";
                cboRole.Focus();
                return;
            }

            // ── Build DTO and save ────────────────────────────────────────────
            var dto = new NewUserDto
            {
                FullName = txtFullName.Text.Trim(),
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text,
                RoleId = (int)cboRole.SelectedValue
            };

            try
            {
                bool saved = StarbukoDataStore.AddUser(dto);

                if (saved)
                {
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = $"✓ \"{dto.FullName}\" added successfully!";

                    System.Threading.Thread.Sleep(800);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblMessage.Text = "Failed to save user. Try again.";
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                // Duplicate username error code is 1062
                if (ex.Number == 1062)
                    lblMessage.Text = "Username already exists. Choose another.";
                else
                    lblMessage.Text = $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Unexpected error. Check connection.";
                MessageBox.Show(
                    $"Error:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // ── Cancel button ─────────────────────────────────────────────────────
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
