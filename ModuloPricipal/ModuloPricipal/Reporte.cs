using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloPricipal
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "ModuloPrincipal.Report1.rdlc";


            ReportParameter[] parameters = new ReportParameter[2];
            //Establecemos el valor de los parámetros
            parameters[0] = new ReportParameter("prTotal", "sadasdsa");
            parameters[1] = new ReportParameter("prsubTotal", "asdsad");
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.SetParameters(parameters);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
       
        }
    }
}
