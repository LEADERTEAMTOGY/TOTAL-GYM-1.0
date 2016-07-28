using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalGymWinFormApp
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            CONEXION c = new CONEXION();
            c.cargarPersonas(dgv);

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
