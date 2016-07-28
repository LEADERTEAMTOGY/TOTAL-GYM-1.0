namespace TotalGymWinFormApp
{
    partial class frmEquipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbEquipo = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bnRegresar = new System.Windows.Forms.Button();
            this.gbEquipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEquipo
            // 
            this.gbEquipo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbEquipo.BackgroundImage = global::TotalGymWinFormApp.Properties.Resources.ventanaequipo8;
            this.gbEquipo.Controls.Add(this.bnRegresar);
            this.gbEquipo.Controls.Add(this.btnSalir);
            this.gbEquipo.Controls.Add(this.btnAgregar);
            this.gbEquipo.Controls.Add(this.lbCantidad);
            this.gbEquipo.Controls.Add(this.lbDescripcion);
            this.gbEquipo.Controls.Add(this.txtCantidad);
            this.gbEquipo.Controls.Add(this.txtNombre);
            this.gbEquipo.Controls.Add(this.lbNombre);
            this.gbEquipo.Controls.Add(this.txtCod);
            this.gbEquipo.Controls.Add(this.lbCode);
            this.gbEquipo.Location = new System.Drawing.Point(4, 12);
            this.gbEquipo.Name = "gbEquipo";
            this.gbEquipo.Size = new System.Drawing.Size(351, 237);
            this.gbEquipo.TabIndex = 0;
            this.gbEquipo.TabStop = false;
            this.gbEquipo.Text = "Equipo";
            this.gbEquipo.Enter += new System.EventHandler(this.gbEquipo_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Crimson;
            this.btnSalir.Location = new System.Drawing.Point(257, 139);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Crimson;
            this.btnAgregar.Location = new System.Drawing.Point(257, 33);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(6, 129);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 13);
            this.lbCantidad.TabIndex = 8;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(6, 116);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(0, 13);
            this.lbDescripcion.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(97, 129);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(6, 33);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(97, 80);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(75, 20);
            this.txtCod.TabIndex = 1;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(6, 83);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(75, 13);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Codigo equipo";
            // 
            // dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Location = new System.Drawing.Point(361, 12);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv.Size = new System.Drawing.Size(365, 237);
            this.dgv.TabIndex = 1;
            // 
            // bnRegresar
            // 
            this.bnRegresar.ForeColor = System.Drawing.Color.Crimson;
            this.bnRegresar.Location = new System.Drawing.Point(257, 83);
            this.bnRegresar.Name = "bnRegresar";
            this.bnRegresar.Size = new System.Drawing.Size(75, 23);
            this.bnRegresar.TabIndex = 11;
            this.bnRegresar.Text = "Regresar";
            this.bnRegresar.UseVisualStyleBackColor = true;
            this.bnRegresar.Click += new System.EventHandler(this.bnRegresar_Click);
            // 
            // frmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(729, 253);
            this.ControlBox = false;
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.gbEquipo);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.frmEquipo_Load);
            this.gbEquipo.ResumeLayout(false);
            this.gbEquipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEquipo;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button bnRegresar;
    }
}