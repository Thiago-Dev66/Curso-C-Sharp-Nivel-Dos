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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //string elemento = txtName.Text;
            //lwElementos.Items.Add(elemento);
        }

        private void cbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtName.Text;
            DateTime date = dtpPersona.Value;
            string nacionalidad = txtNacionalidad.Text;
            //Operador ternario (if de una linea):
            string choco = chboxChoco.Checked == true ? "Le gusta el chocolate" : "No le gusta el chocolate";
            string banda;
            if (rbBlack.Checked)
                banda = rbBlack.Text;
            else if (rbMaiden.Checked)
                banda = rbMaiden.Text;
            else
                banda = rbMetallica.Text;
            string colorfav = cbColores.SelectedItem.ToString();
            string numfav = numericUpDown1.Value.ToString();

            string perfil = nombre + date + nacionalidad + choco + banda + colorfav + numfav;

            MessageBox.Show(perfil);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColores.Items.Add("Verde");
            cbColores.Items.Add("Azul");
            cbColores.Items.Add("Negro");
            cbColores.Items.Add("Rojo");
        }
    }
}