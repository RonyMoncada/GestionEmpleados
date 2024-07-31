namespace Inventarios
{
    partial class FrmEmpleados
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
            components = new System.ComponentModel.Container();
            bindingSrc = new BindingSource(components);
            gridEmpleados = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnVer = new Button();
            btnEliminar = new Button();
            buttonCargar = new Button();
            buttonEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSrc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).BeginInit();
            SuspendLayout();
            // 
            // gridEmpleados
            // 
            gridEmpleados.AllowUserToAddRows = false;
            gridEmpleados.AllowUserToDeleteRows = false;
            gridEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridEmpleados.AutoGenerateColumns = false;
            gridEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmpleados.DataSource = bindingSrc;
            gridEmpleados.Location = new Point(11, 32);
            gridEmpleados.Margin = new Padding(2, 1, 2, 1);
            gridEmpleados.MultiSelect = false;
            gridEmpleados.Name = "gridEmpleados";
            gridEmpleados.ReadOnly = true;
            gridEmpleados.RowHeadersWidth = 82;
            gridEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEmpleados.Size = new Size(862, 275);
            gridEmpleados.TabIndex = 0;
            gridEmpleados.CellContentClick += gridProductos_CellContentClick;
            gridEmpleados.CellDoubleClick += gridProductos_CellDoubleClick;
            gridEmpleados.SelectionChanged += gridProductos_SelectionChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(104, 320);
            btnNuevo.Margin = new Padding(2, 1, 2, 1);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(161, 73);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.Location = new Point(780, 443);
            btnEditar.Margin = new Padding(2, 1, 2, 1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(81, 22);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnVer
            // 
            btnVer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVer.Location = new Point(696, 443);
            btnVer.Margin = new Padding(2, 1, 2, 1);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(81, 22);
            btnVer.TabIndex = 4;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.Location = new Point(864, 443);
            btnEliminar.Margin = new Padding(2, 1, 2, 1);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(81, 22);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // buttonCargar
            // 
            buttonCargar.Location = new Point(396, 320);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(155, 74);
            buttonCargar.TabIndex = 6;
            buttonCargar.Text = "Ver";
            buttonCargar.UseVisualStyleBackColor = true;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(666, 320);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(155, 74);
            buttonEliminar.TabIndex = 7;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 405);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonCargar);
            Controls.Add(btnEliminar);
            Controls.Add(btnVer);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(gridEmpleados);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FrmEmpleados";
            Text = "Empleados";
            Load += FrmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSrc).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSrc;
        private DataGridView gridEmpleados;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnVer;
        private Button btnEliminar;
        private Button buttonCargar;
        private Button buttonEliminar;
    }
}
