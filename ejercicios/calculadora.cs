using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    internal class calculadora
    {

        /*Ejercicio I04 - La calculadora       
        Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
        Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
        El método devolverá el resultado de la operación.
            
        Validar (privado): Recibirá como parámetro el segundo operando. 
        Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
        Este método devolverá true si el operando es distinto de cero.*/

        public static float Calcular(int primerOperador, int segundoOperador, char operacion)
        {
            float resultado = 0;
            bool esCero = false;

            switch (operacion)
            {
                case '+':
                    resultado = primerOperador + segundoOperador;
                    break;
                case '-':
                    resultado = primerOperador - segundoOperador;
                    break;
                case '*':
                    resultado = primerOperador * segundoOperador;
                    break;
                case '/':
                    if (Validar(segundoOperador))
                    {
                        resultado = primerOperador / segundoOperador;
                    }
                    else
                    {
                        Console.WriteLine("no es posible hacer la operacion");
                    }
                    break;

            }
            return resultado;
        }
    
        private static bool Validar(int segundoOperador)
        {
            return segundoOperador != 0;
        }












    
    
    
    
    
    
    
    
    
    
    
    
    }
}
