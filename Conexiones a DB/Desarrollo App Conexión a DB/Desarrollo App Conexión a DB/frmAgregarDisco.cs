using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo_App_Conexión_a_DB
{
    public partial class frmAgregarDisco : Form
    {
        private Disco disco = null;
        private OpenFileDialog archivo = null;
        public frmAgregarDisco()
        {
            InitializeComponent();
        }
        public frmAgregarDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            DiscosServer negocio = new DiscosServer();

            try
            {
                if (disco == null)
                    disco = new Disco();

                disco.Titulo = txtTitulo.Text;
                disco.FechaDeLazamiento = dtpFecha.Value;
                
                if (!int.TryParse(txtCantidadCanciones.Text, out int cantidad))
                {
                    MessageBox.Show("Ingrese un valor valido");
                    return;
                }
                disco.CantidadDeCanciones = cantidad;
                disco.UrlImagenCover = txtUrlImagen.Text;
                disco.Estilo = (Estilos)cboEstilo.SelectedItem;
                disco.Edicion = (TipoEdicion)cboEdicion.SelectedItem;    

                if (disco.Id != 0)
                {
                    negocio.Modificar(disco);
                    MessageBox.Show("Se modificó con éxito!");
                    Close();
                }
                else
                {
                    negocio.Agregar(disco);
                    MessageBox.Show("Se agregó con éxito!");
                    Close();
                }

                //guardamos la imagen 
                if (!txtUrlImagen.Text.ToUpper().Contains("HTTP") && archivo != null) 
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["appDisco-images"] + archivo.SafeFileName);
                }
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
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboEdicion.DataSource = formato.ListEdicion();
                cboEdicion.ValueMember = "Id";
                cboEdicion.DisplayMember = "Description";

                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpFecha.Value = disco.FechaDeLazamiento;
                    txtCantidadCanciones.Text = disco.CantidadDeCanciones.ToString();
                    txtUrlImagen.Text = disco.UrlImagenCover;
                    cboEstilo.SelectedValue = disco.Estilo.Id;
                    cboEdicion.SelectedValue = disco.Edicion.Id;
                    ImageLoader(disco.UrlImagenCover);

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

        private void brnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                archivo = new OpenFileDialog();
                archivo.Filter = "jpg|*.jpg |png|*.png";

                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtUrlImagen.Text = archivo.FileName;
                    ImageLoader(archivo.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
