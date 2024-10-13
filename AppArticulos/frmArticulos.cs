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
    public partial class FormAppArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public FormAppArticulos()
        {
            InitializeComponent();
            cargar();
        }

        private void FormAppArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            itemsCbxTipo();

        }

        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                if (listaArticulos[0].ImagenUrl !=null)
                {
                    cargarImagen(listaArticulos[0].ImagenUrl);
                }
                ocultarColumnas();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }       
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
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

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregar = new frmAgregarArticulo();
            agregar.ShowDialog();
            cargar();
        }

        private void btnVerDetalleArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;            
            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAgregarArticulo detalle = new frmAgregarArticulo(seleccionado);
                detalle.BackColor = Color.Teal;
                detalle.detallesPrivados();
                detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un articulo para verlo en detalle");
            }
        }
            
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAgregarArticulo modificar = new frmAgregarArticulo(seleccionado);
                modificar.BackColor = Color.CadetBlue;
                modificar.ShowDialog();
                cargar();
            }
            else
            {
                MessageBox.Show("Seleccione un articulo para modificarlo");
            }
            
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que queres eliminar el artículo seleccionado?","Eliminando articulo", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
                
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cbxTipoFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxFiltrarArticulos.ReadOnly = true;
            string opcion = cbxTipoFiltro.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cbxCriterioFiltro.Items.Clear();
                cbxCriterioFiltro.Items.Add("Igual a");
                cbxCriterioFiltro.Items.Add("Mayor a");
                cbxCriterioFiltro.Items.Add("Menor a");
            }
            else
            {
                cbxCriterioFiltro.Items.Clear();
                cbxCriterioFiltro.Items.Add("Empieza con");
                cbxCriterioFiltro.Items.Add("Termina con");
                cbxCriterioFiltro.Items.Add("Contiene");
            }
            
        }

        private bool validarFiltro()
        {
            if (cbxTipoFiltro.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione un campo a filtrar");
                return true;
            }
            if (cbxCriterioFiltro.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio con el cual vas a filtrar");
                return true;
            }
            if (cbxTipoFiltro.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(tbxFiltrarArticulos.Text)))
                {
                    MessageBox.Show("Por favor, ingrese el Precio en formato numérico. Use coma para números con decimales (por ejemplo: 200,10)");
                    return true;
                }
                if (string.IsNullOrEmpty(tbxFiltrarArticulos.Text))
                {
                    MessageBox.Show("Ingresa un número en el filtro de busqueda");
                    return true;
                }
                
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            int contadorComas = 0;
            foreach (char caracter in cadena)
            {
                if (char.IsNumber(caracter))
                {

                    continue;
                }
                else if (caracter == ',')
                {
                    contadorComas++;
                    if (contadorComas > 1)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            if (cadena.StartsWith(",") || cadena.EndsWith(","))
            {
                return false;
            }

            return true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (validarFiltro())
                {
                    return;
                }
                string campo = cbxTipoFiltro.SelectedItem.ToString();
                string criterio = cbxCriterioFiltro.SelectedItem.ToString();
                string texto = tbxFiltrarArticulos.Text;
                if (campo == "Precio")
                {
                    texto = texto.Replace(',', '.');
                }
                    dgvArticulos.DataSource = negocio.filtrar(campo, criterio, texto);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargar();
            tbxFiltrarArticulos.Clear();
            cbxCriterioFiltro.Items.Clear();
            cbxTipoFiltro.Items.Clear();
            itemsCbxTipo();
        }

        private void cbxCriterioFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxFiltrarArticulos.ReadOnly = false;
        }

        private void itemsCbxTipo()
        {
            cbxTipoFiltro.Items.Add("Precio");
            cbxTipoFiltro.Items.Add("Codigo");
            cbxTipoFiltro.Items.Add("Nombre");
            cbxTipoFiltro.Items.Add("Descripcion");
            cbxTipoFiltro.Items.Add("Categoria");
            cbxTipoFiltro.Items.Add("Marca");
            tbxFiltrarArticulos.ReadOnly = true;
        }
    }
}
