using System;

class program 
{
//Conteo ascendente:** Crear un programa que imprima los números del 1 al 10 utilizando un bucle `for`.

    static void Ejercicio1()
    {
        for (int i = 1; i <= 10; i++) 
        Console.WriteLine(i);
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Cuenta regresiva:** Crear un programa que imprima los números del 10 al 1 utilizando un bucle `while`.
    static void Ejercicio2()
    {
        int i = 10; 

        while (i >= 1) 
        {
        Console.WriteLine(i);
        i--; 
        
        }
    Console.WriteLine("Presiones una tecla para volver al menu");
    Console.ReadKey();
    }

    // Solicitar un número al usuario y mostrar su tabla de multiplicar del 1 al 10.
    static void Ejercicio3()
    {
        Console.WriteLine("¿De qué número quieres la tabla?: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"--- Tabla del {numero} ---");

        for (int i = 1; i <= 10; i++)
        {
        // Calculamos el resultado en cada vuelta
        int resultado = numero * i;
        
        // Mostramos la operación: "numero x i = resultado"
        Console.WriteLine($"{numero} x {i} = {resultado}");
        }
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Calcular la suma de los primeros 10 números naturales (del 1 al 10) y mostrar el resultado final
    static void Ejercicio4()
    {
        int suma = 0; // Nuestra "alcancía"

        for (int i = 1; i <= 10; i++)
        {
        suma = suma + i; // Sumamos el valor actual de i al total
        }

    Console.WriteLine($"La suma de los números del 1 al 10 es: {suma}");
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Mostrar todos los números del 1 al 30 que sean divisibles por 3.
    static void Ejercicio5()
    {
        for (int i = 1; i <= 30; i++)
        {
        if (i % 3 == 0)
        Console.WriteLine(i);
        }
        
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Imprimir todos los números pares que se encuentran entre el 1 y el 50.
    static void Ejercicio6()
    {
        for (int i = 1; i <= 50; i++)
        {
        if (i % 2 == 0)
        Console.WriteLine(i);
        }
        
    Console.WriteLine("Presiones una tecla para volver al menu");
    Console.ReadKey();
    }

    // Suma de pares acumulada:** Calcular y mostrar la suma de todos los números pares entre 1 y 100.
    static void Ejercicio7()
    {
        int sumaPares = 0; // Nuestra variable acumuladora

    // Empezamos en 2 y sumamos de 2 en 2 hasta 100
        for (int i = 2; i <= 100; i += 2)
        {
        sumaPares += i; // Sumamos el número actual al total
        }
    Console.WriteLine($"La suma de los números pares del 1 al 100 es: {sumaPares}");
    Console.WriteLine("Presiones una tecla para volver al menu");
    Console.ReadKey();
    }

    // Factorial de un número:** Leer un número entero positivo y calcular su factorial ($n!$).
    static void Ejercicio8()
    {
        Console.Write("Ingresa un número para calcular su factorial: ");
        int n = int.Parse(Console.ReadLine());

        long factorial = 1; // Usamos 'long' porque los factoriales crecen muy rápido

        for (int i = 1; i <= n; i++)
        {
        factorial *= i; // Es lo mismo que: factorial = factorial * i
        }

    Console.WriteLine($"El factorial de {n} es: {factorial}");
    Console.WriteLine("Presiones una tecla para volver al menu");
    Console.ReadKey();
    }

    // Pedir al usuario que ingrese una palabra y contar cuántas vocales tiene (a, e, i, o, u).
    static void Ejercicio9()
    {
        Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine().ToLower(); // Lo pasamos a minúsculas para comparar fácil

        int contadorVocales = 0;

        // Recorremos cada letra de la palabra
        foreach (char letra in palabra)
        {
        // Verificamos si la letra es una vocal
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
        {
            contadorVocales++;
        }
        }

    Console.WriteLine($"La palabra tiene {contadorVocales} vocales.");
    Console.WriteLine("Presiones una tecla para volver al menu");
    Console.ReadKey();
    }

    // Solicitar al usuario 5 notas, sumarlas y mostrar el promedio final.
    static void Ejercicio10()
    {
        double sumaNotas = 0; // Usamos double para permitir decimales

        for (int i = 1; i <= 5; i++)
        {
        Console.Write($"Ingresa la nota #{i}: ");
        double nota = double.Parse(Console.ReadLine());
        
        sumaNotas += nota; // Vamos acumulando las notas
        }

    double promedio = sumaNotas / 5;

    Console.WriteLine($"La suma total es: {sumaNotas}");
    Console.WriteLine($"El promedio final es: {promedio}");
    Console.WriteLine("Presiones una tecla para volver al menu");
    Console.ReadKey();
    }

    // Pedir una cadena de texto y mostrar sus caracteres uno por uno en orden inverso.
    static void Ejercicio11()
    {
        Console.Write("Ingresa un texto: ");
        string texto = Console.ReadLine();


        for (int i = texto.Length - 1; i >= 0; i--)
        {
        Console.WriteLine(texto[i]);
        }
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Pedir una cadena de texto y mostrar sus caracteres uno por uno en orden inverso.
    static void Ejercicio12()
    {
        List<int> numeros = new List<int> { 5, 12, 18, 24, 30, 42, 55, 61, 70, 88 };

        Console.Write("Introduce un número para buscarlo en la lista: ");
        int valorUsuario = int.Parse(Console.ReadLine());

        // 2. Buscamos el índice
        int indice = numeros.IndexOf(valorUsuario);

        // 3. Verificamos si existe (si no existe, IndexOf devuelve -1)
        if (indice != -1)
        {
        Console.WriteLine($"El número {valorUsuario} se encuentra en el índice {indice}.");
        }
        else
        {
        Console.WriteLine("El número no está en la lista.");
        }
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Pedir una contraseña al usuario. El programa no debe terminar hasta que el usuario ingrese la clave correcta (ejemplo: "python123").
    static void Ejercicio13()
    {
        string claveCorrecta = "python123";
        string intento = ""; // Variable para guardar lo que escribe el usuario

        // "Mientras el intento SEA DIFERENTE a la clave correcta..."
        while (intento != claveCorrecta)
        {
            Console.Write("Introduce la contraseña: ");
            intento = Console.ReadLine();

            if (intento != claveCorrecta)
            {
                Console.WriteLine(" Clave incorrecta. Inténtalo de nuevo.");
            }
            
        }
        Console.WriteLine("¡Acceso concedido!");

        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Generar y mostrar los primeros 10 números de la sucesión de Fibonacci ($0, 1, 1, 2, 3, 5, 8, \dots$).
    static void Ejercicio14()
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(a); // Mostramos el número actual
            
            int suma = a + b;     // Calculamos el que sigue
            a = b;                // El segundo pasa al primero
            b = suma;             // El nuevo pasa al segundo
        }
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // GLeer un número entero e indicar mediante un bucle si es un número primo o no.
    static void Ejercicio15()
    {
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());
        
        bool esPrimo = true; // Suponemos que es primo hasta que se demuestre lo contrario

        if (numero < 2) esPrimo = false; // Los números menores a 2 no son primos

        // Probamos dividir desde el 2 hasta el número anterior
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                esPrimo = false; // Encontramos un divisor, ya no es primo
                break;           // Salimos del bucle para ahorrar tiempo
            }
        }

        if (esPrimo)
            Console.WriteLine($"{numero} es un número primo.");
        else
            Console.WriteLine($"{numero} no es un número primo.");

        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Pedir un número $N$ y dibujar un triángulo de asteriscos `*` con una altura de $N$ líneas.
    static void Ejercicio16()
    {
        Console.Write(" Ingresar Altura: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
        // Escribe i cantidad de asteriscos en la misma línea
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        
        // Salto de línea para pasar a la siguiente fila
        Console.WriteLine();
        }
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Crear un menú que se repita hasta que el usuario elija la opción "Salir". Opciones: 1. Ver saldo, 2. Retirar, 3. Salir.
    static void Ejercicio17()
    {
        int opcion = 0;

        while (opcion != 3) // El bucle sigue mientras la opción no sea 3 (Salir)
        {
        Console.WriteLine("\n--- MENÚ CAJERO ---");
        Console.WriteLine("1. Ver saldo");
        Console.WriteLine("2. Retirar");
        Console.WriteLine("3. Salir");
        Console.Write("Elija una opción: ");
        
        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.WriteLine("Su saldo es: $1000");
        }
        else if (opcion == 2)
        {
            Console.WriteLine("Retiro exitoso.");
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Saliendo del programa...");
        }
        else
        {
            Console.WriteLine("Opción no válida, intente de nuevo.");
        }
        }
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }


    // El programa genera un número aleatorio entre 1 y 20. El usuario debe intentar adivinarlo; el programa dará pistas ("más alto" o "más bajo") hasta que acierte
    static void Ejercicio18()
    {
        int secreto = new Random().Next(1, 21);
        int intento = 0;

        Console.WriteLine("Adivina el número (1-20):");

        while (intento != secreto)
        {
            intento = int.Parse(Console.ReadLine());

            if (intento < secreto) Console.WriteLine("Más alto");
            else if (intento > secreto) Console.WriteLine("Más bajo");
            
        }
        Console.WriteLine("¡Ganaste!");
        
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }


    // Pedir una frase completa y contar cuántas palabras contiene (asumiendo que están separadas por espacios).

    static void Ejercicio19()
    {
        Console.Write("Escribe: ");
        string[] palabras = Console.ReadLine().Split(' ');

        Console.WriteLine("Palabras: " + palabras.Length);
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }

    // Pedir números al usuario y sumarlos uno a uno. El bucle debe detenerse en el momento en que la suma total sea mayor a 100.

    static void Ejercicio20()
    {
    int suma = 0;

        while (suma <= 100)
        {
        Console.Write("Introduce un número: ");
        suma += int.Parse(Console.ReadLine());
        
        Console.WriteLine("Suma actual: " + suma);
        }

        Console.WriteLine("¡Límite superado!");
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
                Console.WriteLine("1. Ejercicio 1: ");
                Console.WriteLine("2. Ejercicio 2: ");
                Console.WriteLine("3. Ejercicio 3: ");
                Console.WriteLine("4. Ejercicio 4: ");
                Console.WriteLine("5. Ejercicio 5: ");
                Console.WriteLine("6. Ejercicio 6: ");
                Console.WriteLine("7. Ejercicio 7: ");
                Console.WriteLine("8. Ejercicio 8: ");
                Console.WriteLine("9. Ejercicio 9: ");
                Console.WriteLine("10. Ejercicio 10: ");
                Console.WriteLine("11. Ejercicio 11: ");
                Console.WriteLine("12. Ejercicio 12: ");
                Console.WriteLine("13. Ejercicio 13: ");
                Console.WriteLine("14. Ejercicio 14: ");
                Console.WriteLine("15. Ejercicio 15: ");
                Console.WriteLine("16. Ejercicio 16: ");
                Console.WriteLine("17. Ejercicio 17: ");
                Console.WriteLine("18. Ejercicio 18: ");
                Console.WriteLine("19. Ejercicio 19: ");
                Console.WriteLine("20. Ejercicio 20: ");           
                Console.WriteLine("0. SALIR !!! ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Ejercicio1();
                        break;
                    case "2":
                        Ejercicio2();
                        break;
                    case "3":
                        Ejercicio3();
                        break;
                    case "4":
                        Ejercicio4();
                        break;
                    case "5":
                        Ejercicio5();
                        break;
                    case "6":
                        Ejercicio6();
                        break;
                    case "7":
                        Ejercicio7();
                        break;
                    case "8":
                        Ejercicio8();
                        break;
                    case "9":
                        Ejercicio9();
                        break;
                    case "10":
                        Ejercicio10();
                        break;
                    case "11":
                        Ejercicio11();
                        break;
                    case "12":
                        Ejercicio12();
                        break;
                    case "13":
                        Ejercicio13();
                        break;
                    case "14":
                        Ejercicio14();
                        break;
                    case "15":
                        Ejercicio15();
                        break;
                    case "16":
                        Ejercicio16();
                        break;
                    case "17":
                        Ejercicio17();
                        break;
                    case "18":
                        Ejercicio18();
                        break;
                    case "19":
                        Ejercicio19();
                        break;
                    case "20":
                        Ejercicio20();
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