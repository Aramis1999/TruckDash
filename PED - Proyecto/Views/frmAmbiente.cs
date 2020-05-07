using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PED___Proyecto.Class;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace PED___Proyecto.Views
{
    public partial class frmAmbiente : Form
    {
        public frmAmbiente()
        {
            InitializeComponent();
        }


        int total = 1;//variable que llevara la posicion del pictureBox
        //int esperando = 1;//variable que almacenara la cantidad de clientes que hay en la cola
        bool conto = true;//variable booleana que ayudara a controlar la ejecucion del timer1
        bool desplazamiento_terminado = false;
        Cola ColaEspera = new Cola();


        void asignarImg(Image image)
        {
            if (silla1.Image != null)
            {
                if (silla2.Image != null)
                {
                    if (silla3.Image != null)
                    {
                        if (silla4.Image != null)
                        {
                            if (silla5.Image != null)
                            {
                                if (silla6.Image != null)
                                {
                                    if (silla7.Image != null)
                                    {
                                        if (silla8.Image != null)
                                        {
                                            MessageBox.Show("Las sillas estan llenas (Grafico)");
                                        }
                                        else
                                        {
                                            silla8.Image = image;
                                        }
                                    }
                                    else
                                    {
                                        silla7.Image = image;
                                    }
                                }
                                else
                                {
                                    silla6.Image = image;
                                }
                            }
                            else
                            {
                                silla5.Image = image;
                            }
                        }
                        else
                        {
                            silla4.Image = image;
                        }
                    }
                    else
                    {
                        silla3.Image = image;
                    }
                }
                else
                {
                    silla2.Image = image;
                }
            }
            else
            {
                silla1.Image = image;
            }
        }


        void imagen(int tipo)
        {
            Image imagen = null;
            switch (tipo)
            {
                case 1:
                    imagen = Properties.Resources.uno;
                    break;

                case 2:
                    imagen = Properties.Resources.dos;
                    break;

                case 3:
                    imagen = Properties.Resources.tres;
                    break;

                case 4:
                    imagen = Properties.Resources.cuatro;
                    break;

                case 5:
                    imagen = Properties.Resources.cinco;
                    break;

                case 6:
                    imagen = Properties.Resources.seis;
                    break;

                case 7:
                    imagen = Properties.Resources.siete;
                    break;

                case 8:
                    imagen = Properties.Resources.ocho;
                    break;

                case 9:
                    imagen = Properties.Resources.nueve;
                    break;
            }

            asignarImg(imagen);
        }

        public void asignar(int lugar)
        {
            
            if(lugar == 1)
            {
                int tipo = ColaEspera.getTipoFirst();
                ColaEspera.extraerPrimero();
                imagen(tipo);
                desencolar();
            }
            else
            {
                desencolar();

            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            frmMenu f = new frmMenu();
            f.Show();
            this.Hide();
        }

      

        private void frmAmbiente_Load(object sender, EventArgs e)
        {
        }


        //Se ejecuta el metodo timer1_Tick
        //cuando ha transcurrido el intervalo del timer1 especificado 
        //y está habilitado el timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            ////se verifica que el timer1_Tick no se acaba de ejecutar
            //if (conto == true)
            //{
            //    //se incrementa 1 al valor de la variable total
            //    //Se habilita el timer2
            //    //y se cambia el estado de la variable conto a falso
            //    total++;
            //    timer2.Enabled = true;
            //    conto = false;
            //}

        }

        private void Encolar()
        {
            if(total <= 4)
            {
                string nombre = string.Empty;
                using(frmAlerta alerta = new frmAlerta("Nombre del cliente: "))
                {
                    if(alerta.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        nombre = alerta.SelectedText;
                    }
                }
                ColaEspera.Encolar(nombre);
                int id = ColaEspera.getLastId();
                int estado = ColaEspera.getLastEstado();
                int tipo = ColaEspera.getLastTipo();
                switch (tipo)
                {
                    case 1:
                        cuarto.Image = uno.Image;
                        break;

                    case 2:
                        cuarto.Image = dos.Image;
                        break;

                    case 3:
                        cuarto.Image = tres.Image;
                        break;

                    case 4:
                        cuarto.Image = cuatro.Image;
                        break;

                    case 5:
                        cuarto.Image = cinco.Image;
                        break;

                    case 6:
                        cuarto.Image = seis.Image;
                        break;

                    case 7:
                        cuarto.Image = siete.Image;
                        break;

                    case 8:
                        cuarto.Image = ocho.Image;
                        break;

                    case 9:
                        cuarto.Image = nueve.Image;
                        break;
                }
                desplazar();
                total++;
            }
        }

        //Se ejecuta el metodo timer2_Tick cuando está habilitado el timer2
        private void timer2_Tick(object sender, EventArgs e)
        {
           ////si el el valor de total es igual a 1 y esperando es menor o igual a 4
           // if (total == 1 && esperando <= 4)
           // {
           //     //el switch servira para especificar cual 
           //     //imagen entrara a la cola, eso dependera 
           //     //de la cantidad que esten esperando en la cola
           //     switch (esperando)
           //     {
           //         case 1:
           //             cuarto.Image = ocho.Image;
           //             //si esperando es igual a 1 
           //             //se tomara la imagen del 
           //             //picturebox8 y se pondra en el cuarto picturebox 
           //             break;
           //         case 2:
           //             cuarto.Image = dos.Image;
           //             //si esperando es igual a 2 
           //             //se tomara la imagen del 
           //             //picturebox2 y se pondra en el cuarto picturebox 
           //             break;
           //         case 3:
           //             cuarto.Image = tres.Image;
           //             //si esperando es igual a 3
           //             //se tomara la imagen del 
           //             //picturebox3 y se pondra en el cuarto picturebox 
           //             break;
           //         case 4:
           //             cuarto.Image = cuatro.Image;
           //             //si esperando es igual a 4 
           //             //se tomara la imagen del 
           //             //picturebox4 y se pondra en el cuarto picturebox 
           //             break;
           //         case 5:
           //             cuarto.Image = cinco.Image;
           //             //si esperando es igual a 5 
           //             //se tomara la imagen del 
           //             //picturebox5 y se pondra en el cuarto picturebox 
           //             break;
           //         case 6:
           //             cuarto.Image = seis.Image;
           //             //si esperando es igual a 6 
           //             //se tomara la imagen del 
           //             //picturebox6 y se pondra en el cuarto picturebox 
           //             break;
           //         case 7:
           //             cuarto.Image = siete.Image;
           //             //si esperando es igual a 7 
           //             //se tomara la imagen del 
           //             //picturebox7 y se pondra en el cuarto picturebox 
           //             break;
           //         case 8:
           //             cuarto.Image = uno.Image;
           //             //si esperando es igual a 8 
           //             //se tomara la imagen del 
           //             //picturebox1 y se pondra en el cuarto picturebox 
           //             break;

           //         default:                        
           //             break;
           //     }
           //     MessageBox.Show("pudin");
           //     timer2.Enabled = false;//se detiene el timer2
           //     conto = true;//se cambia la variable conto a verdadero
           // }
           // //si el el valor de total es igual a 2 y esperando es menor o igual a 3
           // if (total == 2 && esperando <= 3)
           // {
           //     //se toma la imagen del  pic cuarto y se pone en el tercero
           //     tercero.Image = cuarto.Image;
           //     cuarto.Image = null;
           //     timer2.Enabled = false;//se detiene el timer2
           //     conto = true;//se cambia la variable conto a verdadero
           // }
           // //si el el valor de total es igual a 3 y esperando es menor o igual a 2
           // if (total == 3 && esperando <= 2)
           // {
           //     //se toma la imagen del  pic tercero y se pone en el segundo
           //     segundo.Image = tercero.Image;
           //     tercero.Image = null;
           //     timer2.Enabled = false;//se detiene el timer2
           //     conto = true;       //se cambia la variable conto a verdadero         
           // }
           // //si el el valor de total es igual a 4 y esperando es menor o igual a 1
           // if (total == 4 && esperando <=1)
           // {
           //     //se toma la imagen del  pic segundo y se pone en el primero
           //     primero.Image = segundo.Image;
           //     segundo.Image = null;
           //     timer2.Enabled = false;//se detiene el timer2
           //     conto = true;//se cambia la variable conto a verdadero
           //     esperando++;
           //     total = 0;
           // }
           
           // //si el el valor de total es igual a 4 y esperando es igual a 2
           // if (total==4 && esperando==2)
           // {
           //     total = 0;
           //     esperando++;
           //     conto = true;//se cambia la variable conto a verdadero
           // }
           // //si el el valor de total es igual a 3 y esperando es igual a 3
           // if (total == 3 && esperando == 3)
           // {
           //     total = 0;
           //     esperando++;
           //     conto = true;//se cambia la variable conto a verdadero
           // }

           // //si el el valor de total es igual a 2 y esperando es igual a 4
           // if (total == 2 && esperando == 4)
           // {
           //     total = 0;
           //     timer1.Enabled = false;
           //     MessageBox.Show("La cola esta llena");
           //     timer2.Enabled = false;//se detiene el timer2
           //     conto = true;//se cambia la variable conto a verdadero
           // }
        }

        private void desplazar()
        {
            switch (total)
            {
                case 1:
                    for (int i = 1; i <= 3; i++)
                    {
                        wait(1000);
                        if (tercero.Image == null && segundo.Image == null & primero.Image == null)
                        {
                            tercero.Image = cuarto.Image;
                            cuarto.Image = null;
                        }
                        else if (segundo.Image == null & primero.Image == null)
                        {
                            segundo.Image = tercero.Image;
                            tercero.Image = null;
                        }
                        else if (primero.Image == null)
                        {
                            primero.Image = segundo.Image;
                            segundo.Image = null;
                            desplazamiento_terminado = true;
                        }
                    }
                    break;

                case 2:
                    for (int i = 1; i <= 2; i++)
                    {
                        wait(1000);
                        if (tercero.Image == null && segundo.Image == null)
                        {
                            tercero.Image = cuarto.Image;
                            cuarto.Image = null;
                        }
                        else if (segundo.Image == null)
                        {
                            segundo.Image = tercero.Image;
                            tercero.Image = null;
                            desplazamiento_terminado = true;
                        }
                    }
                    break;

                case 3:
                    for (int i = 1; i <= 1; i++)
                    {
                        wait(1000);
                        if (tercero.Image == null)
                        {
                            tercero.Image = cuarto.Image;
                            cuarto.Image = null;
                            desplazamiento_terminado = true;
                        }
                    }
                    break;
            }
        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (total <= 4)
            {
                if (desplazamiento_terminado || total == 1)
                {
                    desplazamiento_terminado = false;
                    Encolar();
                }
            }
            btnInicio.Visible = false;
            btnEncolar.Visible = true;
            btnDesccolar.Visible = true;
            btnAtender.Visible = true;
            btnVentas.Visible = true;
           // ColaEspera.Mostrar();
        }

        private void desencolar()
        {
            ColaEspera.Desencolar();
            total--;
            primero.Image = segundo.Image;
            segundo.Image = tercero.Image;
            tercero.Image = cuarto.Image;
            cuarto.Image = null;
           // ColaEspera.Mostrar();
        }

        private void btnDesccolar_Click(object sender, EventArgs e)
        {
            desencolar();

        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            Encolar();
           // ColaEspera.Mostrar();
        }

        List<Comida> comidas = new List<Comida>();
        frmComida food = new frmComida();
        private void button1_Click_1(object sender, EventArgs e)
        {
            int valor;
            using (frmLugarComer alerta = new frmLugarComer())
            {
                if (alerta.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
                {
                    valor = 1;
                    

                }
                else
                {
                    valor = 0;
                    
                }
            }
            asignar(valor);
            food.Show();
            food.pasado += Food_pasado;
        }

        private void Food_pasado(Comida comida)
        {
            comidas.Add(comida);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas(comidas);
            ventas.Show();
        }

        private void silla1_Click(object sender, EventArgs e)
        {
            silla1.Image = null;
            MessageBox.Show("Silla desocupada");
        }

        private void silla2_Click(object sender, EventArgs e)
        {
            silla2.Image = null;
            MessageBox.Show("Silla desocupada");
        }

        private void silla3_Click(object sender, EventArgs e)
        {
            silla3.Image = null;
            MessageBox.Show("Silla desocupada");
        }

        private void silla4_Click(object sender, EventArgs e)
        {
            silla4.Image = null;
            MessageBox.Show("Silla desocupada");
        }

        private void silla5_Click(object sender, EventArgs e)
        {
            silla5.Image = null;
            MessageBox.Show("Silla desocupada");
        }

        private void silla6_Click(object sender, EventArgs e)
        {
            silla6.Image = null;
            MessageBox.Show("Silla desocupada");
        }

        private void silla7_Click(object sender, EventArgs e)
        {
            silla7.Image = null;
            MessageBox.Show("Silla desocupada");
        }

        private void silla8_Click(object sender, EventArgs e)
        {
            silla8.Image = null;
            MessageBox.Show("Silla desocupada");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            silla1.Image = null;
            silla2.Image = null;
            MessageBox.Show("Mesa desocupada");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            silla3.Image = null;
            silla4.Image = null;
            MessageBox.Show("Mesa desocupada");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            silla5.Image = null;
            silla6.Image = null;
            MessageBox.Show("Mesa desocupada");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            silla7.Image = null;
            silla8.Image = null;
            MessageBox.Show("Mesa desocupada");
        }
    }
}
