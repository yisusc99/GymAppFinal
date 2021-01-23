
namespace GymApp
{
    partial class Producto
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.ProductContainer = new System.Windows.Forms.Panel();
            this.precioD = new System.Windows.Forms.Label();
            this.stckl = new System.Windows.Forms.Label();
            this.idl = new System.Windows.Forms.Label();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lCantidad = new System.Windows.Forms.Label();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.info = new System.Windows.Forms.Button();
            this.Caja = new System.Windows.Forms.Button();
            this.ProdPrice = new System.Windows.Forms.Label();
            this.ProdTitle = new System.Windows.Forms.Label();
            this.ProductContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductContainer
            // 
            this.ProductContainer.BackColor = System.Drawing.Color.White;
            this.ProductContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProductContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductContainer.Controls.Add(this.precioD);
            this.ProductContainer.Controls.Add(this.stckl);
            this.ProductContainer.Controls.Add(this.idl);
            this.ProductContainer.Controls.Add(this.productImage);
            this.ProductContainer.Controls.Add(this.panel2);
            this.ProductContainer.Controls.Add(this.ProdPrice);
            this.ProductContainer.Controls.Add(this.ProdTitle);
            this.ProductContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProductContainer.Location = new System.Drawing.Point(0, 0);
            this.ProductContainer.Name = "ProductContainer";
            this.ProductContainer.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.ProductContainer.Size = new System.Drawing.Size(230, 300);
            this.ProductContainer.TabIndex = 1;
            // 
            // precioD
            // 
            this.precioD.AutoSize = true;
            this.precioD.Location = new System.Drawing.Point(168, 162);
            this.precioD.Name = "precioD";
            this.precioD.Size = new System.Drawing.Size(37, 21);
            this.precioD.TabIndex = 12;
            this.precioD.Text = "450";
            this.precioD.Visible = false;
            // 
            // stckl
            // 
            this.stckl.AutoSize = true;
            this.stckl.Location = new System.Drawing.Point(168, 183);
            this.stckl.Name = "stckl";
            this.stckl.Size = new System.Drawing.Size(41, 21);
            this.stckl.TabIndex = 11;
            this.stckl.Text = "stckl";
            this.stckl.Visible = false;
            // 
            // idl
            // 
            this.idl.AutoSize = true;
            this.idl.Location = new System.Drawing.Point(171, 202);
            this.idl.Name = "idl";
            this.idl.Size = new System.Drawing.Size(27, 21);
            this.idl.TabIndex = 10;
            this.idl.Text = "idl";
            this.idl.Visible = false;
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(49, 39);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(130, 138);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 9;
            this.productImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 245);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.panel2.Size = new System.Drawing.Size(228, 53);
            this.panel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.Caja);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 51);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lCantidad);
            this.panel3.Controls.Add(this.cantidad);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(49, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 51);
            this.panel3.TabIndex = 4;
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lCantidad.Location = new System.Drawing.Point(0, 0);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(72, 21);
            this.lCantidad.TabIndex = 1;
            this.lCantidad.Text = "Cantidad";
            // 
            // cantidad
            // 
            this.cantidad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cantidad.Location = new System.Drawing.Point(0, 22);
            this.cantidad.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(130, 29);
            this.cantidad.TabIndex = 0;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(65)))));
            this.info.Dock = System.Windows.Forms.DockStyle.Left;
            this.info.FlatAppearance.BorderSize = 0;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.info.Location = new System.Drawing.Point(0, 0);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.info.Size = new System.Drawing.Size(49, 51);
            this.info.TabIndex = 3;
            this.info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Caja
            // 
            this.Caja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(65)))));
            this.Caja.Dock = System.Windows.Forms.DockStyle.Right;
            this.Caja.FlatAppearance.BorderSize = 0;
            this.Caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Caja.ForeColor = System.Drawing.Color.White;
            this.Caja.Image = ((System.Drawing.Image)(resources.GetObject("Caja.Image")));
            this.Caja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Caja.Location = new System.Drawing.Point(179, 0);
            this.Caja.Name = "Caja";
            this.Caja.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Caja.Size = new System.Drawing.Size(49, 51);
            this.Caja.TabIndex = 2;
            this.Caja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Caja.UseVisualStyleBackColor = false;
            this.Caja.Click += new System.EventHandler(this.Caja_Click);
            // 
            // ProdPrice
            // 
            this.ProdPrice.AutoSize = true;
            this.ProdPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProdPrice.Location = new System.Drawing.Point(63, 204);
            this.ProdPrice.Name = "ProdPrice";
            this.ProdPrice.Size = new System.Drawing.Size(94, 21);
            this.ProdPrice.TabIndex = 4;
            this.ProdPrice.Text = "$1050 MXN";
            // 
            // ProdTitle
            // 
            this.ProdTitle.BackColor = System.Drawing.Color.Transparent;
            this.ProdTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProdTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdTitle.ForeColor = System.Drawing.Color.Black;
            this.ProdTitle.Location = new System.Drawing.Point(0, 1);
            this.ProdTitle.Name = "ProdTitle";
            this.ProdTitle.Size = new System.Drawing.Size(228, 35);
            this.ProdTitle.TabIndex = 0;
            this.ProdTitle.Text = "Proteina BSN Syntha-6 5lbs";
            this.ProdTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.ProductContainer);
            this.Name = "Producto";
            this.Size = new System.Drawing.Size(230, 300);
            this.ProductContainer.ResumeLayout(false);
            this.ProductContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProductContainer;
        private System.Windows.Forms.Label stckl;
        private System.Windows.Forms.Label idl;
        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.Button Caja;
        private System.Windows.Forms.Label ProdPrice;
        private System.Windows.Forms.Label ProdTitle;
        private System.Windows.Forms.Label precioD;
    }
}
