
namespace GymApp
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddTableP = new System.Windows.Forms.Panel();
            this.BDelete = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BRefresh = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.BSearch = new System.Windows.Forms.Button();
            this.TitleAddProdP = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.AddProdFont = new System.Windows.Forms.Panel();
            this.AddProdSs = new System.Windows.Forms.Panel();
            this.rol = new System.Windows.Forms.ComboBox();
            this.preview = new System.Windows.Forms.PictureBox();
            this.buscarImg = new System.Windows.Forms.Button();
            this.ruta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Aceptar = new System.Windows.Forms.Button();
            this.cpassw = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.lApes = new System.Windows.Forms.Label();
            this.CloseDialog = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddTableP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.AddProdFont.SuspendLayout();
            this.AddProdSs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTableP
            // 
            this.AddTableP.BackColor = System.Drawing.Color.White;
            this.AddTableP.Controls.Add(this.BDelete);
            this.AddTableP.Controls.Add(this.BUpdate);
            this.AddTableP.Controls.Add(this.BRefresh);
            this.AddTableP.Controls.Add(this.BAdd);
            this.AddTableP.Controls.Add(this.BSearch);
            this.AddTableP.Controls.Add(this.TitleAddProdP);
            this.AddTableP.Controls.Add(this.SearchBar);
            this.AddTableP.Controls.Add(this.tabla);
            this.AddTableP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddTableP.Location = new System.Drawing.Point(0, 163);
            this.AddTableP.Name = "AddTableP";
            this.AddTableP.Size = new System.Drawing.Size(1183, 522);
            this.AddTableP.TabIndex = 2;
            this.AddTableP.Paint += new System.Windows.Forms.PaintEventHandler(this.AddTableP_Paint);
            // 
            // BDelete
            // 
            this.BDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BDelete.FlatAppearance.BorderSize = 0;
            this.BDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDelete.ForeColor = System.Drawing.Color.White;
            this.BDelete.Image = ((System.Drawing.Image)(resources.GetObject("BDelete.Image")));
            this.BDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BDelete.Location = new System.Drawing.Point(930, 11);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(33, 33);
            this.BDelete.TabIndex = 4;
            this.BDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDelete.UseVisualStyleBackColor = false;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BUpdate
            // 
            this.BUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BUpdate.FlatAppearance.BorderSize = 0;
            this.BUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUpdate.ForeColor = System.Drawing.Color.White;
            this.BUpdate.Image = ((System.Drawing.Image)(resources.GetObject("BUpdate.Image")));
            this.BUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BUpdate.Location = new System.Drawing.Point(891, 11);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(33, 33);
            this.BUpdate.TabIndex = 3;
            this.BUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BUpdate.UseVisualStyleBackColor = false;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // BRefresh
            // 
            this.BRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(179)))), ((int)(((byte)(247)))));
            this.BRefresh.FlatAppearance.BorderSize = 0;
            this.BRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRefresh.ForeColor = System.Drawing.Color.White;
            this.BRefresh.Image = ((System.Drawing.Image)(resources.GetObject("BRefresh.Image")));
            this.BRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRefresh.Location = new System.Drawing.Point(969, 11);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(33, 33);
            this.BRefresh.TabIndex = 5;
            this.BRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BRefresh.UseVisualStyleBackColor = false;
            this.BRefresh.Click += new System.EventHandler(this.BRefresh_Click);
            // 
            // BAdd
            // 
            this.BAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(181)))), ((int)(((byte)(140)))));
            this.BAdd.FlatAppearance.BorderSize = 0;
            this.BAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAdd.ForeColor = System.Drawing.Color.White;
            this.BAdd.Image = ((System.Drawing.Image)(resources.GetObject("BAdd.Image")));
            this.BAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAdd.Location = new System.Drawing.Point(744, 11);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(102, 33);
            this.BAdd.TabIndex = 2;
            this.BAdd.Text = "Agregar";
            this.BAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAdd.UseVisualStyleBackColor = false;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BSearch
            // 
            this.BSearch.BackColor = System.Drawing.Color.White;
            this.BSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSearch.ForeColor = System.Drawing.Color.White;
            this.BSearch.Image = ((System.Drawing.Image)(resources.GetObject("BSearch.Image")));
            this.BSearch.Location = new System.Drawing.Point(158, 8);
            this.BSearch.Name = "BSearch";
            this.BSearch.Size = new System.Drawing.Size(36, 36);
            this.BSearch.TabIndex = 0;
            this.BSearch.UseVisualStyleBackColor = false;
            this.BSearch.Click += new System.EventHandler(this.BSearch_Click);
            // 
            // TitleAddProdP
            // 
            this.TitleAddProdP.AutoSize = true;
            this.TitleAddProdP.ForeColor = System.Drawing.Color.Black;
            this.TitleAddProdP.Location = new System.Drawing.Point(208, -65);
            this.TitleAddProdP.Name = "TitleAddProdP";
            this.TitleAddProdP.Size = new System.Drawing.Size(93, 13);
            this.TitleAddProdP.TabIndex = 12;
            this.TitleAddProdP.Text = "Agregar empleado";
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(200, 13);
            this.SearchBar.Multiline = true;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(166, 23);
            this.SearchBar.TabIndex = 1;
            // 
            // tabla
            // 
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.ColumnHeadersHeight = 40;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.DimGray;
            this.tabla.Location = new System.Drawing.Point(158, 48);
            this.tabla.MultiSelect = false;
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla.RowHeadersVisible = false;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(844, 397);
            this.tabla.StandardTab = true;
            this.tabla.TabIndex = 6;
            // 
            // AddProdFont
            // 
            this.AddProdFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.AddProdFont.Controls.Add(this.AddProdSs);
            this.AddProdFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddProdFont.Location = new System.Drawing.Point(0, 0);
            this.AddProdFont.Name = "AddProdFont";
            this.AddProdFont.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.AddProdFont.Size = new System.Drawing.Size(1183, 163);
            this.AddProdFont.TabIndex = 3;
            this.AddProdFont.Visible = false;
            // 
            // AddProdSs
            // 
            this.AddProdSs.BackColor = System.Drawing.Color.White;
            this.AddProdSs.Controls.Add(this.rol);
            this.AddProdSs.Controls.Add(this.preview);
            this.AddProdSs.Controls.Add(this.buscarImg);
            this.AddProdSs.Controls.Add(this.ruta);
            this.AddProdSs.Controls.Add(this.label7);
            this.AddProdSs.Controls.Add(this.Aceptar);
            this.AddProdSs.Controls.Add(this.cpassw);
            this.AddProdSs.Controls.Add(this.label6);
            this.AddProdSs.Controls.Add(this.passw);
            this.AddProdSs.Controls.Add(this.label5);
            this.AddProdSs.Controls.Add(this.label4);
            this.AddProdSs.Controls.Add(this.usuario);
            this.AddProdSs.Controls.Add(this.label3);
            this.AddProdSs.Controls.Add(this.label2);
            this.AddProdSs.Controls.Add(this.apellidos);
            this.AddProdSs.Controls.Add(this.lApes);
            this.AddProdSs.Controls.Add(this.CloseDialog);
            this.AddProdSs.Controls.Add(this.nombre);
            this.AddProdSs.Controls.Add(this.label1);
            this.AddProdSs.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddProdSs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddProdSs.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdSs.Location = new System.Drawing.Point(0, 0);
            this.AddProdSs.Name = "AddProdSs";
            this.AddProdSs.Size = new System.Drawing.Size(1183, 160);
            this.AddProdSs.TabIndex = 0;
            // 
            // rol
            // 
            this.rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rol.FormattingEnabled = true;
            this.rol.Items.AddRange(new object[] {
            "administrador",
            "recepcionista",
            "entrenador"});
            this.rol.Location = new System.Drawing.Point(321, 53);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(281, 25);
            this.rol.TabIndex = 25;
            // 
            // preview
            // 
            this.preview.Location = new System.Drawing.Point(378, 92);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(89, 65);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 24;
            this.preview.TabStop = false;
            // 
            // buscarImg
            // 
            this.buscarImg.BackColor = System.Drawing.Color.Firebrick;
            this.buscarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscarImg.ForeColor = System.Drawing.Color.White;
            this.buscarImg.Location = new System.Drawing.Point(473, 132);
            this.buscarImg.Name = "buscarImg";
            this.buscarImg.Size = new System.Drawing.Size(129, 25);
            this.buscarImg.TabIndex = 23;
            this.buscarImg.Text = "Examinar";
            this.buscarImg.UseVisualStyleBackColor = false;
            this.buscarImg.Click += new System.EventHandler(this.buscarImg_Click);
            // 
            // ruta
            // 
            this.ruta.Enabled = false;
            this.ruta.Location = new System.Drawing.Point(473, 101);
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            this.ruta.Size = new System.Drawing.Size(129, 25);
            this.ruta.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(50, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Registro de empleado";
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(44)))), ((int)(((byte)(112)))));
            this.Aceptar.FlatAppearance.BorderSize = 0;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptar.ForeColor = System.Drawing.Color.White;
            this.Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Aceptar.Image")));
            this.Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptar.Location = new System.Drawing.Point(917, 114);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(226, 43);
            this.Aceptar.TabIndex = 20;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // cpassw
            // 
            this.cpassw.Location = new System.Drawing.Point(918, 57);
            this.cpassw.Name = "cpassw";
            this.cpassw.PasswordChar = '*';
            this.cpassw.Size = new System.Drawing.Size(226, 25);
            this.cpassw.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(914, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Confirmar contraseña";
            // 
            // passw
            // 
            this.passw.Location = new System.Drawing.Point(668, 116);
            this.passw.Name = "passw";
            this.passw.PasswordChar = '*';
            this.passw.Size = new System.Drawing.Size(226, 25);
            this.passw.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(664, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(318, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Imagen";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(669, 57);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(226, 25);
            this.usuario.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(665, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(318, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Puesto";
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(53, 116);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(226, 25);
            this.apellidos.TabIndex = 8;
            this.apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noNumeros);
            // 
            // lApes
            // 
            this.lApes.AutoSize = true;
            this.lApes.ForeColor = System.Drawing.Color.Black;
            this.lApes.Location = new System.Drawing.Point(49, 92);
            this.lApes.Name = "lApes";
            this.lApes.Size = new System.Drawing.Size(63, 17);
            this.lApes.TabIndex = 9;
            this.lApes.Text = "Apellidos";
            // 
            // CloseDialog
            // 
            this.CloseDialog.BackColor = System.Drawing.Color.Transparent;
            this.CloseDialog.FlatAppearance.BorderSize = 0;
            this.CloseDialog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CloseDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseDialog.Image = ((System.Drawing.Image)(resources.GetObject("CloseDialog.Image")));
            this.CloseDialog.Location = new System.Drawing.Point(0, 0);
            this.CloseDialog.Name = "CloseDialog";
            this.CloseDialog.Size = new System.Drawing.Size(40, 39);
            this.CloseDialog.TabIndex = 1;
            this.CloseDialog.UseVisualStyleBackColor = false;
            this.CloseDialog.Click += new System.EventHandler(this.CloseDialog_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(53, 57);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(226, 25);
            this.nombre.TabIndex = 7;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noNumeros);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 522);
            this.Controls.Add(this.AddProdFont);
            this.Controls.Add(this.AddTableP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.AddTableP.ResumeLayout(false);
            this.AddTableP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.AddProdFont.ResumeLayout(false);
            this.AddProdSs.ResumeLayout(false);
            this.AddProdSs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddTableP;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BRefresh;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BSearch;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Panel AddProdFont;
        private System.Windows.Forms.Panel AddProdSs;
        private System.Windows.Forms.Label TitleAddProdP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button CloseDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.Label lApes;
        private System.Windows.Forms.TextBox cpassw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buscarImg;
        private System.Windows.Forms.TextBox ruta;
        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.ComboBox rol;
    }
}