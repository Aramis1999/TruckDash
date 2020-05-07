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
    public partial class frmVentas : Form
    {
        
        public frmVentas(List<Comida> comi)
        {
            InitializeComponent();
            dgvVentas.DataSource = comi;
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
