namespace AppArticulos
{
    partial class frmAgregarArticulo
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
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.tbxUrlImagen = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.pbxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.lblSinDescripcion = new System.Windows.Forms.Label();
            this.lblSinUrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(63, 393);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarArticulo.TabIndex = 7;
            this.btnAgregarArticulo.Text = "Aceptar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(110, 330);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(146, 21);
            this.cbxCategoria.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(60, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxNombre.Location = new System.Drawing.Point(110, 53);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(146, 20);
            this.tbxNombre.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(64, 102);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(41, 148);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(196, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(47, 194);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(57, 13);
            this.lblUrlImagen.TabIndex = 7;
            this.lblUrlImagen.Text = "Url imagen";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxCodigo.Location = new System.Drawing.Point(110, 99);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(146, 20);
            this.tbxCodigo.TabIndex = 1;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxDescripcion.Location = new System.Drawing.Point(110, 145);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(146, 20);
            this.tbxDescripcion.TabIndex = 2;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(67, 240);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Marca";
            // 
            // cbxMarca
            // 
            this.cbxMarca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(110, 283);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(146, 21);
            this.cbxMarca.TabIndex = 5;
            // 
            // tbxUrlImagen
            // 
            this.tbxUrlImagen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxUrlImagen.Location = new System.Drawing.Point(110, 191);
            this.tbxUrlImagen.Name = "tbxUrlImagen";
            this.tbxUrlImagen.Size = new System.Drawing.Size(146, 20);
            this.tbxUrlImagen.TabIndex = 3;
            this.tbxUrlImagen.Leave += new System.EventHandler(this.tbxUrlImagen_Leave);
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbxPrecio.Location = new System.Drawing.Point(110, 237);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(146, 20);
            this.tbxPrecio.TabIndex = 4;
            this.tbxPrecio.Leave += new System.EventHandler(this.tbxPrecio_Leave);
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxImagenArticulo.Location = new System.Drawing.Point(303, 99);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(250, 205);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenArticulo.TabIndex = 16;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregarImagen.Location = new System.Drawing.Point(262, 191);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(21, 20);
            this.btnAgregarImagen.TabIndex = 17;
            this.btnAgregarImagen.Text = "+";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // lblSinDescripcion
            // 
            this.lblSinDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSinDescripcion.AutoSize = true;
            this.lblSinDescripcion.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinDescripcion.ForeColor = System.Drawing.Color.Red;
            this.lblSinDescripcion.Location = new System.Drawing.Point(107, 168);
            this.lblSinDescripcion.Name = "lblSinDescripcion";
            this.lblSinDescripcion.Size = new System.Drawing.Size(0, 14);
            this.lblSinDescripcion.TabIndex = 18;
            // 
            // lblSinUrl
            // 
            this.lblSinUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSinUrl.AutoSize = true;
            this.lblSinUrl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinUrl.ForeColor = System.Drawing.Color.Red;
            this.lblSinUrl.Location = new System.Drawing.Point(110, 214);
            this.lblSinUrl.Name = "lblSinUrl";
            this.lblSinUrl.Size = new System.Drawing.Size(0, 14);
            this.lblSinUrl.TabIndex = 19;
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.lblSinUrl);
            this.Controls.Add(this.lblSinDescripcion);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.tbxUrlImagen);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Name = "frmAgregarArticulo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.TextBox tbxUrlImagen;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label lblSinDescripcion;
        private System.Windows.Forms.Label lblSinUrl;
    }
}