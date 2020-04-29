using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica1;

namespace Practica_Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void NotificacionEventoProducto(object producto, EventArgs a)
        {
            if (producto is Monitor)
            {
                Monitor monitor = producto as Monitor;
                Console.WriteLine($"Producto eliminado/eliminado {monitor.obtenerDescripcion()}");
            }
            else
            {
                Computadora computadora = producto as Computadora;
                Console.WriteLine($"Producto eliminado/eliminado {computadora.obtenerDescripcion()}");
            }

        }
    }
}
