using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PED___Proyecto.Class
{
    class Cliente
    {

        //El id que determina cada cliente
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        //El tipo de cliente, existen 9 opciones (imagenes)
        private int tipo;
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        //Estado del cliente. Despachado o Espera. Espera = 1; Despachado = 2;
        private int estado;
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
