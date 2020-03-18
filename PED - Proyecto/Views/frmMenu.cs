using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED___Proyecto
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = @"menu.mp3";
            wplayer.controls.play();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pnlSalir_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pnlSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSalir_MouseLeave(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.White;
            lblSalir.BorderStyle = BorderStyle.None;
        }

        private void lblSalir_MouseEnter(object sender, EventArgs e)
        {
            lblSalir.ForeColor = Color.FromArgb(255, 224, 192);
            lblSalir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lblOpciones.ForeColor = Color.FromArgb(255, 224, 192);
            lblOpciones.BorderStyle = BorderStyle.Fixed3D;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            lblOpciones.ForeColor = Color.White;
            lblOpciones.BorderStyle = BorderStyle.None;
        }

        private void lblCreditos_MouseLeave(object sender, EventArgs e)
        {
            lblCreditos.ForeColor = Color.White;
            lblCreditos.BorderStyle = BorderStyle.None;
        }

        private void lblCreditos_MouseEnter(object sender, EventArgs e)
        {
            lblCreditos.ForeColor = Color.FromArgb(255, 224, 192);
            lblCreditos.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lblFoodash_MouseEnter(object sender, EventArgs e)
        {
            lblFoodash.ForeColor = Color.FromArgb(255, 224, 192);
            lblFoodash.BorderStyle = BorderStyle.Fixed3D;
        }

        private void lblFoodash_MouseLeave(object sender, EventArgs e)
        {
            lblFoodash.ForeColor = Color.White;
            lblFoodash.BorderStyle = BorderStyle.None;
        }
    }
}
