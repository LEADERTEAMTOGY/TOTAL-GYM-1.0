﻿using System;
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
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
            this.Hide();
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            frmEquipo equipo = new frmEquipo();
            equipo.Show();
            this.Hide();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            frmPersonal personal = new frmPersonal();
            personal.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            productos.Show();
            this.Hide();
        }
    }
}
