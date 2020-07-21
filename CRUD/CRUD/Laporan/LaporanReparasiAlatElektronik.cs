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
    public partial class LaporanReparasiAlatElektronik: UserControl
    {
        public LaporanReparasiAlatElektronik()
        {
            InitializeComponent();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("startDate", dtFrom.Value.ToString()));
            reportParameters.Add(new ReportParameter("endDate", dtTo.Value.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            Report.ReportTableAdapters.lreparasialatTableAdapter adapter =
                new Report.ReportTableAdapters.lreparasialatTableAdapter();
            Report.Report.lreparasialatDataTable table =
                new Report.Report.lreparasialatDataTable();

            adapter.Fill(table, dtFrom.Value, dtTo.Value);
            ReportDataSource ds = new ReportDataSource("reparasiAlatElektronik", (DataTable)table);
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

            Report.ReportTableAdapters.lreparasialatTableAdapter adapter =
                new Report.ReportTableAdapters.lreparasialatTableAdapter();
            Report.Report.lreparasialatDataTable table =
                new Report.Report.lreparasialatDataTable();

            adapter.Fill(table, dtFrom.Value, dtTo.Value);
            ReportDataSource ds = new ReportDataSource("reparasiAlatElektronik", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
