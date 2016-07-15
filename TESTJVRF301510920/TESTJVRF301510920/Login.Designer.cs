namespace TESTJVRF301510920
{
    partial class Login
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
            this.txtbcurp = new System.Windows.Forms.TextBox();
            this.lblcontraseña = new System.Windows.Forms.Label();
            this.txtbcontraseña = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.grpblogin = new System.Windows.Forms.GroupBox();
            this.lblcurp = new System.Windows.Forms.Label();
            this.chkbmostrarcontraseña = new System.Windows.Forms.CheckBox();
            this.grpblogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbcurp
            // 
            this.txtbcurp.Location = new System.Drawing.Point(123, 19);
            this.txtbcurp.Name = "txtbcurp";
            this.txtbcurp.Size = new System.Drawing.Size(189, 20);
            this.txtbcurp.TabIndex = 0;
            // 
            // lblcontraseña
            // 
            this.lblcontraseña.AutoSize = true;
            this.lblcontraseña.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblcontraseña.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontraseña.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcontraseña.Location = new System.Drawing.Point(29, 63);
            this.lblcontraseña.Name = "lblcontraseña";
            this.lblcontraseña.Size = new System.Drawing.Size(57, 15);
            this.lblcontraseña.TabIndex = 1;
            this.lblcontraseña.Text = "Contraseña:";
            // 
            // txtbcontraseña
            // 
            this.txtbcontraseña.Location = new System.Drawing.Point(123, 58);
            this.txtbcontraseña.Name = "txtbcontraseña";
            this.txtbcontraseña.Size = new System.Drawing.Size(189, 20);
            this.txtbcontraseña.TabIndex = 2;
            this.txtbcontraseña.UseSystemPasswordChar = true;
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnentrar.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnentrar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnentrar.Location = new System.Drawing.Point(140, 148);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(104, 42);
            this.btnentrar.TabIndex = 3;
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // grpblogin
            // 
            this.grpblogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.grpblogin.Controls.Add(this.chkbmostrarcontraseña);
            this.grpblogin.Controls.Add(this.lblcurp);
            this.grpblogin.Controls.Add(this.txtbcurp);
            this.grpblogin.Controls.Add(this.txtbcontraseña);
            this.grpblogin.Controls.Add(this.lblcontraseña);
            this.grpblogin.ForeColor = System.Drawing.Color.Cornsilk;
            this.grpblogin.Location = new System.Drawing.Point(35, 10);
            this.grpblogin.Name = "grpblogin";
            this.grpblogin.Size = new System.Drawing.Size(318, 130);
            this.grpblogin.TabIndex = 4;
            this.grpblogin.TabStop = false;
            this.grpblogin.Text = "Login";
            // 
            // lblcurp
            // 
            this.lblcurp.AutoSize = true;
            this.lblcurp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblcurp.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcurp.Location = new System.Drawing.Point(29, 24);
            this.lblcurp.Name = "lblcurp";
            this.lblcurp.Size = new System.Drawing.Size(34, 15);
            this.lblcurp.TabIndex = 3;
            this.lblcurp.Text = "CURP";
            // 
            // chkbmostrarcontraseña
            // 
            this.chkbmostrarcontraseña.AutoSize = true;
            this.chkbmostrarcontraseña.Location = new System.Drawing.Point(195, 92);
            this.chkbmostrarcontraseña.Name = "chkbmostrarcontraseña";
            this.chkbmostrarcontraseña.Size = new System.Drawing.Size(117, 17);
            this.chkbmostrarcontraseña.TabIndex = 4;
            this.chkbmostrarcontraseña.Text = "Mostrar contraseña";
            this.chkbmostrarcontraseña.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TESTJVRF301510920.Properties.Resources.curpnapp;
            this.ClientSize = new System.Drawing.Size(384, 202);
            this.Controls.Add(this.grpblogin);
            this.Controls.Add(this.btnentrar);
            this.Name = "Login";
            this.Text = "Login";
            this.grpblogin.ResumeLayout(false);
            this.grpblogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtbcurp;
        private System.Windows.Forms.Label lblcontraseña;
        private System.Windows.Forms.TextBox txtbcontraseña;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.GroupBox grpblogin;
        private System.Windows.Forms.CheckBox chkbmostrarcontraseña;
        private System.Windows.Forms.Label lblcurp;
    }
}