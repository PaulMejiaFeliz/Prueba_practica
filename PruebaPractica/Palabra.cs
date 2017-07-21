using System;
using System.Runtime.Remoting.Messaging;

namespace PruebaPractica
{
    public class Palabra
    {

        public string Nombre { get; set; }
        public int Cantidad { get; set; }

        public Palabra(string nombre)
        {
            Nombre = nombre;
            Cantidad = 1;
        }

        public Palabra(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }
    }
}