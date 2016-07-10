using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTJVRF301510920
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        datos2 obDAtos = new datos2();
        private void btninsertar_Click(object sender, EventArgs e)
        {
            string sql = "insert into EXAMEN (NOMBRE,APELLIDO,TELEFONO,DNI) values ('" + this.txtbnombreinsertar.Text + "','" + this.txtbapellidoinsertar.Text + "','" + this.txtbtelefonoinsertar.Text + "','" + this.txtbdninsertar.Text + "')"; 
            if (obDAtos.insertar(sql)) { MessageBox.Show("Registro Insertado"); } else { MessageBox.Show("Error al insertar"); }
            Application.Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obDAtos.consultar("select * from EXAMEN", "EXAMEN");
            this.dataGridView1.DataSource = obDAtos.ds.Tables["EXAMEN"];
            this.dataGridView1.Refresh();

            this.lsteliminar.DataSource = obDAtos.consultar2("EXAMEN");
            this.lsteliminar.DisplayMember = "NOMBRE";
            this.lsteliminar.ValueMember = "APELLIDO";
            this.lsteliminar.ValueMember = "DNI";
            this.lsteliminar.ValueMember = "Id";
            this.lsteliminar.Refresh();


            this.cmbdatosactuales.DataSource = obDAtos.consultar2("EXAMEN");
            this.cmbdatosactuales.DisplayMember = "Nombre";
            this.cmbdatosactuales.ValueMember = "Id";
            this.cmbdatosactuales.ValueMember = "DNI";
            this.cmbdatosactuales.ValueMember = "APELLIDO";
            this.cmbdatosactuales.Refresh();
            }

        private void btnborrardatos_Click(object sender, EventArgs e)
        {
            if (obDAtos.eliminar("EXAMEN","Id='"+ this.lsteliminar.SelectedValue.ToString()+ "'")){ MessageBox.Show("Registro Eliminado");  } else { MessageBox.Show("Error al eliminar"); }
            Application.Restart();
        }

        private void btnactulizartabla_Click(object sender, EventArgs e)
        {
           
             string campos = "NOMBRE ='" + this.txtbapellidoactualizar.Text + "', Apellido= '" + this.txtbapellidoactualizar.Text + "'";
            if (obDAtos.actualizar("EXAMEN", campos, "Id='" + this.cmbdatosactuales.SelectedValue.ToString() + "'")){ MessageBox.Show("Registro actualizado"); }else { MessageBox.Show("Error al intenta actualizar"); }
            Application.Restart();

              
        }

        private void lsteliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
