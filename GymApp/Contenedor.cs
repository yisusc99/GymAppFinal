using MySql.Data.MySqlClient;
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
    public partial class Inicio : Form
    {
        public Inicio(string rol, string usuario)
        {
            InitializeComponent();
            rols = rol;
            usu = usuario;
            rolBt();
            lusr.Text = usu;
            loadImg(usu);
        }
        public string rols, usu;
        public void rolBt() {
            if (rols == "recepcionista")
            {
                Pbtn3.Visible = false;
                Pbtn4.Visible = false;
                panel3.Visible = false;
            }
            else if (rols == "entrenador")
            {
                Pbtn2.Visible = false;
                Pbtn3.Visible = false;
                Pbtn4.Visible = false;
                panel3.Visible = false;
            }
            else if (rols == "administrador")
            {
                MessageBox.Show("Bienvenido administrador!");
            }
            else {
                BEmpleados.Visible = false;
                BRepVentas.Visible = false;
                BRepInv.Visible = false;
                BVentas.Visible = false;
                panel1.Visible = false;
                Pbtn1.Visible = false;
                Pbtn2.Visible = false;
                Pbtn3.Visible = false;
                Pbtn4.Visible = false;
                panel3.Visible = false;
                MessageBox.Show("Hola! No eres un usuario admitido en el sistema, se deshabilitaran las funciones. :)");
            }
         }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (MenuColor.Width == 71)
            {
                MenuColor.Width = 245;
                BSalir.Visible = true;
            }
            else
            {
                MenuColor.Width = 71;
                BSalir.Visible = false;
            }

        }

        public Point mouseLocation;
        private void WPanelBlack_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }
        public void loadImg(string usur) {
            MySqlDataReader sd = usuario.getImgUsr(usur).ExecuteReader();
            while (sd.Read()) {
                img.ImageLocation=(Directory.GetCurrentDirectory() +"/usuarios/"+sd.GetString(0)+".PNG");
            }
        }
        private void WPanelBlack_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Hide();
            OpenForm(new Home());
        }


        private void foreBlack(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.ForeColor = Color.Black;
        }

        private void foreWhite(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.ForeColor = Color.FromArgb(63, 81, 181);
        }
        private void OpenForm(object formhijo) {
            if (this.Forms.Controls.Count > 0) {
                this.Forms.Controls.RemoveAt(0);
            }
            Form fhj = formhijo as Form;
            fhj.TopLevel = false;
            fhj.Dock = DockStyle.Fill;
            this.Forms.Controls.Add(fhj);
            this.Forms.Tag = fhj;
            fhj.Show();

        }
        private void BVentas_Click(object sender, EventArgs e)
        {
            OpenForm(new Ventas(usu));
            WTitle.Text = "Ventas";
        }

        private void BArticulos_Click(object sender, EventArgs e)
        {
            OpenForm(new NuevoArticulo());
            WTitle.Text = "Articulos";
        }

        private void BRepVentas_Click(object sender, EventArgs e)
        {
            if (reportes.existRep() > 0)  {
                OpenForm(new RepVentas());
                WTitle.Text = "Reporte de ventas";
            }
            else {
                MessageBox.Show("Aun no se han realizado ventas.");
            }
        }

        private void BRepInv_Click(object sender, EventArgs e)
        {
            OpenForm(new RepInventario());
            WTitle.Text = "Reporte de Inventario";
        }

        private void MenuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BInicio_Click(object sender, EventArgs e)
        {
            OpenForm(new Home());
            WTitle.Text = "Inicio";
        }

        private void WPanelBlack_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BSalir_Click_1(object sender, EventArgs e)
        {
            LogIn a = new LogIn();
            a.Show();
            this.Hide();
            usu = null;
            rols = null;
        }

        private void BEmpleados_Click(object sender, EventArgs e)
        {
            OpenForm(new Empleados());
            WTitle.Text = "Empleados";
        }
    }
}
