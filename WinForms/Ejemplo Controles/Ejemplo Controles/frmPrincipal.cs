using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Controles
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1(); //Creamos una instancia del objeto "Form1" dentro de la ventana principal
            ventana.ShowDialog(); //y mostramos 
        }

        private void tsPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 perfil = new Form1();
            perfil.ShowDialog();
        }
    }
}
