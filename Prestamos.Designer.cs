namespace BancoPrestamoBasico
{
    partial class fmr_prestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_prestamos));
            this.lbl_saludo = new System.Windows.Forms.Label();
            this.btn_confirmarSolicitud = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.lbl_datosPersonales = new System.Windows.Forms.Label();
            this.lbl_detaPrestamo = new System.Windows.Forms.Label();
            this.gbx_datosPersonales = new System.Windows.Forms.GroupBox();
            this.cbx_sexo = new System.Windows.Forms.ComboBox();
            this.cbx_origen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbx_detaPrestamo = new System.Windows.Forms.GroupBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.cbx_cuotas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbx_datosPersonales.SuspendLayout();
            this.gbx_detaPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_saludo
            // 
            this.lbl_saludo.AutoSize = true;
            this.lbl_saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saludo.Location = new System.Drawing.Point(28, 37);
            this.lbl_saludo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saludo.Name = "lbl_saludo";
            this.lbl_saludo.Size = new System.Drawing.Size(228, 44);
            this.lbl_saludo.TabIndex = 0;
            this.lbl_saludo.Text = "Bienvenido, ";
            // 
            // btn_confirmarSolicitud
            // 
            this.btn_confirmarSolicitud.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_confirmarSolicitud.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_confirmarSolicitud.Location = new System.Drawing.Point(344, 465);
            this.btn_confirmarSolicitud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_confirmarSolicitud.Name = "btn_confirmarSolicitud";
            this.btn_confirmarSolicitud.Size = new System.Drawing.Size(140, 85);
            this.btn_confirmarSolicitud.TabIndex = 1;
            this.btn_confirmarSolicitud.Text = "Confirmar Solicitud";
            this.btn_confirmarSolicitud.UseVisualStyleBackColor = false;
            this.btn_confirmarSolicitud.Click += new System.EventHandler(this.btn_confirmarSolicitud_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_volver.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_volver.Location = new System.Drawing.Point(668, 527);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(128, 71);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lbl_datosPersonales
            // 
            this.lbl_datosPersonales.AutoSize = true;
            this.lbl_datosPersonales.Location = new System.Drawing.Point(36, 158);
            this.lbl_datosPersonales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_datosPersonales.Name = "lbl_datosPersonales";
            this.lbl_datosPersonales.Size = new System.Drawing.Size(186, 25);
            this.lbl_datosPersonales.TabIndex = 3;
            this.lbl_datosPersonales.Text = "Datos personales:";
            // 
            // lbl_detaPrestamo
            // 
            this.lbl_detaPrestamo.AutoSize = true;
            this.lbl_detaPrestamo.Location = new System.Drawing.Point(464, 158);
            this.lbl_detaPrestamo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_detaPrestamo.Name = "lbl_detaPrestamo";
            this.lbl_detaPrestamo.Size = new System.Drawing.Size(226, 25);
            this.lbl_detaPrestamo.TabIndex = 4;
            this.lbl_detaPrestamo.Text = "Detalles del préstamo:";
            // 
            // gbx_datosPersonales
            // 
            this.gbx_datosPersonales.BackColor = System.Drawing.Color.Moccasin;
            this.gbx_datosPersonales.Controls.Add(this.cbx_sexo);
            this.gbx_datosPersonales.Controls.Add(this.cbx_origen);
            this.gbx_datosPersonales.Controls.Add(this.label4);
            this.gbx_datosPersonales.Controls.Add(this.label3);
            this.errorProvider1.SetIconAlignment(this.gbx_datosPersonales, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.gbx_datosPersonales.Location = new System.Drawing.Point(40, 206);
            this.gbx_datosPersonales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_datosPersonales.Name = "gbx_datosPersonales";
            this.gbx_datosPersonales.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_datosPersonales.Size = new System.Drawing.Size(328, 242);
            this.gbx_datosPersonales.TabIndex = 5;
            this.gbx_datosPersonales.TabStop = false;
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Location = new System.Drawing.Point(136, 60);
            this.cbx_sexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(174, 33);
            this.cbx_sexo.TabIndex = 3;
            // 
            // cbx_origen
            // 
            this.cbx_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_origen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_origen.FormattingEnabled = true;
            this.cbx_origen.Location = new System.Drawing.Point(136, 142);
            this.cbx_origen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_origen.Name = "cbx_origen";
            this.cbx_origen.Size = new System.Drawing.Size(174, 33);
            this.cbx_origen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sexo:";
            // 
            // gbx_detaPrestamo
            // 
            this.gbx_detaPrestamo.BackColor = System.Drawing.Color.Moccasin;
            this.gbx_detaPrestamo.Controls.Add(this.txt_monto);
            this.gbx_detaPrestamo.Controls.Add(this.cbx_cuotas);
            this.gbx_detaPrestamo.Controls.Add(this.label6);
            this.gbx_detaPrestamo.Controls.Add(this.label5);
            this.gbx_detaPrestamo.Location = new System.Drawing.Point(470, 206);
            this.gbx_detaPrestamo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_detaPrestamo.Name = "gbx_detaPrestamo";
            this.gbx_detaPrestamo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbx_detaPrestamo.Size = new System.Drawing.Size(328, 242);
            this.gbx_detaPrestamo.TabIndex = 6;
            this.gbx_detaPrestamo.TabStop = false;
            // 
            // txt_monto
            // 
            this.txt_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto.Location = new System.Drawing.Point(136, 60);
            this.txt_monto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(174, 31);
            this.txt_monto.TabIndex = 3;
            // 
            // cbx_cuotas
            // 
            this.cbx_cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_cuotas.FormattingEnabled = true;
            this.cbx_cuotas.Location = new System.Drawing.Point(136, 142);
            this.cbx_cuotas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbx_cuotas.Name = "cbx_cuotas";
            this.cbx_cuotas.Size = new System.Drawing.Size(174, 33);
            this.cbx_cuotas.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cuotas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // fmr_prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(832, 610);
            this.Controls.Add(this.gbx_detaPrestamo);
            this.Controls.Add(this.gbx_datosPersonales);
            this.Controls.Add(this.lbl_detaPrestamo);
            this.Controls.Add(this.lbl_datosPersonales);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_confirmarSolicitud);
            this.Controls.Add(this.lbl_saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmr_prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.fmr_prestamos_Load);
            this.gbx_datosPersonales.ResumeLayout(false);
            this.gbx_datosPersonales.PerformLayout();
            this.gbx_detaPrestamo.ResumeLayout(false);
            this.gbx_detaPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_saludo;
        private System.Windows.Forms.Button btn_confirmarSolicitud;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lbl_datosPersonales;
        private System.Windows.Forms.Label lbl_detaPrestamo;
        private System.Windows.Forms.GroupBox gbx_datosPersonales;
        private System.Windows.Forms.ComboBox cbx_origen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbx_detaPrestamo;
        private System.Windows.Forms.ComboBox cbx_sexo;
        private System.Windows.Forms.ComboBox cbx_cuotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}