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
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnEquipo = new System.Windows.Forms.Button();
            this.lblNombreAdmin = new System.Windows.Forms.Label();
            this.lblEtiquetaUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblInformacion.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacion.ForeColor = System.Drawing.Color.Cyan;
            this.lblInformacion.Location = new System.Drawing.Point(5, 151);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(102, 20);
            this.lblInformacion.TabIndex = 13;
            this.lblInformacion.Text = "Acerca Total Gym 1.0";
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProducto.Font = new System.Drawing.Font("Code Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnProducto.ForeColor = System.Drawing.Color.Cyan;
            this.btnProducto.Location = new System.Drawing.Point(140, 143);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(117, 28);
            this.btnProducto.TabIndex = 10;
            this.btnProducto.Text = "Producto ";
            this.btnProducto.UseVisualStyleBackColor = false;
            // 
            // btnEquipo
            // 
            this.btnEquipo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEquipo.Font = new System.Drawing.Font("Code Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(77)));
            this.btnEquipo.ForeColor = System.Drawing.Color.Cyan;
            this.btnEquipo.Location = new System.Drawing.Point(140, 109);
            this.btnEquipo.Name = "btnEquipo";
            this.btnEquipo.Size = new System.Drawing.Size(117, 28);
            this.btnEquipo.TabIndex = 9;
            this.btnEquipo.Text = "Equipo";
            this.btnEquipo.UseVisualStyleBackColor = false;
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
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TotalGymWinFormApp.Properties.Resources.ventanalogin22;
            this.ClientSize = new System.Drawing.Size(379, 174);
            this.ControlBox = false;
            this.Controls.Add(this.lblInformacion);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnEquipo;
        private System.Windows.Forms.Label lblNombreAdmin;
        private System.Windows.Forms.Label lblEtiquetaUsuario;
    }
}