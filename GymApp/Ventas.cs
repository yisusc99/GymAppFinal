using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp
{
    public partial class Ventas : Form
    {
        public Ventas(string usr)
        {
            InitializeComponent();
            nusu = usr;
            fillProd(null);
        }
        private string nusu;
        public void fillProd(string bsq) {
            MySqlDataReader vr = ventas.producto(bsq).ExecuteReader();
            prods.Controls.Clear();
            if (vr.Read())
            {
                MySqlDataReader vr2 = ventas.producto(bsq).ExecuteReader();
                while (vr2.Read())
                {
                    Producto nuevo = new Producto();
                    nuevo.setId(vr2.GetInt32(0));
                    nuevo.setTitle(vr2.GetString(1));
                    nuevo.setPrice(vr2.GetDouble(2));
                    nuevo.setInfo(vr2.GetString(3));
                    nuevo.setStock(vr2.GetInt32(4)); 
                    nuevo.setImg(Directory.GetCurrentDirectory()+"/productos/"+vr2.GetString(5)+".png");
                    prods.Controls.Add(nuevo);
                }
            }
            else {
                MessageBox.Show("Aun no hay productos existentes.");
            }
        }
        private void actuaTable() {
            tabla.DataSource = null;
            tabla.Rows.Clear();
            tabla.DataSource = tmp.getTmp();
            int filas = tabla.Rows.Count;
            if (filas != 0)
            {
                for (int i = 0; i < filas; i++)
                {
                    int tt = Convert.ToInt32(tabla.Rows[i].Cells[4].Value);
                    total.Text = (Convert.ToInt32(total.Text) + tt).ToString();
                
                }
            }
            else {
                total.Text = "0";
            }
        }
        private void PanelProducts_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            actuaTable();
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            actuaTable();
            
        }

        private void Prod_Click(object sender, EventArgs e)
        {
            fillProd(null);
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            tmp.deleteTmp(Convert.ToInt32(tabla.CurrentRow.Cells[0].Value), 1);
            actuaTable();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            tmp.deleteTmp(0, 2);
            actuaTable();
        }

        private void cobrar_Click(object sender, EventArgs e)
        {
            Calculadora a = new Calculadora(Convert.ToDouble(total.Text));
            a.Show();

        }
        public void HacerCompra() {
            MySqlDataReader cmd = tmp.cobrar().ExecuteReader();
            while (cmd.Read())
            {
                ventas.newSell(cmd.GetInt32(0), cmd.GetInt32(3), cmd.GetDouble(4));
                ventas.updateVenta(cmd.GetInt32(3));
            }
            tmp.deleteTmp(0, 2);
            actuaTable();
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            fillProd(SearchBar.Text);
        }
    }
}
