using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Desarrollo_App_Conexión_a_DB
{
    public partial class DiscosForm : Form
    {
        private List<Disco> ListaD;

        public DiscosForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void dgvDisco_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDisco.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgvDisco.CurrentRow.DataBoundItem; //devuelve el objeto enlazado
                ImageLoader(seleccionado.UrlImagenCover);
            }
        }
        private void ImageLoader(string Image)
        {
            try
            {
                pbxDisco.Load(Image);
            }
            catch (Exception)
            {

                pbxDisco.Load("https://community.softr.io/uploads/db9110/original/2X/7/74e6e7e382d0ff5d7773ca9a87e6f6f8817a68a6.jpeg");
            }
        }
        private void Cargar() 
        {
            try
            {
                DiscosServer server = new DiscosServer(); //Instanciamos el server
                ListaD = server.ListaDisco(); //Llamamos al método que nos devuelve la lista de discos
                dgvDisco.DataSource = ListaD; //Asignamos la lista al DataSource del DataGridView
                OcultarColumnas(); 
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }

        private void OcultarColumnas()
        {
            dgvDisco.Columns["UrlImagenCover"].Visible = false;
            dgvDisco.Columns["Id"].Visible = false;
            dgvDisco.Columns["Activo"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarDisco agregar = new frmAgregarDisco();
            agregar.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dgvDisco.CurrentRow.DataBoundItem;
            
            frmAgregarDisco modificar = new frmAgregarDisco(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void Eliminar(bool logico = false)
        {
            DiscosServer discosServer = new DiscosServer();
            Disco seleccionado;

            try
            {
                DialogResult result = MessageBox.Show("Estas seguro que deseas eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDisco.CurrentRow.DataBoundItem;

                    if (logico)
                        discosServer.EliminarLogico(seleccionado.Id);
                    else
                        discosServer.Eliminar(seleccionado.Id);
                    
                    Cargar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filterText = txtFiltrar.Text;

            if(filterText != "") //Si el textbox no está vacío buscamos la coincidencia
            {
                listaFiltrada = ListaD.FindAll(x => x.Titulo.ToUpper().Contains(filterText.ToUpper()) || x.Edicion.Description.ToUpper().Contains(filterText.ToUpper())); //Esto es una condición lógica (función lambda =>)
                //"ListaD" es un tipo "List" y "List" es un tipo collection, por lo tanto tienen diferentes tipos de metodos. Aquí usamos el "FindAll" que
                //devuelve todos los objetos que hagan match con la clave de busqueda que le demos y el "Contains" devuelve true o false si una cadena está contenida en la otra.
            }
            else //Si el textbox está vacío cargamos la lista completa
            {
                listaFiltrada = ListaD;
            }

            dgvDisco.DataSource = null; //Actualizamos el datasource
            dgvDisco.DataSource = listaFiltrada; //Le damos la nueva lista filtrada
            OcultarColumnas();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
