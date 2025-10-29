using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo_App_Conexión_a_DB
{
    public partial class frmAgregarDisco : Form
    {
        private Disco disco = null;
        public frmAgregarDisco()
        {
            InitializeComponent();
        }
        public frmAgregarDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            Disco AgregarD = new Disco();
            DiscosServer negocio = new DiscosServer();

            try
            {
                AgregarD.Titulo = txtTitulo.Text;
                AgregarD.FechaDeLazamiento = dtpFecha.Value;

                if (!int.TryParse(txtCantidadCanciones.Text, out int cantidad))
                {
                    MessageBox.Show("Ingrese un valor valido");
                    return;
                }
                AgregarD.CantidadDeCanciones = cantidad;
                AgregarD.UrlImagenCover = txtUrlImagen.Text;
                AgregarD.Estilo = (Estilos)cboEstilo.SelectedItem;
                AgregarD.Edicion = (TipoEdicion)cboEdicion.SelectedItem;

                negocio.Agregar(AgregarD);

                MessageBox.Show("Se agregó con éxito!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarDisco_Load(object sender, EventArgs e)
        {
            EstilosServer estilo = new EstilosServer();
            TiposEdicionServer formato = new TiposEdicionServer();
            
            try
            {
                cboEstilo.DataSource = estilo.ListarEstilos();
                cboEdicion.DataSource = formato.ListEdicion();

                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpFecha.Value = disco.FechaDeLazamiento;
                    txtCantidadCanciones.Text = disco.CantidadDeCanciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagenCover;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            ImageLoader(txtUrlImagen.Text);
        }

        private void ImageLoader(string Image)
        {
            try
            {
                pbxUrlImagen.Load(Image);
            }
            catch (Exception)
            {

                pbxUrlImagen.Load("https://community.softr.io/uploads/db9110/original/2X/7/74e6e7e382d0ff5d7773ca9a87e6f6f8817a68a6.jpeg");
            }
        }
    }
}
