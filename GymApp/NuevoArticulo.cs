using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp
{
    public partial class NuevoArticulo : Form
    {
        public NuevoArticulo()
        {
            InitializeComponent();
            fillTable(null);
            loadCat();
        }
        private bool diffwindow = false;
        private int id;
        OpenFileDialog opn = new OpenFileDialog();
        private void AddProdSs_Paint(object sender, PaintEventArgs e)
        {

        }
        public void fillTable(string name) {
            tabla.DataSource = null;
            tabla.Rows.Clear();
            tabla.DataSource = Productos.getProduct(name);
 
        }
        public void loadCat() {
            if (Productos.clasif() != null)
            {
                MySqlDataReader a = Productos.clasif().ExecuteReader();
                while (a.Read()) {
                    clasif.Items.Add(a.GetString(0));
                }
            }
            else { 
            
            }
        }
        private void CloseDialog_Click(object sender, EventArgs e)
        {
            if (AddProdFont.Visible == true)
                AddProdFont.Visible = false;
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (AddProdFont.Visible == false)
                AddProdFont.Visible = true;

            TitleAddProdP.Text = "Agregar producto";
            diffwindow = false;

            nombre.Text = "";
            pre.Text = "";
            desc.Text = "";
            clasif.Text = "";
            cantidad.Text = "";
            ruta.Text = "";
            preview.ImageLocation = null;
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            if (AddProdFont.Visible == false)
                AddProdFont.Visible = true;

            TitleAddProdP.Text = "Modificar producto";
            diffwindow = true;
            
            id = Convert.ToInt32(tabla.CurrentRow.Cells[0].Value);
            nombre.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            pre.Text = tabla.CurrentRow.Cells[2].Value.ToString();
            desc.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            cantidad.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            clasif.Text = tabla.CurrentRow.Cells[5].Value.ToString();
        }

        private void BDelete_Click(object sender, EventArgs e)
        {

            id = Convert.ToInt32(tabla.CurrentRow.Cells[0].Value);
            Productos.deleteProduct(id);
            fillTable(null);
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            string rutaprod = Directory.GetCurrentDirectory() + "/productos";
            if (!Directory.Exists(rutaprod)) {
                Directory.CreateDirectory(rutaprod);
            }
            if (nombre.Text != "" && pre.Text != "" && desc.Text != "" && clasif.Text != ""  && cantidad.Text != "" &&ruta.Text != "") {
                if (diffwindow == false)
                {

                    preview.Image.Save(dir + "/productos/" + nombre.Text + ".png");
                    if (Productos.newProduct(nombre.Text, Convert.ToDouble(pre.Text),
                    desc.Text, Convert.ToInt32(cantidad.Text), clasif.Text, nombre.Text) == true)
                        MessageBox.Show("Se agrego correctamente el producto.");
                    else
                        MessageBox.Show("Hubo un error al agregar el producto.");
                }
                else
                {
                    if (ruta.Text == null)
                    {
                        preview.Image.Save(dir + "/productos/" + nombre.Text + id.ToString() + ".png");
                        if (Productos.upProduct(id, nombre.Text, Convert.ToDouble(pre.Text),
                            desc.Text, Convert.ToInt32(cantidad.Text), clasif.Text, nombre.Text + id.ToString()) == true)
                            MessageBox.Show("Se agrego correctamente el producto.");
                        else
                            MessageBox.Show("Hubo un error al agregar el producto.");
                    }
                    else {
                        if (Productos.upProduct(id, nombre.Text, Convert.ToDouble(pre.Text),
                            desc.Text, Convert.ToInt32(cantidad.Text), clasif.Text, nombre.Text) == true)
                            MessageBox.Show("Se agrego correctamente el producto.");
                        else
                            MessageBox.Show("Hubo un error al agregar el producto.");
                    }
                }
            }
            else {
                MessageBox.Show("Hay campos vacios.");
            }
            fillTable(null);
        }

        private void BRefresh_Click(object sender, EventArgs e)
        {
            fillTable(null);
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            fillTable(SearchBar.Text);
        }
        string path = null;
        private void buscarImg_Click(object sender, EventArgs e)
        {
            
            opn.InitialDirectory = "c:\\";
            opn.Filter = "Images | *.png; *.jpg; *.jpeg; *.gif";
            opn.FilterIndex = 2;
            opn.RestoreDirectory = true;
            if (opn.ShowDialog() == DialogResult.OK)
            {
                path = opn.FileName;
                ruta.Text = path;
                preview.ImageLocation = path;
            }
            else {
                MessageBox.Show("No seleccionaste ninguna imagen");
            }
            
        }

        private void NoLetras(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
               
                }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
            
        }

        private void teclado(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;

            }
            else if (Char.IsPunctuation(e.KeyChar))
            {//permitir punto 
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void noNumeros(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;

            }
            else if (Char.IsPunctuation(e.KeyChar))
            {//permitir punto 
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
}
