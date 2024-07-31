namespace Empleados
{
    partial class FrmEmpleado
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
            txtTelefono = new TextBox();
            btnCancelar = new Button();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbPosicion = new ComboBox();
            label6 = new Label();
            btnConfirmar = new Button();
            txtContrasena = new TextBox();
            label7 = new Label();
            txtUsuario = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(113, 157);
            txtTelefono.Margin = new Padding(2, 1, 2, 1);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(275, 23);
            txtTelefono.TabIndex = 36;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(494, 264);
            btnCancelar.Margin = new Padding(2, 1, 2, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 55);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 127);
            txtEmail.Margin = new Padding(2, 1, 2, 1);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 23);
            txtEmail.TabIndex = 33;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(114, 99);
            txtApellido.Margin = new Padding(2, 1, 2, 1);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(275, 23);
            txtApellido.TabIndex = 32;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(114, 70);
            txtNombre.Margin = new Padding(2, 1, 2, 1);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(275, 23);
            txtNombre.TabIndex = 31;
            // 
            // txtId
            // 
            txtId.Location = new Point(114, 41);
            txtId.Margin = new Padding(2, 1, 2, 1);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(275, 23);
            txtId.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 165);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 29;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 132);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 28;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 101);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 27;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 26;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 42);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 25;
            label1.Text = "Id";
            // 
            // cmbPosicion
            // 
            cmbPosicion.FormattingEnabled = true;
            cmbPosicion.Items.AddRange(new object[] { "Gerente", "Mesero" });
            cmbPosicion.Location = new Point(114, 194);
            cmbPosicion.Margin = new Padding(2, 1, 2, 1);
            cmbPosicion.Name = "cmbPosicion";
            cmbPosicion.Size = new Size(275, 23);
            cmbPosicion.TabIndex = 38;
            cmbPosicion.SelectedIndexChanged += cmbPosicion_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 197);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 37;
            label6.Text = "Posicion";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(233, 264);
            btnConfirmar.Margin = new Padding(2, 1, 2, 1);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(180, 55);
            btnConfirmar.TabIndex = 39;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click_1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(532, 149);
            txtContrasena.Margin = new Padding(2, 1, 2, 1);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(275, 23);
            txtContrasena.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 157);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 40;
            label7.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(532, 93);
            txtUsuario.Margin = new Padding(2, 1, 2, 1);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(275, 23);
            txtUsuario.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(453, 101);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 42;
            label8.Text = "Usuario";
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 360);
            Controls.Add(txtUsuario);
            Controls.Add(label8);
            Controls.Add(txtContrasena);
            Controls.Add(label7);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbPosicion);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(btnCancelar);
            Controls.Add(txtEmail);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmEmpleado";
            Text = "Empleado";
            Load += FrmEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefono;
        private Button btnCancelar;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbPosicion;
        private Label label6;
        private Button btnConfirmar;
        private TextBox txtContrasena;
        private Label label7;
        private TextBox txtUsuario;
        private Label label8;
    }
}
