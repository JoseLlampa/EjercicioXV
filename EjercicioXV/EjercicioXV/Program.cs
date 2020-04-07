using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioXV
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 1;
            int maxIntentos = 3;
            string contraseña = "";
            string usuario = "";

            Console.WriteLine("Ingrese nombre de usuario");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña");

            do
            {
                contraseña = Console.ReadLine();
                if (contraseña != usuario)
                {
                    Console.WriteLine("Acceso denegado. La contraseña no es correcta.");
                }
                intentos++;
            } while (intentos<=maxIntentos && contraseña!=usuario); //PORQUE ES && Y NO ||

            if (contraseña == usuario)
            {
                Console.WriteLine("Bienvenido " + usuario);
            }
            else
            {
                Console.WriteLine("Clave bloqueada");
            }

            Console.ReadKey();
        }
    }
}
