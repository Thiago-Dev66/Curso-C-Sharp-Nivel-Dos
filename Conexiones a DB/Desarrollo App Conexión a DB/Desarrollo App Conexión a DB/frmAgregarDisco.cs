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
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
