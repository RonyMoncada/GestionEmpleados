using Empleados;
using EmpleadoLib;
using EmpleadoDao.EmpleadosDataSetTableAdapters;

namespace Inventarios
{
    public partial class FrmEmpleados : Form
    {
        private ControladorEmpleado controladorEmpleado;
        private EmpleadoDao.EmpleadosDataSetTableAdapters.EmpleadosTableAdapter EmpleadosTableAdapter;

        private string usuarioRol;


        public FrmEmpleados(string rol)
        {
            InitializeComponent();
            controladorEmpleado = new ControladorEmpleado();
            EmpleadosTableAdapter = new EmpleadoDao.EmpleadosDataSetTableAdapters.EmpleadosTableAdapter();
            usuarioRol = rol;
            AjustarPermisos();
        }



        private void gridProductos_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmEmpleado frmEmpleado = new FrmEmpleado();
            frmEmpleado.EmpleadoGuardado += FrmEmpleado_OnempleadoGuardado;
            frmEmpleado.Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void RefrescarListaEmpleado()
        {
            var empleadosConUsuarios = controladorEmpleado.ObtenerDatosEmpleadosConUsuarios();
            gridEmpleados.AutoGenerateColumns = true;
            gridEmpleados.DataSource = empleadosConUsuarios;
            AjustarVisibilidadColumnas();
            gridEmpleados.Refresh();
        }

        private void FrmEmpleado_OnempleadoGuardado()
        {
            RefrescarListaEmpleado();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            RefrescarListaEmpleado();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (gridEmpleados.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(gridEmpleados.SelectedRows[0].Cells[0].Value);
                controladorEmpleado.EliminarEmpleado(id);
                RefrescarListaEmpleado();
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar.");
            }
        }



        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usuarioRol == "Mesero")
            {
                MessageBox.Show("No puede editar los empleados ");
                
            }
            else{
                if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gridEmpleados.Rows[e.RowIndex];
                int EmpleadoId = Convert.ToInt32(row.Cells["EmpleadoId"].Value);

                FrmEmpleado frmProducto = new FrmEmpleado(EmpleadoId);
                frmProducto.OnempleadoGuardado += FrmEmpleado_OnempleadoGuardado;
                frmProducto.ShowDialog();
                }
             }
        }
        private void AjustarVisibilidadColumnas()
        {
            if (usuarioRol == "Mesero")
            {
                if (gridEmpleados.Columns.Contains("contrasena"))
                {
                    gridEmpleados.Columns["contrasena"].Visible = false;
                }
            }
            else
            {
                if (gridEmpleados.Columns.Contains("contrasena"))
                {
                    gridEmpleados.Columns["contrasena"].Visible = true;
                }
            }
        }
        private void AjustarPermisos()
        {
            if (usuarioRol == "Mesero")
            {
                buttonEliminar.Enabled = false;
            }
        }


        private void FrmEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
