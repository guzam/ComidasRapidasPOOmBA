
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
            this.gbTarjeta = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodSeguridad = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVencimiento = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta4 = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta3 = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta2 = new System.Windows.Forms.TextBox();
            this.txtNroTarjeta1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMensajeBCRA = new System.Windows.Forms.Label();
            this.gbMedioPago = new System.Windows.Forms.GroupBox();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmarPago = new System.Windows.Forms.Button();
            this.btnVolverGP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbTarjeta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbMedioPago.SuspendLayout();
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
            this.panel1.Controls.Add(this.gbTarjeta);
            this.panel1.Controls.Add(this.gbMedioPago);
            this.panel1.Controls.Add(this.btnConfirmarPago);
            this.panel1.Controls.Add(this.btnVolverGP);
            this.panel1.Location = new System.Drawing.Point(13, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 463);
            this.panel1.TabIndex = 1;
            // 
            // gbTarjeta
            // 
            this.gbTarjeta.Controls.Add(this.label2);
            this.gbTarjeta.Controls.Add(this.txtCodSeguridad);
            this.gbTarjeta.Controls.Add(this.lblDNI);
            this.gbTarjeta.Controls.Add(this.label3);
            this.gbTarjeta.Controls.Add(this.lblNombreYApellido);
            this.gbTarjeta.Controls.Add(this.label9);
            this.gbTarjeta.Controls.Add(this.txtVencimiento);
            this.gbTarjeta.Controls.Add(this.txtNroTarjeta4);
            this.gbTarjeta.Controls.Add(this.txtNroTarjeta3);
            this.gbTarjeta.Controls.Add(this.txtNroTarjeta2);
            this.gbTarjeta.Controls.Add(this.txtNroTarjeta1);
            this.gbTarjeta.Controls.Add(this.pictureBox1);
            this.gbTarjeta.Controls.Add(this.lblMensajeBCRA);
            this.gbTarjeta.Location = new System.Drawing.Point(3, 3);
            this.gbTarjeta.Name = "gbTarjeta";
            this.gbTarjeta.Size = new System.Drawing.Size(583, 413);
            this.gbTarjeta.TabIndex = 16;
            this.gbTarjeta.TabStop = false;
            this.gbTarjeta.Text = "Pago con Tarjeta";
            this.gbTarjeta.Visible = false;
            this.gbTarjeta.Enter += new System.EventHandler(this.gbTarjeta_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cod. Seguridad";
            // 
            // txtCodSeguridad
            // 
            this.txtCodSeguridad.Location = new System.Drawing.Point(278, 334);
            this.txtCodSeguridad.MaxLength = 3;
            this.txtCodSeguridad.Name = "txtCodSeguridad";
            this.txtCodSeguridad.Size = new System.Drawing.Size(53, 23);
            this.txtCodSeguridad.TabIndex = 24;
            this.txtCodSeguridad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodSeguridad.TextChanged += new System.EventHandler(this.txtCodSeguridad_TextChanged);
            this.txtCodSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodSeguridad_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDNI.Location = new System.Drawing.Point(278, 393);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(69, 15);
            this.lblDNI.TabIndex = 23;
            this.lblDNI.Text = "11.222.333";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "DNI Titular";
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreYApellido.Location = new System.Drawing.Point(278, 367);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(110, 15);
            this.lblNombreYApellido.TabIndex = 21;
            this.lblNombreYApellido.Text = "Nombre y Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nombre y Apellido";
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Location = new System.Drawing.Point(359, 255);
            this.txtVencimiento.MaxLength = 7;
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(55, 23);
            this.txtVencimiento.TabIndex = 19;
            this.txtVencimiento.TextChanged += new System.EventHandler(this.txtVencimiento_TextChanged);
            this.txtVencimiento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVencimiento_KeyDown);
            this.txtVencimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVencimiento_KeyPress);
            this.txtVencimiento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVencimiento_KeyUp);
            // 
            // txtNroTarjeta4
            // 
            this.txtNroTarjeta4.Location = new System.Drawing.Point(306, 212);
            this.txtNroTarjeta4.MaxLength = 4;
            this.txtNroTarjeta4.Name = "txtNroTarjeta4";
            this.txtNroTarjeta4.Size = new System.Drawing.Size(53, 23);
            this.txtNroTarjeta4.TabIndex = 18;
            this.txtNroTarjeta4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroTarjeta4.TextChanged += new System.EventHandler(this.txtNroTarjeta4_TextChanged);
            this.txtNroTarjeta4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta4_KeyPress);
            this.txtNroTarjeta4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNroTarjeta4_KeyUp);
            // 
            // txtNroTarjeta3
            // 
            this.txtNroTarjeta3.Location = new System.Drawing.Point(244, 212);
            this.txtNroTarjeta3.MaxLength = 4;
            this.txtNroTarjeta3.Name = "txtNroTarjeta3";
            this.txtNroTarjeta3.Size = new System.Drawing.Size(53, 23);
            this.txtNroTarjeta3.TabIndex = 17;
            this.txtNroTarjeta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroTarjeta3.TextChanged += new System.EventHandler(this.txtNroTarjeta3_TextChanged);
            this.txtNroTarjeta3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta3_KeyPress);
            this.txtNroTarjeta3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNroTarjeta3_KeyUp);
            // 
            // txtNroTarjeta2
            // 
            this.txtNroTarjeta2.Location = new System.Drawing.Point(182, 212);
            this.txtNroTarjeta2.MaxLength = 4;
            this.txtNroTarjeta2.Name = "txtNroTarjeta2";
            this.txtNroTarjeta2.Size = new System.Drawing.Size(53, 23);
            this.txtNroTarjeta2.TabIndex = 16;
            this.txtNroTarjeta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroTarjeta2.TextChanged += new System.EventHandler(this.txtNroTarjeta2_TextChanged);
            this.txtNroTarjeta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta2_KeyPress);
            this.txtNroTarjeta2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNroTarjeta2_KeyUp);
            // 
            // txtNroTarjeta1
            // 
            this.txtNroTarjeta1.Location = new System.Drawing.Point(117, 212);
            this.txtNroTarjeta1.MaxLength = 4;
            this.txtNroTarjeta1.Name = "txtNroTarjeta1";
            this.txtNroTarjeta1.Size = new System.Drawing.Size(56, 23);
            this.txtNroTarjeta1.TabIndex = 15;
            this.txtNroTarjeta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNroTarjeta1.TextChanged += new System.EventHandler(this.txtNroTarjeta1_TextChanged);
            this.txtNroTarjeta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTarjeta1_KeyPress);
            this.txtNroTarjeta1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNroTarjeta1_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblMensajeBCRA
            // 
            this.lblMensajeBCRA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMensajeBCRA.Location = new System.Drawing.Point(10, 19);
            this.lblMensajeBCRA.Name = "lblMensajeBCRA";
            this.lblMensajeBCRA.Size = new System.Drawing.Size(562, 46);
            this.lblMensajeBCRA.TabIndex = 13;
            this.lblMensajeBCRA.Text = "Por disposición del BCRA solamente se podrá realizar el pago con una tarjeta que " +
    "esté a nombre del titular de la cuenta";
            // 
            // gbMedioPago
            // 
            this.gbMedioPago.Controls.Add(this.btnTarjeta);
            this.gbMedioPago.Controls.Add(this.btnEfectivo);
            this.gbMedioPago.Controls.Add(this.label1);
            this.gbMedioPago.Location = new System.Drawing.Point(-1, 66);
            this.gbMedioPago.Name = "gbMedioPago";
            this.gbMedioPago.Size = new System.Drawing.Size(583, 227);
            this.gbMedioPago.TabIndex = 15;
            this.gbMedioPago.TabStop = false;
            this.gbMedioPago.Text = "Medio de Pago";
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.Location = new System.Drawing.Point(218, 157);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(140, 58);
            this.btnTarjeta.TabIndex = 2;
            this.btnTarjeta.Text = "TARJETA";
            this.btnTarjeta.UseVisualStyleBackColor = true;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Location = new System.Drawing.Point(218, 76);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(140, 58);
            this.btnEfectivo.TabIndex = 1;
            this.btnEfectivo.Text = "EFECTIVO";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(166, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el medio de Pago";
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.Enabled = false;
            this.btnConfirmarPago.Location = new System.Drawing.Point(422, 417);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(131, 37);
            this.btnConfirmarPago.TabIndex = 14;
            this.btnConfirmarPago.Text = "Confirmar";
            this.btnConfirmarPago.UseVisualStyleBackColor = true;
            this.btnConfirmarPago.Click += new System.EventHandler(this.btnConfirmarPago_Click);
            // 
            // btnVolverGP
            // 
            this.btnVolverGP.Location = new System.Drawing.Point(32, 417);
            this.btnVolverGP.Name = "btnVolverGP";
            this.btnVolverGP.Size = new System.Drawing.Size(117, 37);
            this.btnVolverGP.TabIndex = 13;
            this.btnVolverGP.Text = "Cancelar";
            this.btnVolverGP.UseVisualStyleBackColor = true;
            this.btnVolverGP.Click += new System.EventHandler(this.btnVolverGP_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.lblTotalDetalle);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(621, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 463);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Location = new System.Drawing.Point(6, 46);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(266, 283);
            this.txtDescripcion.TabIndex = 22;
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.AutoSize = true;
            this.lblTotalDetalle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalDetalle.Location = new System.Drawing.Point(142, 341);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(67, 20);
            this.lblTotalDetalle.TabIndex = 21;
            this.lblTotalDetalle.Text = "0000.00";
            this.lblTotalDetalle.Click += new System.EventHandler(this.lblTotalDetalle_Click);
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
            this.gbTarjeta.ResumeLayout(false);
            this.gbTarjeta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMedioPago.ResumeLayout(false);
            this.gbMedioPago.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfirmarPago;
        private System.Windows.Forms.Button btnVolverGP;
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
        private System.Windows.Forms.GroupBox gbMedioPago;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodSeguridad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVencimiento;
        private System.Windows.Forms.TextBox txtNroTarjeta4;
        private System.Windows.Forms.TextBox txtNroTarjeta3;
        private System.Windows.Forms.TextBox txtNroTarjeta2;
        private System.Windows.Forms.TextBox txtNroTarjeta1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMensajeBCRA;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}