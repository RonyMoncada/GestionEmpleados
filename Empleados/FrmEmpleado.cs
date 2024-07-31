using EmpleadoLib;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
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

    public partial class FrmEmpleado : Form
    {
        public event Action EmpleadoGuardado;
        public event Action EmpleadoActualizado;
        private ControladorEmpleado controladorEmpleado;

        public event Action OnempleadoGuardado;
        private ModoFormularioEnum _modo;

        public ModoFormularioEnum Modo
        {
            get => _modo;
            set
            {
                _modo = value;
            }
        }
        private int? EmpleadoId;
        private int siguienteIdDisponible;

        public FrmEmpleado()
        {
            InitializeComponent();
            controladorEmpleado = new ControladorEmpleado();
            siguienteIdDisponible = ObtenerSiguienteIdDisponible();
        }
        public FrmEmpleado(int id) : this()
        {
            EmpleadoId = id;
            CargarProductoEnFormulario(id);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
        private void CargarProductoEnFormulario(int id)
        {
            var empleado = controladorEmpleado.ObtenerEmpleados();
            var empleados = empleado.AsEnumerable().FirstOrDefault(p => p.Field<int>("EmpleadoID") == id);

            if (empleados != null)
            {
                txtId.Text = empleados.Field<int>("EmpleadoID").ToString();
                txtNombre.Text = empleados.Field<string>("Nombre");
                txtApellido.Text = empleados.Field<string>("Apellido");
                txtEmail.Text = empleados.Field<string>("Email");
                txtTelefono.Text = empleados.Field<string>("Telefono");
                cmbPosicion.Text = empleados.Field<string>("Posicion").ToString();

                var usuario = controladorEmpleado.ObtenerUsuarioPorEmpleadoId(id).AsEnumerable().FirstOrDefault();

                if (usuario != null)
                {
                    txtUsuario.Text = usuario.Field<string>("NombreUsuario");
                    txtContrasena.Text = usuario.Field<string>("Contrasena");
                }
                else
                {
                    // Mensaje de depuración
                    MessageBox.Show("No se encontró usuario para el empleado con ID: " + id);
                }
            }
            else
            {
                // Mensaje de depuración
                MessageBox.Show("No se encontró empleado con ID: " + id);
            }
        }
        private int ObtenerSiguienteIdDisponible()
        {

            return controladorEmpleado.ObtenerSiguienteIdDisponible();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            if (!EmpleadoId.HasValue)
            {
                // Si no se está editando un empleado existente, asignar el siguiente ID disponible al campo txtId.
                txtId.Text = siguienteIdDisponible.ToString();
            }
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;
            string posicion = cmbPosicion.SelectedItem.ToString();
            string nombreUsuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (EmpleadoId.HasValue)
            {
                controladorEmpleado.UpdateEmpleado(EmpleadoId.Value, nombre, apellido, email, telefono, posicion);
                var usuario = controladorEmpleado.ObtenerUsuarioPorEmpleadoId(EmpleadoId.Value).AsEnumerable().FirstOrDefault();
                if (usuario != null)
                {
                    int usuarioID = usuario.Field<int>("UsuarioID");
                    controladorEmpleado.ActualizarUsuario(usuarioID, nombreUsuario, posicion, contrasena);
                }
                else
                {
                    controladorEmpleado.AddUsuario(nombreUsuario, posicion, contrasena, EmpleadoId.Value);
                }
                MessageBox.Show("Empleado y usuario actualizados con éxito.");
                EmpleadoActualizado?.Invoke();
            }
            else
            {
                controladorEmpleado.AddEmpleado(siguienteIdDisponible, nombre, apellido, email, telefono, posicion);
                controladorEmpleado.AddUsuario(nombreUsuario, posicion, contrasena, siguienteIdDisponible);
                MessageBox.Show("Empleado y usuario añadidos con éxito.");
                EmpleadoGuardado?.Invoke();
            }

            Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}