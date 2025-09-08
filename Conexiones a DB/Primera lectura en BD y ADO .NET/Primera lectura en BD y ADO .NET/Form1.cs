using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primera_lectura_en_BD_y_ADO.NET
{
    public partial class frmPokemon : Form
    {
        private List<Pokemon> listaPokemon;

        public frmPokemon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokedexServer server = new PokedexServer();
            listaPokemon = server.ListaP();
            dgvPokemon.DataSource = listaPokemon;
            picboxPokemon.Load(listaPokemon[0].UrlImagen);
        }
    }
}
