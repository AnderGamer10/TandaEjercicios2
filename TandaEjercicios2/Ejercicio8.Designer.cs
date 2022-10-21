namespace TandaEjercicios2
{
    partial class Ejercicio8
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
            this.lboxAmigos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBorrarLista = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtAmigoSelec = new System.Windows.Forms.TextBox();
            this.txtAnyadirAmigos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lboxAmigos
            // 
            this.lboxAmigos.FormattingEnabled = true;
            this.lboxAmigos.ItemHeight = 15;
            this.lboxAmigos.Location = new System.Drawing.Point(54, 92);
            this.lboxAmigos.Name = "lboxAmigos";
            this.lboxAmigos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lboxAmigos.Size = new System.Drawing.Size(120, 154);
            this.lboxAmigos.TabIndex = 0;
            this.lboxAmigos.SelectedIndexChanged += new System.EventHandler(this.lboxAmigos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mis amigos";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(262, 69);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(85, 35);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(262, 128);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBorrarLista
            // 
            this.btnBorrarLista.Location = new System.Drawing.Point(262, 186);
            this.btnBorrarLista.Name = "btnBorrarLista";
            this.btnBorrarLista.Size = new System.Drawing.Size(85, 35);
            this.btnBorrarLista.TabIndex = 4;
            this.btnBorrarLista.Text = "Borrar Lista";
            this.btnBorrarLista.UseVisualStyleBackColor = true;
            this.btnBorrarLista.Click += new System.EventHandler(this.btnBorrarLista_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(262, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtAmigoSelec
            // 
            this.txtAmigoSelec.Enabled = false;
            this.txtAmigoSelec.Location = new System.Drawing.Point(54, 316);
            this.txtAmigoSelec.Name = "txtAmigoSelec";
            this.txtAmigoSelec.Size = new System.Drawing.Size(120, 23);
            this.txtAmigoSelec.TabIndex = 6;
            // 
            // txtAnyadirAmigos
            // 
            this.txtAnyadirAmigos.Location = new System.Drawing.Point(54, 410);
            this.txtAnyadirAmigos.Name = "txtAnyadirAmigos";
            this.txtAnyadirAmigos.Size = new System.Drawing.Size(120, 23);
            this.txtAnyadirAmigos.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amigo Seleccionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amigo Nuevo";
            // 
            // Ejercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnyadirAmigos);
            this.Controls.Add(this.txtAmigoSelec);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrarLista);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxAmigos);
            this.Name = "Ejercicio8";
            this.Text = "Ejercicio8";
            this.Load += new System.EventHandler(this.Ejercicio8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lboxAmigos;
        private Label label1;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnBorrarLista;
        private Button btnSalir;
        private TextBox txtAmigoSelec;
        private TextBox txtAnyadirAmigos;
        private Label label2;
        private Label label3;
    }
}