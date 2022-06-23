
namespace ComidasRapidasPOOmBA.Forms
{
    partial class GestionPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPago));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsuarioGP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmarPago = new System.Windows.Forms.Button();
            this.btnVolverGP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodSeguridad = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVencimiento = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta4 = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta3 = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta2 = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMensajeBCRA = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSubTotalPostre = new System.Windows.Forms.Label();
            this.lblDescripcionPostre = new System.Windows.Forms.Label();
            this.lblSubTotalBebida = new System.Windows.Forms.Label();
            this.lblDescripcionBebida = new System.Windows.Forms.Label();
            this.lblSubTotalComida = new System.Windows.Forms.Label();
            this.lblDescripcionComida = new System.Windows.Forms.Label();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsuarioGP);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(890, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GESTION DE PAGO";
            // 
            // lblUsuarioGP
            // 
            this.lblUsuarioGP.AutoSize = true;
            this.lblUsuarioGP.Location = new System.Drawing.Point(33, 19);
            this.lblUsuarioGP.Name = "lblUsuarioGP";
            this.lblUsuarioGP.Size = new System.Drawing.Size(56, 15);
            this.lblUsuarioGP.TabIndex = 15;
            this.lblUsuarioGP.Text = "USUARIO";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConfirmarPago);
            this.panel1.Controls.Add(this.btnVolverGP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCodSeguridad);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNombreYApellido);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtVencimiento);
            this.panel1.Controls.Add(this.txtNroTarjeta4);
            this.panel1.Controls.Add(this.txtNroTarjeta3);
            this.panel1.Controls.Add(this.txtNroTarjeta2);
            this.panel1.Controls.Add(this.txtNroTarjeta1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblMensajeBCRA);
            this.panel1.Location = new System.Drawing.Point(13, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 463);
            this.panel1.TabIndex = 1;
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.Enabled = false;
            this.btnConfirmarPago.Location = new System.Drawing.Point(422, 414);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(131, 37);
            this.btnConfirmarPago.TabIndex = 14;
            this.btnConfirmarPago.Text = "Confirmar";
            this.btnConfirmarPago.UseVisualStyleBackColor = true;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);
            // 
            // btnVolverGP
            // 
            this.btnVolverGP.Location = new System.Drawing.Point(32, 414);
            this.btnVolverGP.Name = "btnVolverGP";
            this.btnVolverGP.Size = new System.Drawing.Size(117, 37);
            this.btnVolverGP.TabIndex = 13;
            this.btnVolverGP.Text = "Volver";
            this.btnVolverGP.UseVisualStyleBackColor = true;
            this.btnVolverGP.Click += new System.EventHandler(this.btnVolverGP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cod. Seguridad";
            // 
            // txtCodSeguridad
            // 
            this.txtCodSeguridad.Location = new System.Drawing.Point(284, 325);
            this.txtCodSeguridad.MaxLength = 3;
            this.txtCodSeguridad.Name = "txtCodSeguridad";
            this.txtCodSeguridad.Size = new System.Drawing.Size(53, 23);
            this.txtCodSeguridad.TabIndex = 11;
            this.txtCodSeguridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodSeguridad.TextChanged += new System.EventHandler(this.txtCodSeguridad_TextChanged);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDNI.Location = new System.Drawing.Point(284, 384);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(69, 15);
            this.lblDNI.TabIndex = 10;
            this.lblDNI.Text = "11.222.333";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI Titular";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreYApellido.Location = new System.Drawing.Point(284, 358);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(110, 15);
            this.lblNombreYApellido.TabIndex = 8;
            this.lblNombreYApellido.Text = "Nombre y Apellido";
            this.lblNombreYApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre y Apellido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Location = new System.Drawing.Point(365, 246);
            this.txtVencimiento.MaxLength = 7;
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(55, 23);
            this.txtVencimiento.TabIndex = 6;
            this.txtVencimiento.TextChanged += new System.EventHandler(this.txtVencimiento_TextChanged);
            this.txtVencimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVencimiento_KeyDown);
            // 
            // txtNroTarjeta4
            // 
            this.txtNroTarjeta4.Location = new System.Drawing.Point(312, 203);
            this.txtNroTarjeta4.MaxLength = 4;
            this.txtNroTarjeta4.Name = "txtNroTarjeta4";
            this.txtNroTarjeta4.Size = new System.Drawing.Size(53, 23);
            this.txtNroTarjeta4.TabIndex = 5;
            this.txtNroTarjeta4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroTarjeta4.TextChanged += new System.EventHandler(this.txtNroTarjeta4_TextChanged);
            this.txtNroTarjeta4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta4_KeyPress);
            // 
            // txtNroTarjeta3
            // 
            this.txtNroTarjeta3.Location = new System.Drawing.Point(250, 203);
            this.txtNroTarjeta3.MaxLength = 4;
            this.txtNroTarjeta3.Name = "txtNroTarjeta3";
            this.txtNroTarjeta3.Size = new System.Drawing.Size(53, 23);
            this.txtNroTarjeta3.TabIndex = 4;
            this.txtNroTarjeta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroTarjeta3.TextChanged += new System.EventHandler(this.txtNroTarjeta3_TextChanged);
            this.txtNroTarjeta3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta3_KeyPress);
            // 
            // txtNroTarjeta2
            // 
            this.txtNroTarjeta2.Location = new System.Drawing.Point(188, 203);
            this.txtNroTarjeta2.MaxLength = 4;
            this.txtNroTarjeta2.Name = "txtNroTarjeta2";
            this.txtNroTarjeta2.Size = new System.Drawing.Size(53, 23);
            this.txtNroTarjeta2.TabIndex = 3;
            this.txtNroTarjeta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroTarjeta2.TextChanged += new System.EventHandler(this.txtNroTarjeta2_TextChanged);
            this.txtNroTarjeta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta2_KeyPress);
            // 
            // txtNroTarjeta1
            // 
            this.txtNroTarjeta1.Location = new System.Drawing.Point(123, 203);
            this.txtNroTarjeta1.MaxLength = 4;
            this.txtNroTarjeta1.Name = "txtNroTarjeta1";
            this.txtNroTarjeta1.Size = new System.Drawing.Size(56, 23);
            this.txtNroTarjeta1.TabIndex = 2;
            this.txtNroTarjeta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroTarjeta1.TextChanged += new System.EventHandler(this.txtNroTarjeta1_TextChanged);
            this.txtNroTarjeta1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNroTarjeta1_KeyDown);
            this.txtNroTarjeta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(94, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblMensajeBCRA
            // 
            this.lblMensajeBCRA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeBCRA.Location = new System.Drawing.Point(16, 10);
            this.lblMensajeBCRA.Name = "lblMensajeBCRA";
            this.lblMensajeBCRA.Size = new System.Drawing.Size(562, 46);
            this.lblMensajeBCRA.TabIndex = 0;
            this.lblMensajeBCRA.Text = "Por disposición del BCRA solamente se podrá realizar el pago con una tarjeta que " +
    "esté a nombre del titular de la cuenta";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSubTotalPostre);
            this.panel2.Controls.Add(this.lblDescripcionPostre);
            this.panel2.Controls.Add(this.lblSubTotalBebida);
            this.panel2.Controls.Add(this.lblDescripcionBebida);
            this.panel2.Controls.Add(this.lblSubTotalComida);
            this.panel2.Controls.Add(this.lblDescripcionComida);
            this.panel2.Controls.Add(this.lblTotalDetalle);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(621, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 463);
            this.panel2.TabIndex = 2;
            // 
            // lblSubTotalPostre
            // 
            this.lblSubTotalPostre.AutoSize = true;
            this.lblSubTotalPostre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotalPostre.Location = new System.Drawing.Point(142, 274);
            this.lblSubTotalPostre.Name = "lblSubTotalPostre";
            this.lblSubTotalPostre.Size = new System.Drawing.Size(14, 15);
            this.lblSubTotalPostre.TabIndex = 25;
            this.lblSubTotalPostre.Text = "$";
            // 
            // lblDescripcionPostre
            // 
            this.lblDescripcionPostre.AutoSize = true;
            this.lblDescripcionPostre.Location = new System.Drawing.Point(29, 274);
            this.lblDescripcionPostre.Name = "lblDescripcionPostre";
            this.lblDescripcionPostre.Size = new System.Drawing.Size(104, 15);
            this.lblDescripcionPostre.TabIndex = 24;
            this.lblDescripcionPostre.Text = "descripción postre";
            // 
            // lblSubTotalBebida
            // 
            this.lblSubTotalBebida.AutoSize = true;
            this.lblSubTotalBebida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotalBebida.Location = new System.Drawing.Point(142, 183);
            this.lblSubTotalBebida.Name = "lblSubTotalBebida";
            this.lblSubTotalBebida.Size = new System.Drawing.Size(14, 15);
            this.lblSubTotalBebida.TabIndex = 23;
            this.lblSubTotalBebida.Text = "$";
            // 
            // lblDescripcionBebida
            // 
            this.lblDescripcionBebida.AutoSize = true;
            this.lblDescripcionBebida.Location = new System.Drawing.Point(29, 183);
            this.lblDescripcionBebida.Name = "lblDescripcionBebida";
            this.lblDescripcionBebida.Size = new System.Drawing.Size(107, 15);
            this.lblDescripcionBebida.TabIndex = 22;
            this.lblDescripcionBebida.Text = "descripción bebida";
            // 
            // lblSubTotalComida
            // 
            this.lblSubTotalComida.AutoSize = true;
            this.lblSubTotalComida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotalComida.Location = new System.Drawing.Point(142, 90);
            this.lblSubTotalComida.Name = "lblSubTotalComida";
            this.lblSubTotalComida.Size = new System.Drawing.Size(14, 15);
            this.lblSubTotalComida.TabIndex = 16;
            this.lblSubTotalComida.Text = "$";
            // 
            // lblDescripcionComida
            // 
            this.lblDescripcionComida.AutoSize = true;
            this.lblDescripcionComida.Location = new System.Drawing.Point(29, 90);
            this.lblDescripcionComida.Name = "lblDescripcionComida";
            this.lblDescripcionComida.Size = new System.Drawing.Size(111, 15);
            this.lblDescripcionComida.TabIndex = 15;
            this.lblDescripcionComida.Text = "descripción comida";
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.AutoSize = true;
            this.lblTotalDetalle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDetalle.Location = new System.Drawing.Point(142, 341);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(76, 20);
            this.lblTotalDetalle.TabIndex = 21;
            this.lblTotalDetalle.Text = "$0000,00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(72, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "POSTRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "BEBIDA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "COMIDA";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(98, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "DETALLE";
            // 
            // GestionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionPago";
            this.Text = "GestionPago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVencimiento;
        private System.Windows.Forms.TextBox txtNroTarjeta4;
        private System.Windows.Forms.TextBox txtNroTarjeta3;
        private System.Windows.Forms.TextBox txtNroTarjeta2;
        private System.Windows.Forms.TextBox txtNroTarjeta1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMensajeBCRA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarPago;
        private System.Windows.Forms.Button btnVolverGP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodSeguridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalDetalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSubTotalPostre;
        private System.Windows.Forms.Label lblDescripcionPostre;
        private System.Windows.Forms.Label lblSubTotalBebida;
        private System.Windows.Forms.Label lblDescripcionBebida;
        private System.Windows.Forms.Label lblSubTotalComida;
        private System.Windows.Forms.Label lblDescripcionComida;
        private System.Windows.Forms.Label lblUsuarioGP;
    }
}