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
    public partial class frmAlerta : Form
    {
        public frmAlerta(string dato)
        {
            InitializeComponent();
            label1.Text = dato;
        }

        public string SelectedText { get; set; }

        private void frmAlerta_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            SelectedText = textBox1.Text;
        }
    }
}
