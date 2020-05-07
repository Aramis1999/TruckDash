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
    public partial class frmLugarComer : Form
    {

        

        public frmLugarComer()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }


        private void pNo_MouseLeave(object sender, EventArgs e)
        {
            pNo.ForeColor = Color.Black;
            pNo.BorderStyle = BorderStyle.None;
        }

        private void pNo_MouseEnter(object sender, EventArgs e)
        {
            pNo.ForeColor = Color.FromArgb(0, 0, 0);
            pNo.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pSi_MouseLeave(object sender, EventArgs e)
        {
            pSi.ForeColor = Color.Black;
            pSi.BorderStyle = BorderStyle.None;
        }

        private void pSi_MouseEnter(object sender, EventArgs e)
        {
            pSi.ForeColor = Color.FromArgb(0, 0, 0);
            pSi.BorderStyle = BorderStyle.Fixed3D;
        }

       
        private void pNo_MouseClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.No;
            
        }

        private void pSi_MouseClick(object sender, MouseEventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void pSi_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
