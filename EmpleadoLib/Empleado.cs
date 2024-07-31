namespace EmpleadoLib
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Posicion { get; set; }

        public Empleado()
        {
            EmpleadoID = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Email = string.Empty;
            Telefono = string.Empty;
            Posicion = string.Empty;
        }

        public Empleado(int empleadoID, string nombre, string apellido, string email, string telefono, string posicion)
        {
            EmpleadoID = empleadoID;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            Posicion = posicion;
        }
    }
}
