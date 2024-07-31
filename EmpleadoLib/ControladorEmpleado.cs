using EmpleadoDao;
using System.Data;

namespace EmpleadoLib
{
    public class ControladorEmpleado
    {
        private Contexto contexto;

        public ControladorEmpleado()
        {
            contexto = new Contexto();
        }

        public DataTable ObtenerEmpleados()
        {
            return contexto.GetEmpleados();
        }
        public DataTable ObtenerDatosEmpleadosConUsuarios()
        {
            // Obtener los empleados
            DataTable empleadosTable = contexto.GetEmpleados();

            // Crear una nueva DataTable para la información combinada
            DataTable resultadoTable = new DataTable();

            // Definir las columnas de la DataTable combinada
            resultadoTable.Columns.Add("EmpleadoID", typeof(int));
            resultadoTable.Columns.Add("Nombre", typeof(string));
            resultadoTable.Columns.Add("Apellido", typeof(string));
            resultadoTable.Columns.Add("Email", typeof(string));
            resultadoTable.Columns.Add("Telefono", typeof(string));
            resultadoTable.Columns.Add("Posicion", typeof(string));
            resultadoTable.Columns.Add("NombreUsuario", typeof(string));
            resultadoTable.Columns.Add("Contrasena", typeof(string));

            // Recorrer los empleados
            foreach (DataRow empleadoRow in empleadosTable.Rows)
            {
                int empleadoID = empleadoRow.Field<int>("EmpleadoID");

                // Obtener el usuario para el empleado actual
                DataTable usuarioTable = contexto.GetUsuarioPorEmpleadoId(empleadoID);

                foreach (DataRow usuarioRow in usuarioTable.Rows)
                {
                    // Añadir los datos combinados a la nueva DataTable
                    resultadoTable.Rows.Add(
                        empleadoID,
                        empleadoRow.Field<string>("Nombre"),
                        empleadoRow.Field<string>("Apellido"),
                        empleadoRow.Field<string>("Email"),
                        empleadoRow.Field<string>("Telefono"),
                        empleadoRow.Field<string>("Posicion"),
                        usuarioRow.Field<string>("NombreUsuario"),
                        usuarioRow.Field<string>("Contrasena")
                    );
                }
            }

            return resultadoTable;
        }

        public DataTable ObtenerUsuarioPorEmpleadoId(int empleadoID)
        {
            return contexto.GetUsuarioPorEmpleadoId(empleadoID);
        }

        public void AddEmpleado(int empleadoID, string nombre, string apellido, string email, string telefono, string posicion)
        {
            contexto.AddEmpleado(empleadoID, nombre, apellido, email, telefono, posicion);
        }

        public void UpdateEmpleado(int empleadoID, string nombre, string apellido, string email, string telefono, string posicion)
        {
            contexto.ActualizarEmpleado(empleadoID, nombre, apellido, email, telefono, posicion);
        }

        public void AddUsuario(string nombreUsuario, string posicion, string contrasena, int empleadoID)
        {
            contexto.AddUsuario(nombreUsuario, posicion, contrasena, empleadoID);
        }

        public void ActualizarUsuario(int usuarioID, string nombreUsuario, string posicion, string contrasena)
        {
            contexto.ActualizarUsuario(usuarioID, nombreUsuario, posicion, contrasena);
        }

        public int ObtenerSiguienteIdDisponible()
        {
            DataTable empleados = contexto.GetEmpleados();
            if (empleados.Rows.Count == 0)
                return 1;

            return empleados.AsEnumerable().Max(row => row.Field<int>("EmpleadoID")) + 1;
        }

        public void EliminarEmpleado(int empleadoID)
        {
            contexto.EliminarEmpleado(empleadoID);
        }

        public void EliminarUsuario(int empleadoID)
        {
            contexto.EliminarUsuarioPorEmpleadoID(empleadoID);
        }
    }
}
