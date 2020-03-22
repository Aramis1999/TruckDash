using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED___Proyecto.Class
{
    class Cola
    {

        private Nodo primero;
        private Nodo ultimo;

        public Cola()
        {
            primero = ultimo = null;
        }

        public int getLastId()
        {
            int valor = 0;
            valor = ultimo.info.Id;
            return valor;
        }

        public int getLastEstado()
        {
            int valor = 0;
            valor = ultimo.info.Estado;
            return valor;
        }

        public int getLastTipo()
        {
            int valor = 0;
            valor = ultimo.info.Tipo;
            return valor;
        }

        public void Encolar(string dato)
        {
            Nodo aux = new Nodo();
            Cliente valor = new Cliente();
            if (primero == null)
            {
                valor.Id = 1;
                primero = ultimo = aux;
                aux.sgte = null;
            }
            else
            {
                valor.Id = ultimo.info.Id + 1;
                ultimo.sgte = aux;
                aux.sgte = null;
                ultimo = aux;
            }
            Random random = new Random();
            valor.Tipo = random.Next(9);
            valor.Estado = 1;
            valor.Nombre = dato;
            aux.info = valor;
        }

        public int Contar()
        {
            int cantidad = 0;
            if (primero != null)
            {
                Nodo auxiliar = new Nodo();
                auxiliar = primero;
                do
                {
                    auxiliar = auxiliar.sgte;
                    cantidad++;
                } while (auxiliar != null);
            }
            return cantidad;
        }

        public void Desencolar()
        {
            if (primero == null) Console.WriteLine("Cola Vacia");
            else primero = primero.sgte;
        }

        public void Mostrar()
        {
            if (primero == null) MessageBox.Show("Cola vacia");
            else
            {
                string cadena = string.Empty;
                Nodo puntero;
                puntero = primero;
                do
                {
                    if (puntero == primero)
                    {
                        cadena = cadena + "  Inicio: ";
                    }
                    cadena = cadena + puntero.info.Id +". " + puntero.info.Nombre +  " ----> ";
                    puntero = puntero.sgte;
                } while (puntero != null);
                MessageBox.Show(cadena);
            }
        }

    }
}
