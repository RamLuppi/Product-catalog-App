using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace AppArticulos
{
    public partial class frmAgregarArticulo : Form
    {
        private Articulo articulo = null;

        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (string.IsNullOrWhiteSpace(tbxNombre.Text))
                {
                    MessageBox.Show("El campo 'Nombre' es obligatorio.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxPrecio.Text))
                {
                    MessageBox.Show("El campo 'Precio' es obligatorio.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxCodigo.Text))
                {
                    MessageBox.Show("El campo 'Codigo' es obligatorio.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxDescripcion.Text))
                {
                    tbxDescripcion.Text = "Sin descripcion";
                    lblSinDescripcion.Text = "Se añadio una descripcion por defecto";
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxUrlImagen.Text))
                {
                    tbxUrlImagen.Text = "Sin URL";
                    lblSinUrl.Text = "Se añadio una url por defecto";
                    return;
                }
                if (articulo == null)
                {
                    articulo = new Articulo();
                }
                articulo.Nombre = tbxNombre.Text;
                articulo.Codigo = tbxCodigo.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.ImagenUrl = tbxUrlImagen.Text;
                articulo.Precio = decimal.Parse(tbxPrecio.Text);
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado exitosamente");
                }


                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    tbxNombre.Text = articulo.Nombre;
                    tbxCodigo.Text = articulo.Codigo;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxUrlImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    tbxPrecio.Text = articulo.Precio.ToString();
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxImagenArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        public void detallesPrivados()
        {
            btnAgregarArticulo.Visible = false;
            btnAgregarImagen.Visible = false;
            tbxNombre.ReadOnly = true;
            tbxCodigo.ReadOnly = true;
            tbxDescripcion.ReadOnly = true;
            tbxUrlImagen.ReadOnly = true;
            cargarImagen(articulo.ImagenUrl);
            tbxPrecio.ReadOnly = true;
            cbxCategoria.Enabled = false;
            cbxMarca.Enabled = false;
            Text = "Detalles del articulo";
            btnCancelar.Text = "Cerrar";
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter= "jpg|*.jpg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private bool soloNumeros(string cadena)
        {
            int contadorComas = 0;
            foreach (char caracter in cadena)
            {
                if(caracter == ',')
                {
                    contadorComas++;
                    if (contadorComas > 1)
                    {
                        return false;
                    }
                }
                else if (!(char.IsNumber(caracter)))
                {

                    return false;
                }
            }
            return true;
        }

        private void tbxPrecio_Leave(object sender, EventArgs e)
        {
            if (!(soloNumeros(tbxPrecio.Text)))
            {
                MessageBox.Show("Por favor, ingrese el Precio en formato numérico. Use coma para números con decimales (por ejemplo: 200,10)");
                tbxPrecio.Text = "";
            }
        }
    }
}
