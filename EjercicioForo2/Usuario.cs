using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioForo2
{
    internal class Usuario : redSocial
    {
        public string nombre;
        public int edad;

        public Usuario(string nombreUsuario, string email, string password, string nombre, int edad)
            : base(nombreUsuario, email, password)
        {
            base.mostrarInformacion();
            this.nombre = nombre;
            this.edad = edad;
        }
        public void mostrarInformacion()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);

            Console.WriteLine("Perfil creado.");
            Console.WriteLine("---------------------------");
        }
    }
}
