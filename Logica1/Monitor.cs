using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica1
{
    public class Monitor : Producto
    {
        private int anioFabricacion;
        private bool esNuevo;
        private int? pulgadas;

        public Monitor(string modelo, string marca, double numeroSerie, int anioFabricacion, int pulgadas) : base(modelo, marca, numeroSerie)
        {
            this.anioFabricacion = anioFabricacion;
            this.pulgadas = pulgadas;
        }

        public bool EsNuevo()
        {
            return this.anioFabricacion == DateTime.Now.Year;
        }

        public override string obtenerDescripcion()
        {
            return $"MONITOR {marca} - {modelo} - {pulgadas}";
        }
    }
}
