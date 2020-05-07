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

namespace PED___Proyecto.Views
{
    
    public partial class frmComida : Form
    {

        Comida comida = new Comida();

        public delegate void pasarComida(Comida comida);
        public event pasarComida pasado;

        public frmComida()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void pHelado_MouseLeave(object sender, EventArgs e)
        {
            pHelado.ForeColor = Color.Black;
            pHelado.BorderStyle = BorderStyle.None;
        }

        private void pCrepe_MouseLeave(object sender, EventArgs e)
        {
            pCrepe.ForeColor = Color.Black;
            pCrepe.BorderStyle = BorderStyle.None;
        }

        private void pHelado_MouseEnter(object sender, EventArgs e)
        {
            pHelado.ForeColor = Color.FromArgb(0,0,0);
            pHelado.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pCrepe_MouseEnter(object sender, EventArgs e)
        {
            pCrepe.ForeColor = Color.FromArgb(0, 0, 0);
            pCrepe.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pPapas_MouseLeave(object sender, EventArgs e)
        {
            pPapas.ForeColor = Color.Black;
            pPapas.BorderStyle = BorderStyle.None;
        }

        private void pPapas_MouseEnter(object sender, EventArgs e)
        {
            pPapas.ForeColor = Color.FromArgb(0, 0, 0);
            pPapas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pBrochetas_MouseLeave(object sender, EventArgs e)
        {
            pBrochetas.ForeColor = Color.Black;
            pBrochetas.BorderStyle = BorderStyle.None;
        }

        private void pBrochetas_MouseEnter(object sender, EventArgs e)
        {
            pBrochetas.ForeColor = Color.FromArgb(0, 0, 0);
            pBrochetas.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pRefresco_MouseLeave(object sender, EventArgs e)
        {
            pRefresco.ForeColor = Color.Black;
            pRefresco.BorderStyle = BorderStyle.None;
        }

        private void pRefresco_MouseEnter(object sender, EventArgs e)
        {
            pRefresco.ForeColor = Color.FromArgb(0, 0, 0);
            pRefresco.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pGaseosa_MouseLeave(object sender, EventArgs e)
        {
            pGaseosa.ForeColor = Color.Black;
            pGaseosa.BorderStyle = BorderStyle.None;
        }

        private void pGaseosa_MouseEnter(object sender, EventArgs e)
        {
            pGaseosa.ForeColor = Color.FromArgb(0, 0, 0);
            pGaseosa.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pHotDog_MouseEnter(object sender, EventArgs e)
        {
            pHotDog.ForeColor = Color.FromArgb(0, 0, 0);
            pHotDog.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pHotDog_MouseLeave(object sender, EventArgs e)
        {
            pHotDog.ForeColor = Color.Black;
            pHotDog.BorderStyle = BorderStyle.None;
        }

        private void pHamburguesa_MouseEnter(object sender, EventArgs e)
        {
            pHamburguesa.ForeColor = Color.FromArgb(0, 0, 0);
            pHamburguesa.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pHamburguesa_MouseLeave(object sender, EventArgs e)
        {
            pHamburguesa.ForeColor = Color.Black;
            pHamburguesa.BorderStyle = BorderStyle.None;
        }

        private void pPizza_MouseEnter(object sender, EventArgs e)
        {
            pPizza.ForeColor = Color.FromArgb(0, 0, 0);
            pPizza.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pPizza_MouseLeave(object sender, EventArgs e)
        {
            pPizza.ForeColor = Color.Black;
            pPizza.BorderStyle = BorderStyle.None;
        }

        private void pVolver_MouseEnter(object sender, EventArgs e)
        {
            pVolver.ForeColor = Color.FromArgb(0, 0, 0);
            pVolver.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pVolver_MouseLeave(object sender, EventArgs e)
        {
            pVolver.ForeColor = Color.Black;
            pVolver.BorderStyle = BorderStyle.None;
        }

        private void pVolver_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }

        private void pHelado_MouseClick(object sender, MouseEventArgs e)
        {
            comida.Nombre = "Copa de Helado";
            comida.Precio = 3.25;
            comida.Tipo ="Postre";
            pasado(comida);
            this.Hide();
        }

        private void pCrepe_MouseClick(object sender, MouseEventArgs e)
        {
            comida.Nombre = "Crepe dulce";
            comida.Precio = 3.75;
            comida.Tipo = "Postre";
            pasado(comida);
            this.Hide();
        }

        private void pPapas_MouseClick(object sender, MouseEventArgs e)
        {
            comida.Nombre = "Papas fritas";
            comida.Precio = 2.00;
            comida.Tipo = "Entrada";
            pasado(comida);
            this.Hide();
        }

        private void pBrochetas_MouseClick(object sender, MouseEventArgs e)
        {
            comida.Nombre = "Brochetas";
            comida.Precio = 2.50;
            comida.Tipo = "Entrada";
            pasado(comida);
            this.Hide();
        }

        private void pRefresco_MouseClick(object sender, MouseEventArgs e)
        {
            comida.Nombre = "Refresco natural";
            comida.Precio = 1.75;
            comida.Tipo = "Bebida";
            pasado(comida);
            this.Hide();
        }

        private void pGaseosa_MouseClick(object sender, MouseEventArgs e)
        {
            comida.Nombre = "Gaseosa";
            comida.Precio = 1.25;
            comida.Tipo = "Bebida";
            pasado(comida);
            this.Hide();
        }

        private void pHotDog_MouseClick(object sender, MouseEventArgs e)
        {
            comida.Nombre = "HotDog";
            comida.Precio = 4.25;
            comida.Tipo = "Plato fuerte";
            pasado(comida);
            this.Hide();
        }

        private void pHamburguesa_MouseClick(object sender, MouseEventArgs e)
        {
            comida.Nombre = "Hamburguesa";
            comida.Precio = 5.75;
            comida.Tipo = "Plato fuerte";
            pasado(comida);
            this.Hide();
        }

        private void pPizza_MouseClick(object sender, MouseEventArgs e)
        {
            comida.Nombre = "Pizza";
            comida.Precio = 8.50;
            comida.Tipo = "Plato fuerte";
            pasado(comida);
            this.Hide();
        }
    }
}
