using Inventarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class RolEmpleado : Form
    {
        public RolEmpleado()
        {
            InitializeComponent();
            cbRoles.Items.Add("Gerente");
            cbRoles.Items.Add("Mesero");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cbRoles.SelectedItem != null)
            {
                string rolSeleccionado = cbRoles.SelectedItem.ToString();
                FrmEmpleados frmEmpleados = new FrmEmpleados(rolSeleccionado);
                frmEmpleados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rol.");
            }
        }

        private void RolEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
