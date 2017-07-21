using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPractica
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new PalabraList(false);
            var salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("Introduzca las palabras separadas por coma (,):");
                list.Clear();
                list.Agregar(Console.ReadLine());
                Console.WriteLine("Lista ordenada de la Z a la A:");
                Console.Write(list.ListarDeZaA());
                Console.WriteLine("\nIntroduzca S para salir");
                string respuesta = Console.ReadLine();
                if ("S".Equals(respuesta, StringComparison.CurrentCultureIgnoreCase))
                {
                    salir = true;
                }

            }

        }
    }
}
