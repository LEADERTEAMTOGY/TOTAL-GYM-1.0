﻿namespace TotalGymWinFormApp
{
    partial class frmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbproductos = new System.Windows.Forms.GroupBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.ckno = new System.Windows.Forms.CheckBox();
            this.cksi = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblexistencia = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbproductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbproductos
            // 
            this.gbproductos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gbproductos.BackgroundImage = global::TotalGymWinFormApp.Properties.Resources.ventanaproductos3;
            this.gbproductos.Controls.Add(this.btnRegresar);
            this.gbproductos.Controls.Add(this.btnagregar);
            this.gbproductos.Controls.Add(this.ckno);
            this.gbproductos.Controls.Add(this.cksi);
            this.gbproductos.Controls.Add(this.textBox5);
            this.gbproductos.Controls.Add(this.textBox4);
            this.gbproductos.Controls.Add(this.textBox3);
            this.gbproductos.Controls.Add(this.textBox2);
            this.gbproductos.Controls.Add(this.textBox1);
            this.gbproductos.Controls.Add(this.lblexistencia);
            this.gbproductos.Controls.Add(this.lblcantidad);
            this.gbproductos.Controls.Add(this.lblprecio);
            this.gbproductos.Controls.Add(this.lbldescripcion);
            this.gbproductos.Controls.Add(this.lblnombre);
            this.gbproductos.Controls.Add(this.lblcodigo);
            this.gbproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.gbproductos.ForeColor = System.Drawing.Color.DeepPink;
            this.gbproductos.Location = new System.Drawing.Point(10, 28);
            this.gbproductos.Name = "gbproductos";
            this.gbproductos.Size = new System.Drawing.Size(532, 260);
            this.gbproductos.TabIndex = 0;
            this.gbproductos.TabStop = false;
            this.gbproductos.Text = "Productos";
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnagregar.ForeColor = System.Drawing.Color.DeepPink;
            this.btnagregar.Location = new System.Drawing.Point(363, 170);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(84, 36);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            // 
            // ckno
            // 
            this.ckno.AutoSize = true;
            this.ckno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.ckno.ForeColor = System.Drawing.Color.DeepPink;
            this.ckno.Location = new System.Drawing.Point(221, 217);
            this.ckno.Name = "ckno";
            this.ckno.Size = new System.Drawing.Size(42, 17);
            this.ckno.TabIndex = 12;
            this.ckno.Text = "No";
            this.ckno.UseVisualStyleBackColor = true;
            // 
            // cksi
            // 
            this.cksi.AutoSize = true;
            this.cksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.cksi.ForeColor = System.Drawing.Color.DeepPink;
            this.cksi.Location = new System.Drawing.Point(116, 217);
            this.cksi.Name = "cksi";
            this.cksi.Size = new System.Drawing.Size(37, 17);
            this.cksi.TabIndex = 11;
            this.cksi.Text = "Si";
            this.cksi.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(121, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(121, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(176, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(122, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 6;
            // 
            // lblexistencia
            // 
            this.lblexistencia.AutoSize = true;
            this.lblexistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblexistencia.ForeColor = System.Drawing.Color.DeepPink;
            this.lblexistencia.Location = new System.Drawing.Point(14, 217);
            this.lblexistencia.Name = "lblexistencia";
            this.lblexistencia.Size = new System.Drawing.Size(65, 13);
            this.lblexistencia.TabIndex = 5;
            this.lblexistencia.Text = "Existencia";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblcantidad.ForeColor = System.Drawing.Color.DeepPink;
            this.lblcantidad.Location = new System.Drawing.Point(14, 186);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(57, 13);
            this.lblcantidad.TabIndex = 4;
            this.lblcantidad.Text = "Cantidad";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblprecio.ForeColor = System.Drawing.Color.DeepPink;
            this.lblprecio.Location = new System.Drawing.Point(14, 155);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(43, 13);
            this.lblprecio.TabIndex = 3;
            this.lblprecio.Text = "Precio";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lbldescripcion.ForeColor = System.Drawing.Color.DeepPink;
            this.lbldescripcion.Location = new System.Drawing.Point(14, 122);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(74, 13);
            this.lbldescripcion.TabIndex = 2;
            this.lbldescripcion.Text = "Descripcion";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblnombre.ForeColor = System.Drawing.Color.DeepPink;
            this.lblnombre.Location = new System.Drawing.Point(14, 89);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(50, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.lblnombre_Click);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.lblcodigo.ForeColor = System.Drawing.Color.DeepPink;
            this.lblcodigo.Location = new System.Drawing.Point(14, 57);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(101, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo Producto";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnRegresar.ForeColor = System.Drawing.Color.DeepPink;
            this.btnRegresar.Location = new System.Drawing.Point(363, 34);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(84, 36);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(556, 310);
            this.ControlBox = false;
            this.Controls.Add(this.gbproductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.gbproductos.ResumeLayout(false);
            this.gbproductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbproductos;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.CheckBox ckno;
        private System.Windows.Forms.CheckBox cksi;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblexistencia;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnRegresar;
    }
}