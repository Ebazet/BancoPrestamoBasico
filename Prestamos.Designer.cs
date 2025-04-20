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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_prestamos));
            this.lbl_saludo = new System.Windows.Forms.Label();
            this.btn_confirmarSolicitud = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_origen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_sexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_cuotas = new System.Windows.Forms.ComboBox();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_saludo
            // 
            this.lbl_saludo.AutoSize = true;
            this.lbl_saludo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saludo.Location = new System.Drawing.Point(27, 37);
            this.lbl_saludo.Name = "lbl_saludo";
            this.lbl_saludo.Size = new System.Drawing.Size(228, 44);
            this.lbl_saludo.TabIndex = 0;
            this.lbl_saludo.Text = "Bienvenido, ";
            // 
            // btn_confirmarSolicitud
            // 
            this.btn_confirmarSolicitud.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_confirmarSolicitud.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_confirmarSolicitud.Location = new System.Drawing.Point(345, 466);
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
            this.btn_volver.Location = new System.Drawing.Point(669, 526);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(129, 72);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos personales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalles del préstamo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox1.Controls.Add(this.cbx_sexo);
            this.groupBox1.Controls.Add(this.cbx_origen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(40, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 242);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cbx_origen
            // 
            this.cbx_origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_origen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_origen.FormattingEnabled = true;
            this.cbx_origen.Location = new System.Drawing.Point(136, 143);
            this.cbx_origen.Name = "cbx_origen";
            this.cbx_origen.Size = new System.Drawing.Size(174, 33);
            this.cbx_origen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sexo:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Moccasin;
            this.groupBox2.Controls.Add(this.txt_monto);
            this.groupBox2.Controls.Add(this.cbx_cuotas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(470, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 242);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.Location = new System.Drawing.Point(136, 59);
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(174, 33);
            this.cbx_sexo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cuotas:";
            // 
            // cbx_cuotas
            // 
            this.cbx_cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_cuotas.FormattingEnabled = true;
            this.cbx_cuotas.Location = new System.Drawing.Point(135, 143);
            this.cbx_cuotas.Name = "cbx_cuotas";
            this.cbx_cuotas.Size = new System.Drawing.Size(174, 33);
            this.cbx_cuotas.TabIndex = 2;
            // 
            // txt_monto
            // 
            this.txt_monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_monto.Location = new System.Drawing.Point(135, 59);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(174, 31);
            this.txt_monto.TabIndex = 3;
            // 
            // fmr_prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(832, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_confirmarSolicitud);
            this.Controls.Add(this.lbl_saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmr_prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.fmr_prestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_saludo;
        private System.Windows.Forms.Button btn_confirmarSolicitud;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_origen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbx_sexo;
        private System.Windows.Forms.ComboBox cbx_cuotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_monto;
    }
}