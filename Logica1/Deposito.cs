using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica1
{
    class Deposito
    {
        private List<Producto> productos;


        public void AgregarProducto(Monitor monitor)
        {
            productos.Add(monitor);
        }

        public void AgregarProducto(Computadora computadora)
        {
            productos.Add(computadora);
        }

        public void eliminarProducto(string identificador)
        {
            Producto prod = productos.Find(p => p.identificador == identificador);
            if (prod != null)
            {
                productos.Remove(prod);
            }
        }

        public List<string> ObtenerListaProductos()
        {
            List<string> nuevaLista = new List<string>();
            productos.ForEach(p => nuevaLista.Add(p.obtenerDescripcion()));
            nuevaLista.Sort();

            return nuevaLista;
        }
    }
}
