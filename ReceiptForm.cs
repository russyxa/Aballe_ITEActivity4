using Aballe_ITEActivity4.DTOs;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace Aballe_ITEActivity4 // <-- Make sure this matches your project's actual namespace!
{
    public partial class ReceiptForm : Form
    {
        // 1. Add these variables
        private readonly CheckoutDto _checkoutData;
        private readonly int _transactionId;
        private readonly string _cashierName;
        private ReportViewer viewer;

        // 2. Update your constructor to accept these parameters
        public ReceiptForm(CheckoutDto checkoutData, int transactionId, string cashierName)
        {
            InitializeComponent(); // <-- Keep this exactly as it was!

            _checkoutData = checkoutData;
            _transactionId = transactionId;
            _cashierName = cashierName;

            viewer = new ReportViewer();
            viewer.Dock = DockStyle.Fill;
            this.Controls.Add(viewer);
        }

        // 3. Add the OnLoad method
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            viewer.LocalReport.ReportPath = "ReceiptReport.rdlc";

            ReportParameter[] parameters = new ReportParameter[]
            {
                new ReportParameter("prmTransactionId", _transactionId.ToString()),
                new ReportParameter("prmDate", DateTime.Now.ToString("g")),
                new ReportParameter("prmCashier", _cashierName),
                new ReportParameter("prmTotal", _checkoutData.TotalAmount.ToString("F2"))
            };
            viewer.LocalReport.SetParameters(parameters);

            ReportDataSource rds = new ReportDataSource("dsReceiptItems", _checkoutData.Items);
            viewer.LocalReport.DataSources.Clear();
            viewer.LocalReport.DataSources.Add(rds);

            viewer.RefreshReport();
        }
    }
}