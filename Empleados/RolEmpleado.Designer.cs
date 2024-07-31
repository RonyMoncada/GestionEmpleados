namespace Empleados
{
    partial class RolEmpleado
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
            btnConfirmar = new Button();
            cbRoles = new ComboBox();
            label6 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(112, 155);
            btnConfirmar.Margin = new Padding(2, 1, 2, 1);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(180, 55);
            btnConfirmar.TabIndex = 47;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // cbRoles
            // 
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new Point(289, 68);
            cbRoles.Margin = new Padding(2, 1, 2, 1);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new Size(275, 23);
            cbRoles.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(210, 71);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 45;
            label6.Text = "Posicion";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(504, 155);
            btnCancelar.Margin = new Padding(2, 1, 2, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(180, 55);
            btnCancelar.TabIndex = 44;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RolEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 245);
            Controls.Add(btnConfirmar);
            Controls.Add(cbRoles);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Name = "RolEmpleado";
            Text = "RolEmpleado";
            Load += RolEmpleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private ComboBox cbRoles;
        private Label label6;
        private Button btnCancelar;
    }
}