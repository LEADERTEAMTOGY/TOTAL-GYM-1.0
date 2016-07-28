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
    public partial class frmEquipo : Form
    {
        CONEXION c = new CONEXION();
        public frmEquipo()
        {
            InitializeComponent();
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {
            CONEXION c = new CONEXION();
            c.cargarPersonas(dgv);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbEquipo_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (c.personaRegistrada(Convert.ToInt32(txtCod.Text)) == 0)
            {

                string nombre = txtNombre.Text;


                int codigo = Convert.ToInt32(txtCod.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);

                MessageBox.Show(c.insertar(codigo, cantidad, nombre));
                c.cargarPersonas(dgv);
                txtCod.Text = "";
                txtNombre.Text = "";
                txtCantidad.Text = "";

            }
            else
            {
                MessageBox.Show("Imposible de regitrar, El registro ya existe");
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {


        }

        private void bnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuAdmin a = new frmMenuAdmin();
            a.Show();

            this.Close();

        }
    }
}