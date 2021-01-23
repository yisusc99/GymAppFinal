using System;
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
    public partial class RepInventario : Form
    {
        public RepInventario()
        {
            InitializeComponent();
            fillTable();
        }
        public void fillTable()
        {
            tabla.DataSource = null;
            tabla.Rows.Clear();
            tabla.DataSource = reportes.getInv();

        }
        private void RepInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
