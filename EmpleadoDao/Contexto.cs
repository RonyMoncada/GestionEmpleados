using System;
using System.Data;
using System.Data.SqlClient;

namespace EmpleadoDao
{
    public class Contexto
    {
        private string connectionString = @"Data Source=LAPTOP-D5BUJAN7\SQLEXPRESS;Initial Catalog=Restaurante_Gourmet;Integrated Security=True;Encrypt=False";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable GetEmpleados()
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Empleados", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable empleadosTable = new DataTable();
                adapter.Fill(empleadosTable);
                return empleadosTable;
            }
        }

        public DataTable GetUsuarioPorEmpleadoId(int empleadoID)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE EmpleadoID = @EmpleadoID", con);
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable usuariosTable = new DataTable();
                adapter.Fill(usuariosTable);
                return usuariosTable;
            }
        }

        public void AddEmpleado(int empleadoID, string nombre, string apellido, string email, string telefono, string posicion)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Empleados (Nombre, Apellido, Email, Telefono, Posicion) VALUES (@Nombre, @Apellido, @Email, @Telefono, @Posicion)", con);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Posicion", posicion);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ActualizarEmpleado(int empleadoID, string nombre, string apellido, string email, string telefono, string posicion)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Empleados SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Telefono = @Telefono, Posicion = @Posicion WHERE EmpleadoID = @EmpleadoID", con);
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Posicion", posicion);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void AddUsuario(string nombreUsuario, string posicion, string contrasena, int empleadoID)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (NombreUsuario, Posicion, Contrasena, EmpleadoID) VALUES (@NombreUsuario, @Posicion, @Contrasena, @EmpleadoID)", con);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Posicion", posicion);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void ActualizarUsuario(int usuarioID, string nombreUsuario, string posicion, string contrasena)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET NombreUsuario = @NombreUsuario, Posicion = @Posicion, Contrasena = @Contrasena WHERE UsuarioID = @UsuarioID", con);
                cmd.Parameters.AddWithValue("@UsuarioID", usuarioID);
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Posicion", posicion);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void EliminarEmpleado(int empleadoID)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Empleados WHERE EmpleadoID = @EmpleadoID", con);
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);
                EliminarUsuarioPorEmpleadoID(empleadoID);
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public DataTable ObtenerUsuarioPorEmpleadoId(int id)
        {
            // Asume que tienes una conexión a la base de datos
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuarios WHERE EmpleadoID = @id";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }
        public DataTable ObtenerUsuarios()
        {
            DataTable usuariosTable = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuarios";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(usuariosTable);
                    }
                }
            }
            return usuariosTable;
        }
        public DataTable ObtenerEmpleados()
        {
            DataTable empleadosTable = new DataTable();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Empleados";
                using (var command = new SqlCommand(query, connection))
                {
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(empleadosTable);
                    }
                }
            }
            return empleadosTable;
        }

        public void EliminarUsuarioPorEmpleadoID(int empleadoID)
        {
            using (SqlConnection con = GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE EmpleadoID = @EmpleadoID", con);
                cmd.Parameters.AddWithValue("@EmpleadoID", empleadoID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
