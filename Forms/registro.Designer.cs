namespace ComidasRapidasPOOmBA.Forms
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(408, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(183, 30);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(263, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 28);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.Location = new System.Drawing.Point(263, 178);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(58, 28);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            this.lblEdad.Click += new System.EventHandler(this.lblEdad_Click);
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEdad.Location = new System.Drawing.Point(408, 176);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(183, 30);
            this.txtEdad.TabIndex = 3;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMail.Location = new System.Drawing.Point(263, 214);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(64, 28);
            this.lblMail.TabIndex = 5;
            this.lblMail.Text = "Email";
            this.lblMail.Click += new System.EventHandler(this.lblMail_Click);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMail.Location = new System.Drawing.Point(408, 212);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(183, 30);
            this.txtMail.TabIndex = 4;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblpass.Location = new System.Drawing.Point(263, 269);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(118, 28);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "Contraseña";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(408, 267);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(183, 30);
            this.txtPass.TabIndex = 5;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegistrarse.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarse.Location = new System.Drawing.Point(431, 359);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(133, 48);
            this.btnRegistrarse.TabIndex = 7;
            this.btnRegistrarse.Text = "Registrase";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmar.Location = new System.Drawing.Point(263, 305);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(107, 28);
            this.lblConfirmar.TabIndex = 10;
            this.lblConfirmar.Text = "Confirmar";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtConfirmar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmar.Location = new System.Drawing.Point(408, 303);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(183, 30);
            this.txtConfirmar.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(263, 89);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 28);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(408, 87);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(183, 30);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.Location = new System.Drawing.Point(137, 384);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(263, 142);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(63, 28);
            this.lblDni.TabIndex = 15;
            this.lblDni.Text = "D.N.I.";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDni.Location = new System.Drawing.Point(408, 140);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(183, 30);
            this.txtDni.TabIndex = 2;
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "registro";
            this.Text = "registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
    }
}