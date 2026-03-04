//Conteo ascendente:** Crear un programa que imprima los números del 1 al 10 utilizando un bucle `for`.

static void Ejercicio1()
{
    for (int i = 1; i <= 10; i++) 
    Console.WriteLine(i);
}

// Cuenta regresiva:** Crear un programa que imprima los números del 10 al 1 utilizando un bucle `while`.
static void Ejercicio2()
{
    int i = 10; 

while (i >= 1) 

    Console.WriteLine(i);
    i--; 
}

// Solicitar un número al usuario y mostrar su tabla de multiplicar del 1 al 10.
static void Ejercicio3()
{
    Console.Write("¿De qué número quieres la tabla?: ");
    int numero = int.Parse(Console.ReadLine());

    Console.WriteLine($"--- Tabla del {numero} ---");

    for (int i = 1; i <= 10; i++)
    {
    // Calculamos el resultado en cada vuelta
    int resultado = numero * i;
    
    // Mostramos la operación: "numero x i = resultado"
    Console.WriteLine($"{numero} x {i} = {resultado}");
    }
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
}

// Mostrar todos los números del 1 al 30 que sean divisibles por 3.
static void Ejercicio5()
{
    for (int i = 1; i <= 30; i++)
    {
        if (i % 3 == 0);
    }

Console.WriteLine(i);
}

// Imprimir todos los números pares que se encuentran entre el 1 y el 50.
static void Ejercicio6()
{
    for (int i = 1; i <= 50; i++)
    {
        if (i % 2 == 0);
    }

Console.WriteLine(i);
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
    
        else;
        
    Console.WriteLine("¡Acceso concedido!");
    }
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
}