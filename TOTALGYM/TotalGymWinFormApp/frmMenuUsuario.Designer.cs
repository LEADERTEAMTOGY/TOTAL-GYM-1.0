namespace TotalGymWinFormApp
{
    partial class frmMenuPrincipal
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
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.lblNombreAdmin = new System.Windows.Forms.Label();
            this.lblEtiquetaUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnProducto.ForeColor = System.Drawing.Color.Cyan;
            this.btnProducto.Location = new System.Drawing.Point(191, 109);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(117, 28);
            this.btnProducto.TabIndex = 10;
            this.btnProducto.Text = "Producto ";
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnEquipo
            // 
            this.btnEquipo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnEquipo.ForeColor = System.Drawing.Color.Cyan;
            this.btnEquipo.Location = new System.Drawing.Point(54, 109);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(117, 28);
            this.btnEquipo.TabIndex = 9;
            this.btnEquipo.Text = "Equipo";
            this.btnEquipo.UseVisualStyleBackColor = false;
            this.btnEquipo.Click += new System.EventHandler(this.btnEquipo_Click);
            // 
            // lblNombreAdmin
            // 
            this.lblNombreAdmin.AutoSize = true;
            this.lblNombreAdmin.Location = new System.Drawing.Point(188, 15);
            this.lblNombreAdmin.Name = "lblNombreAdmin";
            this.lblNombreAdmin.Size = new System.Drawing.Size(0, 13);
            this.lblNombreAdmin.TabIndex = 8;
            // 
            // lblEtiquetaUsuario
            // 
            this.lblEtiquetaUsuario.AutoSize = true;
            this.lblEtiquetaUsuario.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblEtiquetaUsuario.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaUsuario.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblEtiquetaUsuario.Location = new System.Drawing.Point(177, 75);
            this.lblEtiquetaUsuario.Name = "lblEtiquetaUsuario";
            this.lblEtiquetaUsuario.Size = new System.Drawing.Size(48, 20);
            this.lblEtiquetaUsuario.TabIndex = 7;
            this.lblEtiquetaUsuario.Text = "Usuario: ";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnSalir.ForeColor = System.Drawing.Color.Cyan;
            this.btnSalir.Location = new System.Drawing.Point(54, 171);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 28);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TotalGymWinFormApp.Properties.Resources.ventanalogin22;
            this.ClientSize = new System.Drawing.Size(386, 226);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnEquipo);
            this.Controls.Add(this.lblNombreAdmin);
            this.Controls.Add(this.lblEtiquetaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Usuario";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Label lblNombreAdmin;
        private System.Windows.Forms.Label lblEtiquetaUsuario;
        private System.Windows.Forms.Button btnSalir;
    }
}