using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            //this.BackColor = Color.Green;
            if (tB1.Text == "")
                tB1.BackColor = Color.AliceBlue;
            else
                tB1.BackColor = System.Drawing.SystemColors.Control;
            bt1.Cursor = Cursors.Cross;
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

        private void tB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void txtBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtBox2.Text.Length + " caracteres");
        }
    }
}
