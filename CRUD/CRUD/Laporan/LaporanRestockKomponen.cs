using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CRUD
{
    public partial class LaporanRestockKomponen : UserControl
    {
        public LaporanRestockKomponen()
        {
            InitializeComponent();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("startDate", dtFrom.Value.ToString()));
            reportParameters.Add(new ReportParameter("endDate", dtTo.Value.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            Report.ReportTableAdapters.lrestock1TableAdapter adapter =
                new Report.ReportTableAdapters.lrestock1TableAdapter();
            Report.Report.lrestock1DataTable table =
                new Report.Report.lrestock1DataTable();

            adapter.Fill(table, dtFrom.Value, dtTo.Value);
            ReportDataSource ds = new ReportDataSource("Restock", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("startDate", dtFrom.Value.ToString()));
            reportParameters.Add(new ReportParameter("endDate", dtTo.Value.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            Report.ReportTableAdapters.lrestock1TableAdapter adapter =
                new Report.ReportTableAdapters.lrestock1TableAdapter();
            Report.Report.lrestock1DataTable table =
                new Report.Report.lrestock1DataTable();

            adapter.Fill(table, dtFrom.Value, dtTo.Value);
            ReportDataSource ds = new ReportDataSource("Restock", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
