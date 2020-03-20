using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PED___Proyecto.Views
{
    public partial class frmAmbiente : Form
    {
        public frmAmbiente()
        {
            InitializeComponent();
        }

        int total = 0;//variable que llevara la posicion del pictureBox
        int esperando = 1;//variable que almacenara la cantidad de clientes que hay en la cola
        bool conto = true;//variable booleana que ayudara a controlar la ejecucion del timer1

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            frmMenu f = new frmMenu();
            f.Show();
            this.Hide();
        }

      

        private void frmAmbiente_Load(object sender, EventArgs e)
        {
            //al cargar el form, se habilita e inicializa el timer1
            timer1.Enabled = true;
            timer1.Start();
               
        }


        //Se ejecuta el metodo timer1_Tick
        //cuando ha transcurrido el intervalo del timer1 especificado 
        //y está habilitado el timer1
        private void timer1_Tick(object sender, EventArgs e)
        {            
            //se verifica que el timer1_Tick no se acaba de ejecutar
            if (conto==true)
            {
                //se incrementa 1 al valor de la variable total
                //Se habilita el timer2
                //y se cambia el estado de la variable conto a falso
                total++;
                timer2.Enabled = true;
                conto = false;
            }
          
        }

        //Se ejecuta el metodo timer2_Tick cuando está habilitado el timer2
        private void timer2_Tick(object sender, EventArgs e)
        {
           //si el el valor de total es igual a 1 y esperando es menor o igual a 4
            if (total == 1 && esperando <= 4)
            {
                //el switch servira para especificar cual 
                //imagen entrara a la cola, eso dependera 
                //de la cantidad que esten esperando en la cola
                switch (esperando)
                {
                    case 1:
                        cuarto.Image = ocho.Image;
                        //si esperando es igual a 1 
                        //se tomara la imagen del 
                        //picturebox8 y se pondra en el cuarto picturebox 
                        break;
                    case 2:
                        cuarto.Image = dos.Image;
                        //si esperando es igual a 2 
                        //se tomara la imagen del 
                        //picturebox2 y se pondra en el cuarto picturebox 
                        break;
                    case 3:
                        cuarto.Image = tres.Image;
                        //si esperando es igual a 3
                        //se tomara la imagen del 
                        //picturebox3 y se pondra en el cuarto picturebox 
                        break;
                    case 4:
                        cuarto.Image = cuatro.Image;
                        //si esperando es igual a 4 
                        //se tomara la imagen del 
                        //picturebox4 y se pondra en el cuarto picturebox 
                        break;
                    case 5:
                        cuarto.Image = cinco.Image;
                        //si esperando es igual a 5 
                        //se tomara la imagen del 
                        //picturebox5 y se pondra en el cuarto picturebox 
                        break;
                    case 6:
                        cuarto.Image = seis.Image;
                        //si esperando es igual a 6 
                        //se tomara la imagen del 
                        //picturebox6 y se pondra en el cuarto picturebox 
                        break;
                    case 7:
                        cuarto.Image = siete.Image;
                        //si esperando es igual a 7 
                        //se tomara la imagen del 
                        //picturebox7 y se pondra en el cuarto picturebox 
                        break;
                    case 8:
                        cuarto.Image = uno.Image;
                        //si esperando es igual a 8 
                        //se tomara la imagen del 
                        //picturebox1 y se pondra en el cuarto picturebox 
                        break;

                    default:                        
                        break;
                }           
                timer2.Enabled = false;//se detiene el timer2
                conto = true;//se cambia la variable conto a verdadero
            }
            //si el el valor de total es igual a 2 y esperando es menor o igual a 3
            if (total == 2 && esperando <= 3)
            {
                //se toma la imagen del  pic cuarto y se pone en el tercero
                tercero.Image = cuarto.Image;
                cuarto.Image = null;
                timer2.Enabled = false;//se detiene el timer2
                conto = true;//se cambia la variable conto a verdadero
            }
            //si el el valor de total es igual a 3 y esperando es menor o igual a 2
            if (total == 3 && esperando <= 2)
            {
                //se toma la imagen del  pic tercero y se pone en el segundo
                segundo.Image = tercero.Image;
                tercero.Image = null;
                timer2.Enabled = false;//se detiene el timer2
                conto = true;       //se cambia la variable conto a verdadero         
            }
            //si el el valor de total es igual a 4 y esperando es menor o igual a 1
            if (total == 4 && esperando <=1)
            {
                //se toma la imagen del  pic segundo y se pone en el primero
                primero.Image = segundo.Image;
                segundo.Image = null;
                timer2.Enabled = false;//se detiene el timer2
                conto = true;//se cambia la variable conto a verdadero
                esperando++;
                total = 0;
            }
           
            //si el el valor de total es igual a 4 y esperando es igual a 2
            if (total==4 && esperando==2)
            {
                total = 0;
                esperando++;
                conto = true;//se cambia la variable conto a verdadero
            }
            //si el el valor de total es igual a 3 y esperando es igual a 3
            if (total == 3 && esperando == 3)
            {
                total = 0;
                esperando++;
                conto = true;//se cambia la variable conto a verdadero
            }

            //si el el valor de total es igual a 2 y esperando es igual a 4
            if (total == 2 && esperando == 4)
            {
                total = 0;
                timer1.Enabled = false;
                MessageBox.Show("La cola esta llena");
                timer2.Enabled = false;//se detiene el timer2
                conto = true;//se cambia la variable conto a verdadero
            }
        }
    }
}
