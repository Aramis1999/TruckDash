using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PED___Proyecto.Views;

namespace PED___Proyecto
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void font()
        {
            //Create your private font collection object.
            PrivateFontCollection pfc = new PrivateFontCollection();

            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.FallIsComingRegular_Mx9B.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.FallIsComingRegular_Mx9B;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            lblCreditos.Font = new Font(pfc.Families[0], lblCreditos.Font.Size);
            lblFoodash.Font = new Font(pfc.Families[0], lblCreditos.Font.Size);
            lblOpciones.Font = new Font(pfc.Families[0], lblCreditos.Font.Size);
            lblSalir.Font = new Font(pfc.Families[0], lblCreditos.Font.Size);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            font();
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

        private void lblCreditos_Click(object sender, EventArgs e)
        {
            frmCreditos form = new frmCreditos();
            form.Show();
            this.Hide();
        }

        private void lblOpciones_Click(object sender, EventArgs e)
        {
            frmConfiguracion form = new frmConfiguracion();
            form.Show();
            this.Hide();
        }

        private void lblFoodash_Click(object sender, EventArgs e)
        {
            frmAmbiente form = new frmAmbiente();
            form.Show();
            this.Hide();
        }
    }
}
