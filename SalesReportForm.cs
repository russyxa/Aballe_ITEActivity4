using Aballe_ITEActivity4.Domain;
using Aballe_ITEActivity4;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aballe_ITEActivity4 // <-- Keep your original namespace
{
    public partial class SalesReportForm : Form
    {
        // 1. Add this variable
        private ReportViewer viewer;

        // 2. Update constructor
        public SalesReportForm()
        {
            InitializeComponent(); // <-- Keep this!

            this.Height = Screen.PrimaryScreen.WorkingArea.Height; // Stretches to full screen height
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // Prevents manual resizing

            viewer = new ReportViewer();
            viewer.Dock = DockStyle.Fill;
            this.Controls.Add(viewer);
        }

        // 3. Add OnLoad method
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<Transaction> transactions = StarbukoDataStore.GetAllTransactions();

            viewer.LocalReport.ReportPath = "SalesReport.rdlc";

            ReportDataSource rds = new ReportDataSource("dsTransactions", transactions);
            viewer.LocalReport.DataSources.Clear();
            viewer.LocalReport.DataSources.Add(rds);

            viewer.RefreshReport();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}