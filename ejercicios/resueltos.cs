namespace ejercicios
{
    internal class Program2
    {
        static void resueltos(string[] args)
        {
            /*
            int valorIngresado;

            Console.WriteLine("validacion de numero ingresado");
            Console.WriteLine("ingresa un numero");
            bool sePudoValidar = int.TryParse(Console.ReadLine(), out valorIngresado);

            while (!sePudoValidar)
            {
                Console.WriteLine("Entrada incorrecta, ingresa solo números:");
                sePudoValidar = int.TryParse(Console.ReadLine(), out valorIngresado);
            }
            Console.WriteLine($"Número ingresado: {valorIngresado}");

            /////////////////////ejercicio 1/////////////////////////////////////////
            /*
            Console.WriteLine("\nejercicio 1");
            ///Consigna
            Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
            bool Validar(int valor, int min, int max)
            valor: dato a validar.
            min: mínimo valor incluido.
            max: máximo valor incluido.
            Pedir al usuario que ingrese 10 números enteros.Validar con el método desarrollado anteriormente que estén 
            dentro del rango -100 y 100.
            Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio. 
            */
            /*
            int valorMinimo = int.MaxValue;
            int valorMaximo = int.MinValue;
            int valorAcumulado = 0;


            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("ingresa números entre 100 y -100:");
                sePudoValidar = int.TryParse(Console.ReadLine(), out valorIngresado);

                while (!sePudoValidar || !funciones.Validar(valorIngresado, -100, 100))
                {
                    Console.WriteLine("Entrada incorrecta, ingresa solo números entre 100 y -100");
                    sePudoValidar = int.TryParse(Console.ReadLine(), out valorIngresado);
                }
                valorAcumulado += valorIngresado;

                if (valorMinimo > valorIngresado)
                {
                    valorMinimo = valorIngresado;
                }
                else
                {
                    if (valorMaximo < valorIngresado)
                    {
                        valorMaximo = valorIngresado;
                    }
                }
            }
            int promedio = valorAcumulado / 10;
            Console.Write($"valor minimo: {valorMinimo}, maximo: {valorMaximo}, promedio: {promedio}");

            /////////////////////////////// ejercicio 2  ////////////////////////////////////////////////////
            /*
            Console.WriteLine("\nejercicio 2");
            Ejercicio I02 - ¿Desea continuar?
            Consigna
            Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
            "¿Desea continuar? (S/N)".
            Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
            El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
            Resolución*/
            /*
            bool continuar = true;
            int suma = 0;

            while (continuar)
            {
                Console.WriteLine("ingrese un numero");
                sePudoValidar = int.TryParse(Console.ReadLine(), out valorIngresado);

                while (!sePudoValidar)
                {
                    Console.WriteLine("Entrada incorrecta, ingresa solo números:");
                    sePudoValidar = int.TryParse(Console.ReadLine(), out valorIngresado);
                }
                suma += valorIngresado;
                Console.WriteLine("desea continuar s/n");
                char opcion = Console.ReadLine()[0];
                continuar = funciones.ValidarRespuesta(opcion);
            }
            Console.WriteLine($"suma = {suma}");

            //////////////////////////  ejercicio 3  /////////////////////////////////////////

            /*Ejercicio I03 - Conversor binario
            Consigna
            Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):
            El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.
            public string ConvertirDecimalABinario(int numeroEntero) {}
            El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.
            public int ConvertirBinarioADecimal(int numeroEntero) {}
            IMPORTANTE
            NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.*/
            /*
            int enDesimal = 15;

            string binario = funciones.ConvertirDecimalABinario(enDesimal);
            Console.WriteLine($"numero {enDesimal} a binario: {binario}");

            string enBinario = "1101";

            int decimalResult = funciones.ConvertirBinarioADecimal(enBinario);
            Console.WriteLine($"numero {enBinario} a decimal: {decimalResult}");


            ////////////////////////////////////// ejercicio 4 /////////////////////////////////////////

            /*Ejercicio I04 - La calculadora
            Consigna
            Realizar un programa que permita realizar operaciones matemáticas simples 
            (suma, resta, multiplicación y división).

            Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
            Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
            El método devolverá el resultado de la operación.

            Validar (privado): Recibirá como parámetro el segundo operando. 
            Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. 
            Este método devolverá true si el operando es distinto de cero.

            Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar 
            (ingresando el caracter +, -, * o /).
            El usuario decidirá cuándo finalizar el programa.*/
            
            /*
            int primerOperando;
            int segundoOperando;
            char operador;

            primerOperando = funciones.PedirUnNumero();
            segundoOperando = funciones.PedirUnNumero();
            operador = funciones.PedirUnChar();

            Console.WriteLine($"primer Operando: {primerOperando}, segundo Operando: {segundoOperando}, operador: {operador}");

            float resultado = calculadora.Calcular(primerOperando, segundoOperando, operador);
            Console.WriteLine(resultado);



            ////////////////////////////////// ejercicio 5 //////////////////////////////////////////////////

                        /*Ejercicio I05 - Aprendete las tablas
            Consigna
            Crear una aplicación de consola que permita al usuario ingresar un número entero.
            Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número 
            en formato string. Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar 
            el resultado.
            Mostrar en la consola el resultado.

            Por ejemplo, si se ingresa el número 2 la salida deberá ser:
            Tabla de multiplicar del número 2:
            2 x 1 = 2*/
            /*
            int tablaDelNumero;
            tablaDelNumero = funciones.PedirUnNumero();
            funciones.MostrarTablaDel(tablaDelNumero);

                                    ////////////////////////////////// ejercicio 6 //////////////////////////////////////////////////

            /*Ejercicio I06 - Calculadora de áreas
            Consigna
            Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

            public double CalcularAreaCuadrado(double longitudLado) {}
            public double CalcularAreaTriangulo(double base, double altura) {}
            public double CalcularAreaCirculo(double radio) {}

            El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/
            /*
            double longitudLado = 10.5;

            double areaCuadrado = CalculadoraDeAreas.CalcularAreaCuadrado(longitudLado);
            Console.WriteLine($"area del cuadrado de lado {longitudLado} :{areaCuadrado}");

            double baseTriangulo = 15;
            double altura = 10;

            double areaTriangulo = CalculadoraDeAreas.CalcularAreaTriangulo(baseTriangulo, altura);
            Console.WriteLine($"area del tiangulo de base {baseTriangulo} y altura {altura} :{areaTriangulo}");

            double radioCirculo = 3;

            double areaCirculo = CalculadoraDeAreas.CalcularAreaCirculo(radioCirculo);
            Console.WriteLine($"area del circulo de radio {radioCirculo} :{areaCirculo}");

            /////////////////////////////////////ejercicio 7 ///////////////////////////////////////////////////
            /*
            Ejercicio I07 - Pitágoras estaría orgulloso
            Consigna
            Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

            El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

            Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

            Mostrar el resultado en la consola. 
            



            Console.WriteLine("para la base");
            int baseTriangulo = funciones.PedirUnNumero();
            Console.WriteLine("para la altura");
            int altura = funciones.PedirUnNumero();

            double hipotenusa = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(altura, 2));
            Console.WriteLine($"longitud de la hipotenusa = {hipotenusa} ");


            */



























































































        }





















    }
}
