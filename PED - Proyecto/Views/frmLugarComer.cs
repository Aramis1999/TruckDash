﻿using System;
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

        frmAmbiente frm = new frmAmbiente();
        private void pNo_MouseClick(object sender, MouseEventArgs e)
        {

            frm.asignar(0);
            this.Hide();

        }

        private void pSi_MouseClick(object sender, MouseEventArgs e)
        {
            frm.asignar(1);
            this.Hide();
        }
    }
}