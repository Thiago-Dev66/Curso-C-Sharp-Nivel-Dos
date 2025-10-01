using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_logic_layer__BLL_;
using Data_access_layer__DAL_;

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
            DiscosServer server = new DiscosServer();
            ListaD = server.ListaDisco();
            dgvDisco.DataSource = ListaD;
            dgvDisco.Columns["UrlImagenCover"].Visible = false;
            
        }

        private void dgvDisco_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDisco.CurrentRow.DataBoundItem; //devuelve el objeto enlazado
            ImageLoader(seleccionado.UrlImagenCover);
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
    }
}
