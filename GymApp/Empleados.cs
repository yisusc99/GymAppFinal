using System;
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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
            fillTable(null);
        }
        public void fillTable(string name)
        {
            tabla.DataSource = null;
            tabla.Rows.Clear();
            tabla.DataSource = GymApp.usuario.getUsers(name);

        }
        private bool diffwindow = false;
        private int id;
        private void Aceptar_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            string rutaprod = Directory.GetCurrentDirectory() + "/usuarios";
            if (!Directory.Exists(rutaprod))
            {
                Directory.CreateDirectory(rutaprod);
            }
            if (nombre.Text != "" && apellidos.Text != "" && usuario.Text != null && passw.Text != "" && cpassw.Text != "" && rol.Text != "" && ruta.Text != "") {
                if (passw.Text != cpassw.Text) { MessageBox.Show("Las contrasenas no coinciden"); }
                else
                {
                    if (diffwindow == false)
                    {
                        preview.Image.Save(dir + "/usuarios/" + usuario.Text + ".png");
                        if (GymApp.usuario.newUser(nombre.Text, apellidos.Text, usuario.Text, passw.Text, rol.Text, usuario.Text) == true)
                            MessageBox.Show("Se agregaron correctamente los datos del empleado.");
                        else
                            MessageBox.Show("Hubo un error al agregar los datos del empleado.");
                    }
                    else
                    {
                            preview.Image.Save(dir + "/usuarios/" + usuario.Text + ".png");
                            if (GymApp.usuario.upUser(id, nombre.Text, apellidos.Text, usuario.Text, passw.Text, rol.Text, usuario.Text) == true)
                                MessageBox.Show("Se modificaron correctamente los datos del empleado");
                            else
                                MessageBox.Show("Hubo un error al modificar los datos del empleado.");
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Hay campos incompletos.");
            }
            fillTable(null);
        }

        private void CloseDialog_Click(object sender, EventArgs e)
        {
            AddProdFont.Visible = false;
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            AddProdFont.Visible = true;

            if (AddProdFont.Visible == false)
                AddProdFont.Visible = true;

            TitleAddProdP.Text = "Registro de empleado";
            diffwindow = false;
            nombre.Text = "";
            apellidos.Text = "";
            rol.Text = "";
            ruta.Text = "";
            preview.Image = null;
            usuario.Text = "";
            passw.Text = "";
            cpassw.Text = "";
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            if (AddProdFont.Visible == false)
                AddProdFont.Visible = true;

            TitleAddProdP.Text = "Modificar datos de empleado";
            diffwindow = true;

            id = Convert.ToInt32(tabla.CurrentRow.Cells[0].Value);
            nombre.Text = tabla.CurrentRow.Cells[1].Value.ToString();
            apellidos.Text = tabla.CurrentRow.Cells[2].Value.ToString();
            rol.Text = tabla.CurrentRow.Cells[4].Value.ToString();
            usuario.Text = tabla.CurrentRow.Cells[3].Value.ToString();
            passw.Text = seguridad.Desencriptar(tabla.CurrentRow.Cells[5].Value.ToString());
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(tabla.CurrentRow.Cells[0].Value);
            GymApp.usuario.deleteUser(id);
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

        private void AddTableP_Paint(object sender, PaintEventArgs e)
        {

        }
        OpenFileDialog opn = new OpenFileDialog();
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
            else
            {
                MessageBox.Show("No seleccionaste ninguna imagen");
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
            else if (Char.IsWhiteSpace(e.KeyChar))
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
