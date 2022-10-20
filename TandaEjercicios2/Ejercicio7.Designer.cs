namespace TandaEjercicios2
{
    partial class Ejercicio7
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAhora = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtHoy = new System.Windows.Forms.TextBox();
            this.txtHoraHoy = new System.Windows.Forms.TextBox();
            this.txtSumaFechas = new System.Windows.Forms.TextBox();
            this.txtDifFechas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ahora";
            // 
            // txtAhora
            // 
            this.txtAhora.Enabled = false;
            this.txtAhora.Location = new System.Drawing.Point(132, 25);
            this.txtAhora.Name = "txtAhora";
            this.txtAhora.Size = new System.Drawing.Size(483, 23);
            this.txtAhora.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(349, 215);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 2;
            this.btnEjecutar.Text = "Ejecucion";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtHoy
            // 
            this.txtHoy.Enabled = false;
            this.txtHoy.Location = new System.Drawing.Point(132, 64);
            this.txtHoy.Name = "txtHoy";
            this.txtHoy.Size = new System.Drawing.Size(483, 23);
            this.txtHoy.TabIndex = 3;
            // 
            // txtHoraHoy
            // 
            this.txtHoraHoy.Enabled = false;
            this.txtHoraHoy.Location = new System.Drawing.Point(132, 103);
            this.txtHoraHoy.Name = "txtHoraHoy";
            this.txtHoraHoy.Size = new System.Drawing.Size(483, 23);
            this.txtHoraHoy.TabIndex = 4;
            // 
            // txtSumaFechas
            // 
            this.txtSumaFechas.Enabled = false;
            this.txtSumaFechas.Location = new System.Drawing.Point(132, 138);
            this.txtSumaFechas.Name = "txtSumaFechas";
            this.txtSumaFechas.Size = new System.Drawing.Size(483, 23);
            this.txtSumaFechas.TabIndex = 5;
            // 
            // txtDifFechas
            // 
            this.txtDifFechas.Enabled = false;
            this.txtDifFechas.Location = new System.Drawing.Point(132, 175);
            this.txtDifFechas.Name = "txtDifFechas";
            this.txtDifFechas.Size = new System.Drawing.Size(483, 23);
            this.txtDifFechas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hoy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora de Hoy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Suma de Fechas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Diferencia de Fechas";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(444, 215);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(540, 215);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Ejercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 259);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDifFechas);
            this.Controls.Add(this.txtSumaFechas);
            this.Controls.Add(this.txtHoraHoy);
            this.Controls.Add(this.txtHoy);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtAhora);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio8";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ejercicio8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAhora;
        private Button btnEjecutar;
        private TextBox txtHoy;
        private TextBox txtHoraHoy;
        private TextBox txtSumaFechas;
        private TextBox txtDifFechas;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}