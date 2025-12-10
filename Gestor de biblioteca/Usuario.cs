using System;

namespace Gestor_de_biblioteca
{
    class Usuario
    {
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string SancionesPendientes { get; set; }

        public Usuario(int dni, string nombre, string direccion, int telefono, string sancionesPendientes)
        {
            DNI = dni;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            SancionesPendientes = sancionesPendientes;
        }

        public Usuario() { }
    }
}
