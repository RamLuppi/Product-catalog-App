namespace AppArticulos
{
    partial class FormAppArticulos
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppArticulos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnVerDetalleArticulo = new System.Windows.Forms.Button();
            this.lblFiltrarArticulos = new System.Windows.Forms.Label();
            this.tbxFiltrarArticulos = new System.Windows.Forms.TextBox();
            this.cbxTipoFiltro = new System.Windows.Forms.ComboBox();
            this.cbxCriterioFiltro = new System.Windows.Forms.ComboBox();
            this.lblTipoFiltro = new System.Windows.Forms.Label();
            this.lblCriterioFiltro = new System.Windows.Forms.Label();
            this.pbxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.tlpFiltro = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(148, 22);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(671, 250);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(12, 22);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(113, 23);
            this.btnAgregarArticulo.TabIndex = 0;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(12, 93);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(113, 23);
            this.btnModificarArticulo.TabIndex = 1;
            this.btnModificarArticulo.Text = "Modificar Articulo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(12, 164);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(113, 23);
            this.btnEliminarArticulo.TabIndex = 2;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnVerDetalleArticulo
            // 
            this.btnVerDetalleArticulo.Location = new System.Drawing.Point(12, 236);
            this.btnVerDetalleArticulo.Name = "btnVerDetalleArticulo";
            this.btnVerDetalleArticulo.Size = new System.Drawing.Size(113, 36);
            this.btnVerDetalleArticulo.TabIndex = 3;
            this.btnVerDetalleArticulo.Text = "Ver detalle de Articulo";
            this.btnVerDetalleArticulo.UseVisualStyleBackColor = true;
            this.btnVerDetalleArticulo.Click += new System.EventHandler(this.btnVerDetalleArticulo_Click);
            // 
            // lblFiltrarArticulos
            // 
            this.lblFiltrarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFiltrarArticulos.AutoSize = true;
            this.lblFiltrarArticulos.BackColor = System.Drawing.Color.Plum;
            this.lblFiltrarArticulos.Location = new System.Drawing.Point(116, 316);
            this.lblFiltrarArticulos.Name = "lblFiltrarArticulos";
            this.lblFiltrarArticulos.Size = new System.Drawing.Size(32, 13);
            this.lblFiltrarArticulos.TabIndex = 4;
            this.lblFiltrarArticulos.Text = "Filtro:";
            // 
            // tbxFiltrarArticulos
            // 
            this.tbxFiltrarArticulos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tbxFiltrarArticulos.Location = new System.Drawing.Point(676, 312);
            this.tbxFiltrarArticulos.Name = "tbxFiltrarArticulos";
            this.tbxFiltrarArticulos.Size = new System.Drawing.Size(256, 20);
            this.tbxFiltrarArticulos.TabIndex = 7;
            // 
            // cbxTipoFiltro
            // 
            this.cbxTipoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTipoFiltro.FormattingEnabled = true;
            this.cbxTipoFiltro.Location = new System.Drawing.Point(289, 311);
            this.cbxTipoFiltro.Name = "cbxTipoFiltro";
            this.cbxTipoFiltro.Size = new System.Drawing.Size(145, 21);
            this.cbxTipoFiltro.TabIndex = 5;
            this.cbxTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.cbxTipoFiltro_SelectedIndexChanged);
            // 
            // cbxCriterioFiltro
            // 
            this.cbxCriterioFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbxCriterioFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterioFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxCriterioFiltro.FormattingEnabled = true;
            this.cbxCriterioFiltro.Location = new System.Drawing.Point(506, 312);
            this.cbxCriterioFiltro.Name = "cbxCriterioFiltro";
            this.cbxCriterioFiltro.Size = new System.Drawing.Size(143, 21);
            this.cbxCriterioFiltro.TabIndex = 6;
            this.cbxCriterioFiltro.SelectedIndexChanged += new System.EventHandler(this.cbxCriterioFiltro_SelectedIndexChanged);
            // 
            // lblTipoFiltro
            // 
            this.lblTipoFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTipoFiltro.AutoSize = true;
            this.lblTipoFiltro.BackColor = System.Drawing.Color.Plum;
            this.lblTipoFiltro.Location = new System.Drawing.Point(243, 316);
            this.lblTipoFiltro.Name = "lblTipoFiltro";
            this.lblTipoFiltro.Size = new System.Drawing.Size(40, 13);
            this.lblTipoFiltro.TabIndex = 9;
            this.lblTipoFiltro.Text = "Campo";
            // 
            // lblCriterioFiltro
            // 
            this.lblCriterioFiltro.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCriterioFiltro.AutoSize = true;
            this.lblCriterioFiltro.BackColor = System.Drawing.Color.Plum;
            this.lblCriterioFiltro.Location = new System.Drawing.Point(461, 316);
            this.lblCriterioFiltro.Name = "lblCriterioFiltro";
            this.lblCriterioFiltro.Size = new System.Drawing.Size(39, 13);
            this.lblCriterioFiltro.TabIndex = 1;
            this.lblCriterioFiltro.Text = "Criterio";
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagenArticulo.Location = new System.Drawing.Point(847, 22);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(288, 250);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenArticulo.TabIndex = 10;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBuscar.Location = new System.Drawing.Point(938, 311);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefrescar.BackgroundImage = global::AppArticulos.Properties.Resources.png_transparent_logo_product_design_brand_angle_refresh_ico_angle_logo_monochrome;
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefrescar.Location = new System.Drawing.Point(1035, 311);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(35, 23);
            this.btnRefrescar.TabIndex = 12;
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // tlpFiltro
            // 
            this.tlpFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFiltro.AutoSize = true;
            this.tlpFiltro.BackColor = System.Drawing.Color.Plum;
            this.tlpFiltro.ColumnCount = 2;
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltro.Location = new System.Drawing.Point(1, 296);
            this.tlpFiltro.Name = "tlpFiltro";
            this.tlpFiltro.RowCount = 2;
            this.tlpFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFiltro.Size = new System.Drawing.Size(1145, 55);
            this.tlpFiltro.TabIndex = 14;
            // 
            // FormAppArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1147, 345);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.lblCriterioFiltro);
            this.Controls.Add(this.lblTipoFiltro);
            this.Controls.Add(this.cbxCriterioFiltro);
            this.Controls.Add(this.cbxTipoFiltro);
            this.Controls.Add(this.tbxFiltrarArticulos);
            this.Controls.Add(this.lblFiltrarArticulos);
            this.Controls.Add(this.btnVerDetalleArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.tlpFiltro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAppArticulos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FormAppArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnVerDetalleArticulo;
        private System.Windows.Forms.Label lblFiltrarArticulos;
        private System.Windows.Forms.TextBox tbxFiltrarArticulos;
        private System.Windows.Forms.ComboBox cbxTipoFiltro;
        private System.Windows.Forms.ComboBox cbxCriterioFiltro;
        private System.Windows.Forms.Label lblTipoFiltro;
        private System.Windows.Forms.Label lblCriterioFiltro;
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TableLayoutPanel tlpFiltro;
    }
}

