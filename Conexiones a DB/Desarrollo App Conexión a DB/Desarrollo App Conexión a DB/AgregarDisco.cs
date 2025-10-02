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
                AgregarD.CantidadDeCanciones = int.Parse(txtCantidadCanciones.Text);

                negocio.Agregar(AgregarD);

                MessageBox.Show("Se agregó con éxito!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }
    }
}
