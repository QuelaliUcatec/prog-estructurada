class Ejercicios
{
    // Ejercicio 1: Imprimir los números del 1 al 10 con un bucle for
    static void Ejercicio1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    // Ejercicio 2: Imprimir los números del 10 al 1 con un bucle while
    static void Ejercicio2()
    {
        int i = 10;
        while (i >= 1)
        {
            Console.WriteLine(i);
            i--;
        }
    }

    // Ejercicio 3: Calcular la suma de los primeros 10 números naturales
    static void Ejercicio3()
    {
        int suma = 0;
        for (int i = 1; i <= 10; i++)
        {
            suma += i;
        }
        Console.WriteLine("La suma de los primeros 10 números naturales es: " + suma);
    }

    // Ejercicio 4: Tabla de multiplicar de un número ingresado por el usuario
    static void Ejercicio4()
    {
        Console.Write("Ingrese un número para mostrar su tabla de multiplicar: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
        }
    }

    // Ejercicio 5: Imprimir números pares entre 1 y 50
    static void Ejercicio5()
    {
        Console.WriteLine("Números pares entre 1 y 50:");
        for (int i = 2; i <= 50; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    // Ejercicio 6: Números del 1 al 30 divisibles por 3
    static void Ejercicio6()
    {
        Console.WriteLine("Números divisibles por 3 entre 1 y 30:");
        for (int i = 1; i <= 30; i++)
        {
            if (i % 3 == 0)
                Console.WriteLine(i);
        }
    }

    // Ejercicio 7: Suma de todos los números pares entre 1 y 100
    static void Ejercicio7()
    {
        int suma = 0;
        for (int i = 2; i <= 100; i += 2)
        {
            suma += i;
        }
        Console.WriteLine("La suma de todos los números pares entre 1 y 100 es: " + suma);
    }

    // Ejercicio 8: Factorial de un número
    static void Ejercicio8()
    {
        Console.Write("Ingrese un número entero positivo para calcular su factorial: ");
        int numero = int.Parse(Console.ReadLine());
        long factorial = 1;
        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    // Ejercicio 9: Contar vocales de una palabra
    static void Ejercicio9()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();
        string vocales = "aeiouAEIOU";
        int contador = 0;
        foreach (char letra in palabra)
        {
            if (vocales.Contains(letra))
                contador++;
        }
        Console.WriteLine($"La palabra '{palabra}' tiene {contador} vocales.");
    }

    // Ejercicio 10: Promedio de 5 notas
    static void Ejercicio10()
    {
        double suma = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingrese la nota {i + 1}: ");
            suma += double.Parse(Console.ReadLine());
        }
        double promedio = suma / 5;
        Console.WriteLine($"El promedio de las notas es: {promedio}");
    }

    // Ejercicio 11: Mostrar caracteres de una cadena en orden inverso
    static void Ejercicio11()
    {
        Console.Write("Ingrese una cadena de texto: ");
        string cadena = Console.ReadLine();
        Console.WriteLine("Caracteres en orden inverso:");
        for (int i = cadena.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(cadena[i]);
        }
    }

    // Ejercicio 12: Buscar un valor en una lista predefinida
    static void Ejercicio12()
    {
        int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.Write("Ingrese un valor para buscar en la lista: ");
        int valor = int.Parse(Console.ReadLine());
        bool encontrado = false;
        for (int i = 0; i < lista.Length; i++)
        {
            if (lista[i] == valor)
            {
                Console.WriteLine($"El valor {valor} se encuentra en la lista en el índice {i}");
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
            Console.WriteLine($"El valor {valor} no se encuentra en la lista");
    }

    // Ejercicio 13: Verificar contraseña hasta que sea correcta
    static void Ejercicio13()
    {
        string claveCorrecta = "python123";
        while (true)
        {
            Console.Write("Ingrese la contraseña: ");
            string clave = Console.ReadLine();
            if (clave == claveCorrecta)
            {
                Console.WriteLine("Contraseña correcta. Acceso permitido.");
                break;
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta. Inténtelo de nuevo.");
            }
        }
    }

    // Ejercicio 14: Primeros 10 números de Fibonacci
    static void Ejercicio14()
    {
        int a = 0, b = 1;
        Console.WriteLine("Primeros 10 números de la sucesión de Fibonacci:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }

    // Ejercicio 15: Determinar si un número es primo
    static void Ejercicio15()
    {
        Console.Write("Ingrese un número entero: ");
        int numero = int.Parse(Console.ReadLine());
        bool esPrimo = true;
        if (numero < 2)
        {
            esPrimo = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }
        if (esPrimo)
            Console.WriteLine($"El número {numero} es primo.");
        else
            Console.WriteLine($"El número {numero} no es primo.");
    }

    // Ejercicio 16: Triángulo de asteriscos
    static void Ejercicio16()
    {
        Console.Write("Ingrese la altura del triángulo de asteriscos: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }

    // Ejercicio 17: Menú de cajero (Ver saldo, Retirar, Salir)
    static void Ejercicio17()
    {
        double saldo = 1000;
        while (true)
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Ver saldo");
            Console.WriteLine("2. Retirar");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine($"Su saldo actual es: ${saldo}");
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el monto a retirar: ");
                double monto = double.Parse(Console.ReadLine());
                if (monto > saldo)
                    Console.WriteLine("Saldo insuficiente.");
                else
                {
                    saldo -= monto;
                    Console.WriteLine($"Retiro exitoso. Su nuevo saldo es: ${saldo}");
                }
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                break;
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
            }
        }
    }

    // Ejercicio 18: Adivinar un número aleatorio entre 1 y 20
    static void Ejercicio18()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 21);
        Console.WriteLine("He generado un número entre 1 y 20. ¡Intenta adivinarlo!");

        while (true)
        {
            Console.Write("Ingrese su intento: ");
            int intento = int.Parse(Console.ReadLine());
            if (intento < numeroAleatorio)
                Console.WriteLine("Más alto.");
            else if (intento > numeroAleatorio)
                Console.WriteLine("Más bajo.");
            else
            {
                Console.WriteLine("¡Felicidades! Has adivinado el número.");
                break;
            }
        }
    }

    // Ejercicio 19: Contar palabras de una frase
    static void Ejercicio19()
    {
        Console.Write("Ingrese una frase completa: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"La frase contiene {palabras.Length} palabras.");
    }

    // Ejercicio 20: Sumar números hasta que la suma supere 100
    static void Ejercicio20()
    {
        double suma = 0;
        while (suma <= 100)
        {
            Console.Write("Ingrese un número: ");
            suma += double.Parse(Console.ReadLine());
            Console.WriteLine($"Suma actual: {suma}");
        }
        Console.WriteLine($"La suma total es mayor a 100: {suma}");
    }

    // Menú principal
    static void Main(string[] args)
    {
        bool band = true;
        while (band)
        {
            Console.WriteLine("\nSeleccione un ejercicio para ejecutar (1-20) o 'salir' para terminar:");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":  Ejercicio1();  break;
                case "2":  Ejercicio2();  break;
                case "3":  Ejercicio3();  break;
                case "4":  Ejercicio4();  break;
                case "5":  Ejercicio5();  break;
                case "6":  Ejercicio6();  break;
                case "7":  Ejercicio7();  break;
                case "8":  Ejercicio8();  break;
                case "9":  Ejercicio9();  break;
                case "10": Ejercicio10(); break;
                case "11": Ejercicio11(); break;
                case "12": Ejercicio12(); break;
                case "13": Ejercicio13(); break;
                case "14": Ejercicio14(); break;
                case "15": Ejercicio15(); break;
                case "16": Ejercicio16(); break;
                case "17": Ejercicio17(); break;
                case "18": Ejercicio18(); break;
                case "19": Ejercicio19(); break;
                case "20": Ejercicio20(); break;
                case "salir":
                    Console.WriteLine("¡Hasta luego!");
                    band = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione un número entre 1 y 20 o 'salir'.");
                    break;
            }
        }
    }
}
