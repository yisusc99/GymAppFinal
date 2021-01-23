using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp
{
    public partial class RepVentas : Form
    {
        public RepVentas()
        {
            InitializeComponent();
            fillTable();
            fillCharts();
            label6.Text = "$ " +reportes.TotalVentas() +" MXN";
            label7.Text = "$ " + reportes.TotalTopProductos() + " MXN";
            label9.Text = "$ " + reportes.TotalProductos() + " MXN";
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void fillTable()
        {
            tabla.DataSource = null;
            tabla.Rows.Clear();
            tabla.DataSource = reportes.getRArticulos();

        }
      
        public void fillCharts() { 
            if(reportes.GraphBarrasX() != null) {
                ArrayList x = reportes.GraphBarrasX();
                ArrayList y = reportes.GraphBarrasY();

                chart1.Series[0].Points.DataBindXY(x, y);
            }
        }
        public void fillChartsDates(string date, string date2)
        {
            if (reportes.GraphBarrasX() != null)
            {
                ArrayList x = reportes.GraphBarrasXFech(date, date2);
                ArrayList y = reportes.GraphBarrasYFech(date, date2);

                chart1.Series[0].Points.DataBindXY(x, y);
            }
        }
        private void RepVentas_Load(object sender, EventArgs e)
        {
           

        }

        private void Filtro_CheckedChanged(object sender, EventArgs e)
        {
            if (Filtro.Checked == true) {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                actuRep.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                actuRep.Enabled = false;
                fillTable();
                fillCharts();
                label6.Text = "$ " + reportes.TotalVentas() + " MXN";
                label7.Text = "$ " + reportes.TotalTopProductos() + " MXN";
                label9.Text = "$ " + reportes.TotalProductos() + " MXN";
            }
        }

        private void actuRep_Click(object sender, EventArgs e)
        {
            string da = (dateTimePicker1.Value).ToString("yyyy-MM-dd");
            string da2 = (dateTimePicker2.Value).ToString("yyyy-MM-dd");
            tabla.DataSource = null;
            tabla.Rows.Clear();
            tabla.DataSource = reportes.getInvFech(da, da2);
            label6.Text = "$ " + reportes.TotalVentasFech(da, da2) + " MXN";
            label7.Text = "$ " + reportes.TotalTopProductosFech(da, da2) + " MXN";
            label9.Text = "$ " + reportes.TotalProductosFech(da, da2) + " MXN";
            fillChartsDates(da, da2);
        }
    }
}
