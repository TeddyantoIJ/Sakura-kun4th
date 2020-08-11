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
    public partial class LaporanRestockAlatKerja : UserControl
    {
        public LaporanRestockAlatKerja()
        {
            InitializeComponent();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtFrom.Value, dtTo.Value) > 0)
            {
                dtFrom.Value = DateTime.Today;
            }
            
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("startDate", dtFrom.Value.ToString()));
            reportParameters.Add(new ReportParameter("endDate", dtTo.Value.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            Report.ReportTableAdapters.lrestockalatTableAdapter adapter =
                new Report.ReportTableAdapters.lrestockalatTableAdapter();
            Report.Report.lrestockalatDataTable table =
                new Report.Report.lrestockalatDataTable();

            adapter.Fill(table, dtFrom.Value, dtTo.Value);
            ReportDataSource ds = new ReportDataSource("restockAlatKerja", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {if (DateTime.Compare(dtTo.Value, dtFrom.Value) < 0)
            {
                dtTo.Value = DateTime.Today;
            }
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("startDate", dtFrom.Value.ToString()));
            reportParameters.Add(new ReportParameter("endDate", dtTo.Value.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            Report.ReportTableAdapters.lrestockalatTableAdapter adapter =
                new Report.ReportTableAdapters.lrestockalatTableAdapter();
            Report.Report.lrestockalatDataTable table =
                new Report.Report.lrestockalatDataTable();

            adapter.Fill(table, dtFrom.Value, dtTo.Value);
            ReportDataSource ds = new ReportDataSource("restockAlatKerja", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
