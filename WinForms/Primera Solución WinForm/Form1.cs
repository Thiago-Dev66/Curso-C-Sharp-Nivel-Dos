using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primera_Solución_WinForm
{
    public partial class Form1 : Form //"Parcial" es un modificador que nos permite tener por separado
                                      //la misma clase en varias partes
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hola, Mundo");
            string text = txtName.Text;
            lblSlaudo.Text = "Hola " + text; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido");
        }

    }
}
