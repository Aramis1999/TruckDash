using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED___Proyecto.Class
{
    public class Mesa
    {
        private int id;
        private Cliente silla1;
        private Cliente silla2;
        private int estado;

        public int Id { get => id; set => id = value; }
        public Cliente Silla1 { get => silla1; set => silla1 = value; }
        public Cliente Silla2 { get => silla2; set => silla2 = value; }
        public int Estado { get => estado; set => estado = value; }

        public void asignarMesa(Cliente cliente)
        {
            Mesa mesa1 = new Mesa();
            mesa1.Id = 1;
            mesa1.Silla1 = null;
            mesa1.Silla2 = null;
            mesa1.estado = 1;

            Mesa mesa2 = new Mesa();
            mesa2.Id = 1;
            mesa2.Silla1 = null;
            mesa2.Silla2 = null;
            mesa2.estado = 1;

            Mesa mesa3 = new Mesa();
            mesa3.Id = 1;
            mesa3.Silla1 = null;
            mesa3.Silla2 = null;
            mesa3.estado = 1;

            Mesa mesa4 = new Mesa();
            mesa4.Id = 1;
            mesa4.Silla1 = null;
            mesa4.Silla2 = null;
            mesa4.estado = 1;

            //Comprobando la disponibilidad de las mesa 1
            if (mesa1.Estado == 1)
            {
                if(mesa1.Silla1 == null)
                {
                    mesa1.Silla1 = cliente;
                    MessageBox.Show("Asignado");
                }
                if (mesa1.Silla2 == null)
                {
                    mesa1.Silla2 = cliente;
                    MessageBox.Show("Asignado");
                    mesa1.estado = 0;
                }
            }

            //Comprobando la disponibilidad de las mesa 2
            if (mesa2.Estado == 1)
            {
                if (mesa2.Silla1 == null)
                {
                    mesa2.Silla1 = cliente;
                    MessageBox.Show("Asignado");
                }
                if (mesa2.Silla2 == null)
                {
                    mesa2.Silla2 = cliente;
                    MessageBox.Show("Asignado");
                    mesa2.Estado = 0;
                }
            }

            //Comprobando la disponibilidad de las mesa 3
            if (mesa3.Estado == 1)
            {
                if (mesa3.Silla1 == null)
                {
                    mesa3.Silla1 = cliente;
                    MessageBox.Show("Asignado");
                }
                if (mesa3.Silla2 == null)
                {
                    mesa3.Silla2 = cliente;
                    MessageBox.Show("Asignado");
                    mesa3.Estado = 0;
                }
            }

            //Comprobando la disponibilidad de las mesa 4
            if (mesa4.Estado == 1)
            {
                if (mesa4.Silla1 == null)
                {
                    mesa4.Silla1 = cliente;
                    MessageBox.Show("Asignado");
                }
                if (mesa4.Silla2 == null)
                {
                    mesa4.Silla2 = cliente;
                    MessageBox.Show("Asignado");
                    mesa4.Estado = 0;
                }
            }
            else
            {
                MessageBox.Show("Todas las mesas estan llenas");
            }
        }
    }
}
