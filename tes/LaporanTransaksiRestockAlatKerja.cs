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
    public partial class LaporanTransaksiRestockAlatKerja : UserControl
    {
        public LaporanTransaksiRestockAlatKerja()
        {
            InitializeComponent();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("start_date", dtFrom.Value.ToString()));
            reportParameters.Add(new ReportParameter("end_date", dtTo.Value.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            dstRestockAlatKerjaTableAdapters.trestockalatkerjaTableAdapter adapter =
                new dstRestockAlatKerjaTableAdapters.trestockalatkerjaTableAdapter();
            dstRestockAlatKerja.trestockalatkerjaDataTable table =
                new dstRestockAlatKerja.trestockalatkerjaDataTable();

            adapter.Fill(table, dtFrom.Value, dtTo.Value);
            ReportDataSource ds = new ReportDataSource("dsRestockAlatKerja", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("start_date", dtFrom.Value.ToString()));
            reportParameters.Add(new ReportParameter("end_date", dtTo.Value.ToString()));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);

            dstRestockAlatKerjaTableAdapters.trestockalatkerjaTableAdapter adapter =
                new dstRestockAlatKerjaTableAdapters.trestockalatkerjaTableAdapter();
            dstRestockAlatKerja.trestockalatkerjaDataTable table =
                new dstRestockAlatKerja.trestockalatkerjaDataTable();

            adapter.Fill(table, dtFrom.Value, dtTo.Value);
            ReportDataSource ds = new ReportDataSource("dsRestockAlatKerja", (DataTable)table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ds);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
