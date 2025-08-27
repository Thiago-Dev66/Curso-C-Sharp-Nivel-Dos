using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Practica
{
    public partial class WinformPractica : Form
    {
        public WinformPractica()
        {
            InitializeComponent();
        }

        private void WinformPractica_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido!");
        }

        private void WinformPractica_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Adios");
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Evento OnClick");
            this.BackColor = Color.Green;
         
        }

        private void WinformPractica_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.AntiqueWhite;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Cursor = Cursors.Hand;
        }

       
    }
}
