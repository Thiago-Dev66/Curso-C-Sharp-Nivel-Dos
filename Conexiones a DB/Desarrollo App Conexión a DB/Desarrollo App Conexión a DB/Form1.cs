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
    public partial class Form1 : Form
    {
        private List<Disco> ListaD;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscosServer server = new DiscosServer();
            ListaD = server.ListaDisco();
            dgvDisco.DataSource = ListaD;
            pbxDisco.Load(ListaD[0].UrlImagenCover);
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
