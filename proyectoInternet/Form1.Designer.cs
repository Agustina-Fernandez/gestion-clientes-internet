namespace proyectoInternet
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            lblBienvenido = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnGuardar = new Button();
            btnSiguiente = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 50);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 151);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Location = new Point(275, 274);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(50, 20);
            lblBienvenido.TabIndex = 2;
            lblBienvenido.Text = "label3";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(275, 93);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(174, 27);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(275, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(174, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.GradientActiveCaption;
            btnGuardar.Location = new Point(308, 340);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 53);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.GradientActiveCaption;
            btnSiguiente.Location = new Point(694, 464);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(94, 43);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Thistle;
            btnSalir.Location = new Point(308, 426);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 47);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 519);
            Controls.Add(btnSalir);
            Controls.Add(btnSiguiente);
            Controls.Add(btnGuardar);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblBienvenido);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblBienvenido;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnGuardar;
        private Button btnSiguiente;
        private Button btnSalir;
    }
}
