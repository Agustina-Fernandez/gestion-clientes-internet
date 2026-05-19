namespace proyectoInternet
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtLocalidad = new TextBox();
            cmbServicio = new ComboBox();
            btnAlmacenar = new Button();
            btnMostrar = new Button();
            btnVolver = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 45);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre y Apellido:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 103);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 163);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Localidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 219);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Servicio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 271);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Precio:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(150, 271);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "label6";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(206, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(263, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(142, 100);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(263, 27);
            txtDireccion.TabIndex = 7;
            // 
            // txtLocalidad
            // 
            txtLocalidad.Location = new Point(144, 160);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(217, 27);
            txtLocalidad.TabIndex = 8;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Items.AddRange(new object[] { "Cable", "Internet", "Teléfono", "Pack completo" });
            cmbServicio.Location = new Point(131, 216);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(133, 28);
            cmbServicio.TabIndex = 9;
            // 
            // btnAlmacenar
            // 
            btnAlmacenar.BackColor = SystemColors.GradientActiveCaption;
            btnAlmacenar.Location = new Point(271, 361);
            btnAlmacenar.Name = "btnAlmacenar";
            btnAlmacenar.Size = new Size(110, 53);
            btnAlmacenar.TabIndex = 10;
            btnAlmacenar.Text = "Guardar";
            btnAlmacenar.UseVisualStyleBackColor = false;
            btnAlmacenar.Click += btnAlmacenar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.DarkSeaGreen;
            btnMostrar.Location = new Point(271, 447);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(110, 53);
            btnMostrar.TabIndex = 11;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Thistle;
            btnVolver.Location = new Point(444, 447);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(110, 53);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.MintCream;
            btnLimpiar.Location = new Point(444, 361);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 53);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 512);
            Controls.Add(btnLimpiar);
            Controls.Add(btnVolver);
            Controls.Add(btnMostrar);
            Controls.Add(btnAlmacenar);
            Controls.Add(cmbServicio);
            Controls.Add(txtLocalidad);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar nuevo cliente";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblPrecio;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtLocalidad;
        private ComboBox cmbServicio;
        private Button btnAlmacenar;
        private Button btnMostrar;
        private Button btnVolver;
        private Button btnLimpiar;
    }
}