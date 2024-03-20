using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Ficheros.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menu()
        {

            Console.WriteLine("-----------------");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Modificar línea específica.");
            Console.WriteLine("[2] - Inserta texto por posición");
            Console.WriteLine("-----------------");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}
