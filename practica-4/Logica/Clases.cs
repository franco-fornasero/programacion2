using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    
    public sealed class Frase
    {
        public string frase { get; set; }
    }
    
    
    public static class Extension
    {
        public static int cantidadDePalabras(this Frase palabras)
        {
            string[] Palabras = palabras.frase.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' });
            int cantidad = Palabras.Length;
            return cantidad;
        }

        public static int cantidadDePalabras(this Frase palabras, char caracter)
        {
            string[] Palabras = palabras.frase.Split(caracter);
            int cantidad = Palabras.Length;
            return cantidad;
        }

        public static decimal calcularDifFechaSeg(this DateTime fecha1, DateTime fecha2)
        {
            int band = DateTime.Compare(fecha1, fecha2);
            TimeSpan resultado;
            decimal totalSeg;
            if (band <= 0)
            {
                resultado = fecha2.Subtract(fecha1);
            }
            else
            {
                resultado = fecha1.Subtract(fecha2);
            }
            totalSeg = Convert.ToDecimal(resultado.TotalSeconds);
            return totalSeg / 60;
        }

        public static decimal calcularPromedio(this List<int> enteros)
        {
            int suma = 0;
            foreach (var item in enteros)
            {
                suma = suma + item;
            }
            return suma/enteros.Count();
        }
    
        public static int Resultado(this List<int> Lista)
        {
            int sumaPares = 0;
            int restaImares = 0;
            foreach (var item in Lista)
            {
                if (item%2 == 0)
                {
                    sumaPares = sumaPares + item;
                }
                else
                {
                    restaImares = restaImares - item;
                }
            }
            return sumaPares * restaImares;
        }
    
        public static DateTime ConvertirString(this string cadena)
        {
            int error = 0;                                    
            try
            {

                DateTime fecha = DateTime.Parse(cadena);
                return fecha;
            }
            catch (Exception e)
            {
                error = 1;
                return DateTime.MinValue;
            }
            finally
            {
                if (error == 1)
                {
                    Console.WriteLine("Se produjo un error");
                    Console.ReadLine();
                }
            }
           

        }
    }

}
