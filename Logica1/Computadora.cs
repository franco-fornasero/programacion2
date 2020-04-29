using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica1
{
    public class Computadora : Producto
    {
        private string descripcionProcesador;
        private CapacidadMemoria cantidadRam;
        private string fabricante;

        public Computadora(string modelo, string marca, double numeroSerie, string descripcionProcesador, CapacidadMemoria cantidadRam, string fabricante) : base(modelo, marca, numeroSerie)
        {
            this.descripcionProcesador = descripcionProcesador;
            this.cantidadRam = cantidadRam;
            this.fabricante = fabricante;
        }

        public override string obtenerDescripcion()
        {
            return $"PC {marca} - {modelo} - {descripcionProcesador} - {cantidadRam}RAM - {fabricante}";
        }
    }
}
