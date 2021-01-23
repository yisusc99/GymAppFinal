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
    public partial class Producto : UserControl
    {
        public Producto()
        {
            InitializeComponent();
        }
        public int iD, stock;
        public void setTitle(string title)
        {
            ProdTitle.Text = title;
        }
        public void setImg(string dir)
        {
            productImage.ImageLocation = dir;
        }
        public void setPrice(double price)
        {
            ProdPrice.Text = "$ " + price.ToString() + " MXN";
            precioD.Text = price.ToString();
        }
        public void setId(int ids)
        {
            idl.Text = ids.ToString();
        }
        private void Caja_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cantidad.Value) != 0)
            {
                int st = ventas.stock(Convert.ToInt32(idl.Text));
                if (st>= Convert.ToInt32(cantidad.Value))
                {
                    tmp.setTmp(Convert.ToInt32(idl.Text), ProdTitle.Text,Convert.ToDouble(precioD.Text), Convert.ToInt32(cantidad.Value));
                  }
                else {
                    MessageBox.Show("Solamente hay " + st + " unidades disponibles.");
                }
            }
            else {
                MessageBox.Show("Debes ingresar una cantidad.");
            }
        }
        public void setStock(int stck)
        {
            stckl.Text = stck.ToString();
            stock = stck;
        }
        public string infs;
        public void setInfo(string inf)
        {
            infs = inf;
        }
        public string getInf()
        {
            return infs;
        }
        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(infs);
        }
    }
}
