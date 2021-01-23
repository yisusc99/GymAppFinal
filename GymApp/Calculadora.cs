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
    public partial class Calculadora : Form
    {
        public Calculadora(double tt)
        {
            InitializeComponent();
            total = tt;
            Ventas v = new Ventas("0");
            ejecuta += new Ejecutar(v.HacerCompra);   
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
        private double total=0;
        public delegate void Ejecutar();
        public event Ejecutar ejecuta;
        private void aceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                double efectivo = Convert.ToDouble(textBox1.Text);
                if (efectivo > total) { 
                    DialogResult ad = MessageBox.Show("El cambio a regresar es de: " + (efectivo - total), "Cambio a regresar", MessageBoxButtons.OK);
                    if (ad == DialogResult.OK)
                    {
                        this.Close();
                        ejecuta();
                    }
                }
                else {
                    MessageBox.Show("Dinero recibido insuficiente");
                }
            }
            else {
                MessageBox.Show("Introduce una cantidad");
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
