using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static string InvertirString(this string cadena)
        {
            char[] cadenaInvertida = cadena.ToCharArray();
            Array.Reverse(cadenaInvertida);
            return new string(cadenaInvertida);
        }

        public static string UnirCadenas(this List<string> lista, char caracter)
        {
            string nuevaCadena = "";
            foreach (var item in lista)
            {
                nuevaCadena = nuevaCadena + item + caracter;
            }
            return nuevaCadena.Remove(nuevaCadena.Length - 1, 1); 
        }
    
        public static bool ValidarMail(this string mail)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mail);
            return match.Success;
        }
    }

    public class Cliente
    {
        string Nombre;
        int cuit;
        public decimal saldo;

        public Cliente(string Nombre, int cuit, decimal saldo)
        {
            this.Nombre = Nombre;
            this.cuit = cuit;
            this.saldo = saldo;
        }

        public static Cliente operator -(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1.cuit == cliente2.cuit)
            {
                Cliente clienteNuevo = new Cliente(cliente1.Nombre, cliente1.cuit, cliente1.saldo - cliente2.saldo);
                return clienteNuevo;
            }
            else
            {
                if (cliente1.saldo < cliente2.saldo)
                {
                    return cliente1;
                }
                else
                {
                    return cliente2;
                }
            }
        }

        
    }

}


