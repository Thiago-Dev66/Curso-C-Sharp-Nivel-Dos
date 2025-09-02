using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_de_Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Las excepciones nos permiten preparar nuestras aplicaciones para que puedan
            //enfrentarse ante escenrios que no estaban pensados.

            //Permite que la aplicacion capture el error en el momento y pueda tomar accion 
            //para que el programa no se rompa.

            //Capturamos la excepcion con "try":

            int resultado;

            try //intenta ejecutar
            {
                resultado = Calcular();

                label1.Text = "= " + resultado;
            }
            //Podemos tener muchos "catch" para manejar otros tipos de excepciones:
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero", ex.ToString());
            }

            //"Exception" captura todas las excepciones posibles:
            catch (Exception variableAqui) //captura el error cuando "try" no puede ejecutar
            {
                MessageBox.Show("No se pudo realizar el calculo; intente de nuevo");
            }
            finally //Puede o no estar
            {
                //"finally" es un bloque que contiene codigo que se va ajecutar de manera indiferente,
                //sin importar si pasó o no por el bloque "catch".
                //Son instrucciones que sí o sí necesito que se ejecuten.
                //Muy util para cuando trabajamos con datos sensibles, por ejemplo con servidores
            }
        }

        private int Calcular()
        {
            int a, b, resultado;
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);

                resultado = a / b;

                return resultado;
            }
            catch (Exception ex)//este catch no muestra una excepcion, sino que devuleve un resultado con "throw".
            {

                throw ex; //"throw" devuelve (lanza) la excepcion en caso de que el metodo falle, porque una
                          //funcion debe devolver algo imperativamente.
            }
        }
    }
}
