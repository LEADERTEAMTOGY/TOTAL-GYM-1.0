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
            string sql = "insert into EXAMEN (NOMBRE,APELLIDO,TELEFONO,DNI,SEXO,FECHA_NACIMIENTO,EDAD,CALLE,MUNICIPIO_DELEGACION,ESTADO,TELCASA,TELTRABAJO,FAX,COLONIA,PAIS,CODIGO_POSTAL,EMAIL) values ('" + this.txtbnombreinsertar.Text + "','" + this.txtbapellidoinsertar.Text + "','" + this.txtbtelefonoinsertar.Text + "','" + this.txtbdninsertar.Text + "','" + this.txtbsexoinsertar.Text + "','" + this.txtbfechanacimientoinsertar.Text + "','" + this.txtbedadinsertar.Text + "','" + this.txtbcalleinsertar.Text + "','" + this.txtbmunicipiodelegacioninsertar.Text  + "','" + this.txtbestadoinsertar.Text + "','" + this.txtbtelcasainsertar.Text + "','" + this.txtbteltrabajoinsertar.Text + "','" + this.txtbfaxinsertar.Text + "','" + this.txtbcoloniainsertar.Text + "','" + this.txtbpaisinsertar.Text + "','" + this.txtbcodigopostalinsertar.Text + "','" + this.txtbemailinsertar.Text + "')"; 
            if (obDAtos.insertar(sql)) { MessageBox.Show("Registro Insertado Compa"); } else { MessageBox.Show("Error al insertar"); }
            Application.Restart();
        }

   
        private void lsteliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbnombreactualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbapellidoactualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbnombreinsertar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbmunicipiodelegacioninsertar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
