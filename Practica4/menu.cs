using System.Runtime.ExceptionServices;

class Program
{
    // Suma de dos numeros
    static void Ejemplo()
    {
        Console.WriteLine("Ingrese el primer ,,,,,, numero: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el segundo.......... numero: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = num1 + num2;

        Console.WriteLine("El resultado es: " + resultado);

        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();

    }

    // Definir si un numero es positivo, negativo o cero
    static void Ejercicio1()
    {
        Console.Write("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("El numero es POSITIVO");
        }
        else if (numero < 0)
        {
            Console.WriteLine("El numero es NEGATIVO");
        }
        else
        {
            Console.WriteLine("El numero es CERO");
        }

        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Si un numero es par o inpar
    static void Ejercicio2()
    {
        Console.Write("Ingrese un numero: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Es PAR");
        }
        else
        {
            Console.WriteLine("Es INPAR");
        }

        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar == true)
        {
            Console.Clear();
            Console.WriteLine("========= MENU DE LA PRACTICA 4 =========");
            Console.WriteLine("1. Ejemplo: Suma de dos numeros ");
            Console.WriteLine("2. Ejercicio 1: Numero positivo, negativo o cero");
            Console.WriteLine("3. Ejercicio 2: Numero PAR o IMPAR");
            Console.WriteLine("0. SALIR !!! ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Ejemplo();
                    break;
                case "2":
                    Ejercicio1();
                    break;
                case "3":
                    Ejercicio2();
                    break;
                case "0":
                    continuar = false;
                    Console.WriteLine("Programa Terminado......");
                    break;
                default:
                    Console.WriteLine("OPCION INVALIDA!!!, Presiones cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
            }
        }
    }
}