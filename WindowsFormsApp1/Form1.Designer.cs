namespace WindowsFormsApp1
{
    partial class FrmArticulo
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.btnDetalleArt = new System.Windows.Forms.Button();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbnombre = new System.Windows.Forms.RadioButton();
            this.goxCriterios = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.msAdmiistrarCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pxbArticulo = new System.Windows.Forms.PictureBox();
            this.goxCriterios.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(232, 48);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(347, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(134, 50);
            this.lbBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(83, 13);
            this.lbBuscar.TabIndex = 2;
            this.lbBuscar.Text = "Buscar Articulos";
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.Location = new System.Drawing.Point(132, 481);
            this.btnAgregarArt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(87, 35);
            this.btnAgregarArt.TabIndex = 3;
            this.btnAgregarArt.Text = "Agregar";
            this.btnAgregarArt.UseVisualStyleBackColor = true;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.Location = new System.Drawing.Point(256, 481);
            this.btnModificarArt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(87, 35);
            this.btnModificarArt.TabIndex = 4;
            this.btnModificarArt.Text = "Modificar";
            this.btnModificarArt.UseVisualStyleBackColor = true;
            this.btnModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.Location = new System.Drawing.Point(384, 481);
            this.btnEliminarArt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(87, 35);
            this.btnEliminarArt.TabIndex = 5;
            this.btnEliminarArt.Text = "Eliminar";
            this.btnEliminarArt.UseVisualStyleBackColor = true;
            this.btnEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // btnDetalleArt
            // 
            this.btnDetalleArt.Location = new System.Drawing.Point(524, 481);
            this.btnDetalleArt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetalleArt.Name = "btnDetalleArt";
            this.btnDetalleArt.Size = new System.Drawing.Size(87, 35);
            this.btnDetalleArt.TabIndex = 6;
            this.btnDetalleArt.Text = "Detalle";
            this.btnDetalleArt.UseVisualStyleBackColor = true;
            this.btnDetalleArt.Click += new System.EventHandler(this.btnDetalleArt_Click);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(223, 35);
            this.rbCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(70, 21);
            this.rbCodigo.TabIndex = 8;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbnombre
            // 
            this.rbnombre.AutoSize = true;
            this.rbnombre.Location = new System.Drawing.Point(125, 35);
            this.rbnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbnombre.Name = "rbnombre";
            this.rbnombre.Size = new System.Drawing.Size(76, 21);
            this.rbnombre.TabIndex = 9;
            this.rbnombre.Text = "Nombre";
            this.rbnombre.UseVisualStyleBackColor = true;
            this.rbnombre.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // goxCriterios
            // 
            this.goxCriterios.Controls.Add(this.rbTodos);
            this.goxCriterios.Controls.Add(this.rbCodigo);
            this.goxCriterios.Controls.Add(this.rbnombre);
            this.goxCriterios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goxCriterios.Location = new System.Drawing.Point(246, 97);
            this.goxCriterios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goxCriterios.Name = "goxCriterios";
            this.goxCriterios.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goxCriterios.Size = new System.Drawing.Size(305, 81);
            this.goxCriterios.TabIndex = 12;
            this.goxCriterios.TabStop = false;
            this.goxCriterios.Text = "Criterios de Busqueda";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(24, 35);
            this.rbTodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(66, 21);
            this.rbTodos.TabIndex = 10;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(645, 41);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 31);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // msAdmiistrarCategorias
            // 
            this.msAdmiistrarCategorias.Name = "msAdmiistrarCategorias";
            this.msAdmiistrarCategorias.Size = new System.Drawing.Size(140, 20);
            this.msAdmiistrarCategorias.Text = "Administrar Categorias";
            this.msAdmiistrarCategorias.Click += new System.EventHandler(this.msAdmiistrarCategorias_Click);
            // 
            // administrarMarcasToolStripMenuItem
            // 
            this.administrarMarcasToolStripMenuItem.Name = "administrarMarcasToolStripMenuItem";
            this.administrarMarcasToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.administrarMarcasToolStripMenuItem.Text = "Administrar Marcas";
            this.administrarMarcasToolStripMenuItem.Click += new System.EventHandler(this.administrarMarcasToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAdmiistrarCategorias,
            this.administrarMarcasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(34, 197);
            this.dgvArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidth = 51;
            this.dgvArticulo.RowTemplate.Height = 24;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(618, 251);
            this.dgvArticulo.TabIndex = 14;
            // 
            // pxbArticulo
            // 
            this.pxbArticulo.Location = new System.Drawing.Point(716, 233);
            this.pxbArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pxbArticulo.Name = "pxbArticulo";
            this.pxbArticulo.Size = new System.Drawing.Size(172, 165);
            this.pxbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbArticulo.TabIndex = 15;
            this.pxbArticulo.TabStop = false;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 534);
            this.Controls.Add(this.pxbArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.goxCriterios);
            this.Controls.Add(this.btnDetalleArt);
            this.Controls.Add(this.btnEliminarArt);
            this.Controls.Add(this.btnModificarArt);
            this.Controls.Add(this.btnAgregarArt);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(950, 599);
            this.MinimumSize = new System.Drawing.Size(560, 474);
            this.Name = "FrmArticulo";
            this.Text = "App Catalogo";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            this.goxCriterios.ResumeLayout(false);
            this.goxCriterios.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.Button btnModificarArt;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.Button btnDetalleArt;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbnombre;
        private System.Windows.Forms.GroupBox goxCriterios;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStripMenuItem msAdmiistrarCategorias;
        private System.Windows.Forms.ToolStripMenuItem administrarMarcasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.PictureBox pxbArticulo;
    }
}