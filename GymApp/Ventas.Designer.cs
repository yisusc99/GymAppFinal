namespace GymApp
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelProducts = new System.Windows.Forms.Panel();
            this.PProds = new System.Windows.Forms.Panel();
            this.prods = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Prod = new System.Windows.Forms.Button();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.BSearch = new System.Windows.Forms.Button();
            this.PLista = new System.Windows.Forms.Panel();
            this.BRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.cobrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.PanelProducts.SuspendLayout();
            this.PProds.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelProducts
            // 
            this.PanelProducts.AutoSize = true;
            this.PanelProducts.BackColor = System.Drawing.Color.White;
            this.PanelProducts.Controls.Add(this.PProds);
            this.PanelProducts.Controls.Add(this.panel1);
            this.PanelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelProducts.Location = new System.Drawing.Point(0, 0);
            this.PanelProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelProducts.Name = "PanelProducts";
            this.PanelProducts.Size = new System.Drawing.Size(775, 751);
            this.PanelProducts.TabIndex = 2;
            this.PanelProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProducts_Paint);
            // 
            // PProds
            // 
            this.PProds.Controls.Add(this.prods);
            this.PProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PProds.Location = new System.Drawing.Point(0, 100);
            this.PProds.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.PProds.Name = "PProds";
            this.PProds.Size = new System.Drawing.Size(775, 651);
            this.PProds.TabIndex = 16;
            // 
            // prods
            // 
            this.prods.AutoScroll = true;
            this.prods.Dock = System.Windows.Forms.DockStyle.Top;
            this.prods.Location = new System.Drawing.Point(0, 0);
            this.prods.Margin = new System.Windows.Forms.Padding(1);
            this.prods.Name = "prods";
            this.prods.Size = new System.Drawing.Size(775, 533);
            this.prods.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Prod);
            this.panel1.Controls.Add(this.SearchBar);
            this.panel1.Controls.Add(this.BSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 100);
            this.panel1.TabIndex = 15;
            // 
            // Prod
            // 
            this.Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(116)))), ((int)(((byte)(201)))));
            this.Prod.FlatAppearance.BorderSize = 0;
            this.Prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod.ForeColor = System.Drawing.Color.White;
            this.Prod.Image = ((System.Drawing.Image)(resources.GetObject("Prod.Image")));
            this.Prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Prod.Location = new System.Drawing.Point(269, 32);
            this.Prod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Prod.Name = "Prod";
            this.Prod.Size = new System.Drawing.Size(182, 36);
            this.Prod.TabIndex = 9;
            this.Prod.Text = "Recargar Productos";
            this.Prod.UseVisualStyleBackColor = false;
            this.Prod.Click += new System.EventHandler(this.Prod_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(68, 37);
            this.SearchBar.Multiline = true;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(166, 23);
            this.SearchBar.TabIndex = 12;
            // 
            // BSearch
            // 
            this.BSearch.BackColor = System.Drawing.Color.White;
            this.BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSearch.ForeColor = System.Drawing.Color.White;
            this.BSearch.Image = ((System.Drawing.Image)(resources.GetObject("BSearch.Image")));
            this.BSearch.Location = new System.Drawing.Point(26, 32);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(36, 36);
            this.BSearch.TabIndex = 11;
            this.BSearch.UseVisualStyleBackColor = false;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // PLista
            // 
            this.PLista.Controls.Add(this.BRefresh);
            this.PLista.Controls.Add(this.label2);
            this.PLista.Controls.Add(this.total);
            this.PLista.Controls.Add(this.Limpiar);
            this.PLista.Controls.Add(this.Borrar);
            this.PLista.Controls.Add(this.cobrar);
            this.PLista.Controls.Add(this.label1);
            this.PLista.Controls.Add(this.tabla);
            this.PLista.Dock = System.Windows.Forms.DockStyle.Right;
            this.PLista.Location = new System.Drawing.Point(781, 0);
            this.PLista.Name = "PLista";
            this.PLista.Size = new System.Drawing.Size(419, 522);
            this.PLista.TabIndex = 3;
            // 
            // BRefresh
            // 
            this.BRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(179)))), ((int)(((byte)(247)))));
            this.BRefresh.FlatAppearance.BorderSize = 0;
            this.BRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRefresh.ForeColor = System.Drawing.Color.White;
            this.BRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BRefresh.Image")));
            this.BRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRefresh.Location = new System.Drawing.Point(3, 0);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(33, 33);
            this.BRefresh.TabIndex = 15;
            this.BRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BRefresh.UseVisualStyleBackColor = false;
            this.BRefresh.Click += new System.EventHandler(this.BRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(313, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(316, 462);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 13;
            this.total.Text = "0";
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.Firebrick;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.ForeColor = System.Drawing.Color.White;
            this.Limpiar.Location = new System.Drawing.Point(105, 487);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(96, 32);
            this.Limpiar.TabIndex = 11;
            this.Limpiar.Text = "Limpiar lista";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.DarkRed;
            this.Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Borrar.ForeColor = System.Drawing.Color.White;
            this.Borrar.Location = new System.Drawing.Point(105, 450);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(96, 32);
            this.Borrar.TabIndex = 10;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // cobrar
            // 
            this.cobrar.BackColor = System.Drawing.Color.ForestGreen;
            this.cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cobrar.ForeColor = System.Drawing.Color.White;
            this.cobrar.Location = new System.Drawing.Point(3, 450);
            this.cobrar.Name = "cobrar";
            this.cobrar.Size = new System.Drawing.Size(96, 69);
            this.cobrar.TabIndex = 9;
            this.cobrar.Text = "Cobrar";
            this.cobrar.UseVisualStyleBackColor = false;
            this.cobrar.Click += new System.EventHandler(this.cobrar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lista ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Transparent;
            this.tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.ColumnHeadersHeight = 40;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.DimGray;
            this.tabla.Location = new System.Drawing.Point(3, 37);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla.RowHeadersVisible = false;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(416, 397);
            this.tabla.StandardTab = true;
            this.tabla.TabIndex = 7;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 522);
            this.Controls.Add(this.PLista);
            this.Controls.Add(this.PanelProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.PanelProducts.ResumeLayout(false);
            this.PProds.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PLista.ResumeLayout(false);
            this.PLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelProducts;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.FlowLayoutPanel prods;
        private System.Windows.Forms.Button Prod;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PLista;
        private System.Windows.Forms.Panel PProds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button cobrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button BRefresh;
    }
}