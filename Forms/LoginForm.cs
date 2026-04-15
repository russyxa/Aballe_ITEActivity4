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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // ── Enter key on either textbox triggers login ────────────────────────
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AttemptLogin();
        }

        // ── Login button ──────────────────────────────────────────────────────
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AttemptLogin();
        }

        // ── Fixes the Designer-wired click on lblTitle ────────────────────────
        private void lblTitle_Click(object sender, EventArgs e) { }

        // ── Core login logic ──────────────────────────────────────────────────
        private void AttemptLogin()
        {
            lblError.Text = "";

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                lblError.Text = "Please enter your username.";
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblError.Text = "Please enter your password.";
                txtPassword.Focus();
                return;
            }

            btnLogin.Enabled = false;
            btnLogin.Text = "Logging in...";

            try
            {
                var dto = new LoginDto(txtUsername.Text.Trim(), txtPassword.Text);
                User? loggedInUser = StarbukoDataStore.Login(dto);

                if (loggedInUser == null)
                {
                    lblError.Text = "Invalid username or password.";
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                var mainForm = new Form1(loggedInUser);
                mainForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                lblError.Text = "Connection error. Check your database.";
                MessageBox.Show(
                    $"Database error:\n{ex.Message}",
                    "Connection Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnLogin.Enabled = true;
                btnLogin.Text = "Login";
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}