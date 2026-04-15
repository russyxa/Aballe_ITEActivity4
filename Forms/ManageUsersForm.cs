using Aballe_ITEActivity4;
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
    public partial class ManageUsersForm : Form
    {
        public ManageUsersForm()
        {
            InitializeComponent();
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = StarbukoDataStore.GetAllUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users:\n{ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Helper: reads all values from selected row ────────────────────────
        private bool TryGetSelectedUser(out int userId, out string fullName,
                                        out string status, out string username,
                                        out string roleName)
        {
            userId = 0;
            fullName = "";
            status = "";
            username = "";
            roleName = "";

            if (dgvUsers.SelectedRows.Count == 0)
                return false;

            DataGridViewRow row = dgvUsers.SelectedRows[0];

            // ── userId fix: was missing before ────────────────────────────────
            if (row.Cells["colUserId"].Value != null)
                userId = Convert.ToInt32(row.Cells["colUserId"].Value);

            fullName = row.Cells["colFullName"].Value?.ToString() ?? "";
            username = row.Cells["colUsername"].Value?.ToString() ?? "";
            roleName = row.Cells["colRole"].Value?.ToString() ?? "";
            status = row.Cells["colStatus"].Value?.ToString() ?? "";
            return true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var form = new AddUserForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedUser(out int userId, out string fullName,
                                    out _, out string username, out string roleName))
            {
                MessageBox.Show("Please select a user to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var form = new EditUserForm(userId, fullName, username, roleName);
            if (form.ShowDialog() == DialogResult.OK)
                LoadUsers();
        }

        private void btnToggleActive_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedUser(out int userId, out string fullName,
                                    out string status, out _, out _))
            {
                MessageBox.Show("Please select a user first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isActive = status == "Active";
            string action = isActive ? "disable" : "enable";

            var confirm = MessageBox.Show(
                $"Are you sure you want to {action} \"{fullName}\"?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                bool updated = StarbukoDataStore.SetUserActive(userId, !isActive);

                if (updated)
                {
                    MessageBox.Show($"\"{fullName}\" has been {action}d.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Failed to update user status.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedUser(out int userId, out string fullName,
                                    out _, out _, out _))
            {
                MessageBox.Show("Please select a user to delete.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to permanently delete \"{fullName}\"?\nThis cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                bool deleted = StarbukoDataStore.DeleteUser(userId);

                if (deleted)
                {
                    MessageBox.Show($"\"{fullName}\" has been deleted.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Failed to delete user.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}