using ClassLibrary1;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informe
{
    public partial class Form2 : Form
    {

        public List<SalesLine> salesLines =SalesLineDs.GetSalesLines();

        public DataTable dt = new DataTable();
        
        public Form2()
        {
            InitializeComponent();
            dt = toDataTable(salesLines);
            reportViewer1.LocalReport.ReportEmbeddedResource = "Informe.Report1.rdlc";

            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer1.RefreshReport();

        }
        public DataTable toDataTable<T> (List<T> items)
        {
           DataTable dataTable = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance); 

            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }

            foreach(T item in items)
            {
                var values = new object[Props.Length];
                for(int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
