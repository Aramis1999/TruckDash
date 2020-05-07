using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED___Proyecto.Class
{
    public class Comida
    {
        private string nombre;
        private double precio;
        private string tipo;

        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Tipo { get => tipo; set => tipo = value; }

    }
}
