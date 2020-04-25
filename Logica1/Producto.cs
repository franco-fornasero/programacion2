using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica1
{
    public abstract class Producto
    {
        protected string modelo { get; set; }
        protected string marca { get; set; }
        protected double numeroSerie { get; set; }
        public string identificador { get; set; }

        public Producto(string modelo, string marca, double numeroSerie)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.numeroSerie = numeroSerie;
            this.identificador = modelo + marca + numeroSerie;
        }

        public abstract string obtenerDescripcion();

    }
}
