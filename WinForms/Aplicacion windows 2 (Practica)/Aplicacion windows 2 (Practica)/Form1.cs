using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_windows_2__Practica_
{
    public partial class FormDatosPersonales : Form
    {
        public FormDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;

            if(int.TryParse(txtEdad.Text, out int edadval)) 
            { 
            
            }
            else
                MessageBox.Show("Ingrese un numero valido");

                string direccion = txtDireccion.Text;

            if(!string.IsNullOrWhiteSpace(txtApellido.Text) &&
               !string.IsNullOrWhiteSpace(txtNombre.Text) &&
               !string.IsNullOrWhiteSpace(txtDireccion.Text) &&
               !string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                txtResultado.Text = "Nombre y apellido " + nombre.ToUpper() + " " + apellido.ToUpper() + Environment.NewLine;
                txtResultado.Text += "Edad " + edadval + Environment.NewLine;
                txtResultado.Text += "Direccion " + direccion.ToUpper();
            }
            else
            {
                MessageBox.Show("Debe rellenar los campos que faltan");

                lblApellido.ForeColor = string.IsNullOrWhiteSpace(txtApellido.Text) ? Color.Red : Color.Black;
                lblNombre.ForeColor = string.IsNullOrWhiteSpace(txtNombre.Text) ? Color.Red : Color.Black;
                lblDireccion.ForeColor = string.IsNullOrWhiteSpace(txtDireccion.Text) ? Color.Red : Color.Black;
                lblEdad.ForeColor = string.IsNullOrWhiteSpace(txtEdad.Text) ? Color.Red : Color.Black;
            }

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {
            txtApellido.Focus();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void lblEdad_Click(object sender, EventArgs e)
        {
            txtEdad.Focus();
        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {
            txtDireccion.Focus();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            btnAceptar.BackColor = Color.Cornsilk;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Cornsilk;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = System.Drawing.SystemColors.Control;
        }
    }
}

