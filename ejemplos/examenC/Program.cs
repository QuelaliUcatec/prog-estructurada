class Program
{
    static void ejercicio1()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());
        if (numero > 0 && numero % 5 == 0)
        {
            Console.WriteLine("El número es positivo y múltiplo de 5.");
        }
        else
        {
            if (numero <= 0)
            {
                Console.WriteLine("El número no es positivo.");
            }
            if (numero % 5 != 0)
            {
                Console.WriteLine("El número no es múltiplo de 5.");
            }
        }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ejercicio2()
    {
        Console.Write("Ingrese el primer ángulo del triángulo: ");
        int angulo1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo ángulo del triángulo: ");
        int angulo2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer ángulo del triángulo: ");
        int angulo3 = int.Parse(Console.ReadLine());

        int sumaAngulos = angulo1 + angulo2 + angulo3;

        if (sumaAngulos == 180)
        {
            Console.WriteLine("Los ángulos forman un triángulo válido.");
            if (angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
            {
                Console.WriteLine("El triángulo es rectángulo.");
            }
            else
            {
                Console.WriteLine("El triángulo no es rectángulo.");
            }
        }
        else
        {
            Console.WriteLine("Los ángulos no suman 180°, no forman un triángulo válido.");
        }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void ejercicio3()
    {
        Console.Write("Ingrese la nota del estudiante (0-100): ");
        int nota = int.Parse(Console.ReadLine());
        if (nota >= 90)
        {
            Console.WriteLine("Excelente");
            if (nota == 100)
            {
                Console.WriteLine("¡Felicidades, puntaje perfecto!");
            }
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Aprobado");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        bool band = true;
        while (band)        {
            Console.WriteLine("Seleccione un ejercicio para ejecutar:");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Salir");
            Console.Write("Ingrese su opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ejercicio1();
                    Console.Clear();
                    break;
                case 2:
                    ejercicio2();
                    Console.Clear();
                    break;
                case 3:
                    ejercicio3();
                    Console.Clear();
                    break;
                case 4:
                    band = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                    Console.Clear();
                    break;
            }
            Console.WriteLine();
        }
    }
}
