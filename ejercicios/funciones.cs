using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class funciones
    {
        /// <summary>
        ///validar rango entre -100 y 100.
        /// </summary>
        /// <param name="valorIngresado"></param>
        /// <returns>bool</returns>
        public static bool Validar(int valor, int min, int max)
        {
            return valor >= min && valor <= max;
        }

        public static bool ValidarRespuesta(char opcion)
        {
            return (opcion == 's');
        }

        public static string ConvertirDecimalABinario(int enDecimal)
        {
            if (enDecimal == 0)
            {
                return "0";
            }

            string binario = "";
            while (enDecimal > 0)
            {
                int resto = enDecimal % 2;
                binario = resto + binario;
                enDecimal = enDecimal / 2;
            }

            return binario;
        }


        public static int ConvertirBinarioADecimal(string enBinario)
        {
            int aDesimal = 0;
            int longitud = enBinario.Length - 1;
            int exponente = 0;

            for (int i = longitud; i >= 0; i--)
            {
                int digito = int.Parse(enBinario[i].ToString());
                aDesimal += digito * (int)Math.Pow(2, exponente);
                exponente++;
            }
            return aDesimal;
        }

        public static int PedirUnNumero()
        {
            int valorIngresado;

            Console.WriteLine("ingresa un numero");
            bool sePudoValidar = int.TryParse(Console.ReadLine(), out valorIngresado);

            while (!sePudoValidar)
            {
                Console.WriteLine("Entrada incorrecta, ingresa solo números:");
                sePudoValidar = int.TryParse(Console.ReadLine(), out valorIngresado);
            }
            return valorIngresado;

        }
        public static char PedirUnChar()
        {
            char operacion;

            Console.WriteLine("ingresa operacion +,-,*,/");
            bool sePudoValidar = char.TryParse(Console.ReadLine(), out operacion);

            while (!sePudoValidar || (operacion != '+' && operacion != '-' && operacion != '/' && operacion != '*'))
            {
                Console.WriteLine("Entrada incorrecta, ingresa operacion +,-,*,/");
                sePudoValidar = char.TryParse(Console.ReadLine(), out operacion);
            }
            return operacion;
        }

        public static string MostrarTablaDel(int tablaDelNumero)
        {
            Console.WriteLine($"Tabla de multiplicar del número {tablaDelNumero}:");
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < 10; i++)
            {
                //Console.WriteLine($" {i} x {tablaDelNumero} = {i * tablaDelNumero}");
                sb.Append($"\n {i} x {tablaDelNumero} = {i * tablaDelNumero}");
            }
            string mensaje = sb.ToString();
            Console.WriteLine(mensaje);
            return mensaje;
        }

        public static DateTime PedirUnaFecha()
        {
            DateTime fecha;

            Console.WriteLine("Ingrese una fecha (formato: dd/mm/yyyy): ");
            bool sePudoValidar = DateTime.TryParse(Console.ReadLine(), out fecha);

            while (!sePudoValidar)
            {
                Console.WriteLine("Entrada incorrecta, Ingrese una fecha (formato: dd/mm/yyyy): ");
                sePudoValidar = DateTime.TryParse(Console.ReadLine(), out fecha);
            }
            return fecha;
        }


        public static long CalcularFactorial(int numero)
        {
            long factorial = numero;
            for (int i = numero - 1; i >= 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }









































































        
    }
}

