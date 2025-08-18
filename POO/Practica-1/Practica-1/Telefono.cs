using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1
{
    internal class Telefono
    {

        public Telefono(string Modelo, string Marca)
        {
            this.Modelo = Modelo;
            this.Marca = Marca;
        }
        public Telefono() { }
        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }
        private int Num;
        public int num
        {
            get { return Num; }
            set
            {
                if (value > 0 && value < 4) { Num = value; }
                else { value = 0; }
            }
        }
        private string Contacto { get; set; }
        public string llamar()
        {
            return "Realizando llamada...";  
        }
        public string llamar(string Contacto)
        {
            this.Contacto = Contacto;
            return "Llamando a " + Contacto; 
        }
    }
}
