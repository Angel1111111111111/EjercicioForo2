using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioForo2
{
    public class redSocial
    {
        private string nombreUsuario;
        private string email;
        private string password;

        public redSocial()
        {
            
        }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public redSocial(string nombreUsuario, string email, string password )
        {
            this.NombreUsuario = nombreUsuario;
            this.Email = email;
        }

        public void mostrarInformacion()
        {
            Console.Write("Creando perfil");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(new string('.', i));
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine("Nombre del usuario: " + NombreUsuario);
            Console.WriteLine("Correo electronico: " +  Email);
        }
    }
}
