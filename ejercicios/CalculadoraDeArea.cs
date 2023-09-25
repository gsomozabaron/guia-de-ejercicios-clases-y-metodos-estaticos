using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class CalculadoraDeAreas
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double areaCuadrado = Math.Pow(longitudLado, 2);
            return areaCuadrado;
        }
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            double areaTriangulo = (baseTriangulo * altura)/2;
            return areaTriangulo;
        }
        public static double CalcularAreaCirculo(double radio) 
        {
            double areaCirculo = Math.PI * Math.Pow(radio, 2);
            return areaCirculo;
        }
    }
}
