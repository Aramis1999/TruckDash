using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED___Proyecto.Class
{
    public class Asignar
    {

        Mesa mesa1 = new Mesa();
        Mesa mesa2 = new Mesa();
        Mesa mesa3 = new Mesa();
        Mesa mesa4 = new Mesa();

        public void asignarMesa(Cliente cliente)
        {

            //Comprobando la disponibilidad de las mesa 1
            if (mesa1.Silla1 != null)
            {
                if (mesa1.Silla2 != null)
                {
                    if (mesa2.Silla1 != null)
                    {
                        if (mesa2.Silla2 != null)
                        {
                            if (mesa3.Silla1 != null)
                            {
                                if (mesa3.Silla2 != null)
                                {
                                    if (mesa4.Silla1 != null)
                                    {
                                        if (mesa4.Silla2 != null)
                                        {
                                            MessageBox.Show("Las sillas estan llenas");
                                        }
                                        else
                                        {
                                            mesa4.Silla2 = cliente;
                                            MessageBox.Show("Asignado");
                                        }

                                    }
                                    else
                                    {
                                        mesa4.Silla1 = cliente;
                                        MessageBox.Show("Asignado");
                                    }
                                }
                                else
                                {
                                    mesa3.Silla2 = cliente;
                                    MessageBox.Show("Asignado");
                                }

                            }
                            else
                            {
                                mesa3.Silla1 = cliente;
                                MessageBox.Show("Asignado");
                            }
                        }
                        else
                        {
                            mesa2.Silla2 = cliente;
                            MessageBox.Show("Asignado");
                        }

                    }
                    else
                    {
                        mesa2.Silla1 = cliente;
                        MessageBox.Show("Asignado");
                    }
                }
                else
                {
                    mesa1.Silla2 = cliente;
                    MessageBox.Show("Asignado");
                }

            }
            else
            {
                mesa1.Silla1 = cliente;
                MessageBox.Show("Asignado");
            }
        }
    }
}
