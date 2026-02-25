using System.Runtime.ExceptionServices;

class Program
{

    static void Ejercicio1()
    {
        Console.WriteLine("Ingresa un número entero: ");
        int numero = int.Parse(Console.ReadLine());

        bool espositivo = numero > 0;
        bool esmultiplode5 = (numero % 5 == 0);

        if (espositivo)
        {
            Console.WriteLine("El numero cumple ambas condiciones");
            
        }
        else
        {

            if (espositivo)
            {
                Console.WriteLine("No se cumplio: El numero no es positivo");
            }
            if (esmultiplode5)
            {
                Console.WriteLine("No se cumplio: El numero no es multiplo de 5 ");
            }
        }
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();
    }


    
    static void Ejercicio2()
    {
        Console.WriteLine("Ingresa la nota (0-100): ");
        int nota = int.Parse(Console.ReadLine());

        if (nota == 100)
        {
            Console.WriteLine("Excelente" );
            Console.WriteLine("Puntaje perfecto" );
        }
        else if (nota >= 90)
        {
            Console.WriteLine("Excelente" );
        }
        else if (nota >= 70 && nota <= 89)
        {
            Console.WriteLine("Aprobado" );
        }   
        else
        {
            Console.WriteLine("Reprobado ");   
            
        }
        Console.WriteLine("Presiones una tecla para volver al menu");
        Console.ReadKey();        
    }


    static void Ejercicio3()
    {
       Console.WriteLine("Ingresa los tres ángulos del triángulo:");
        float a1 = float.Parse(Console.ReadLine());
        float a2 = float.Parse(Console.ReadLine());
        float a3 = float.Parse(Console.ReadLine());

       
        if (a1 + a2 + a3 == 180) {
            Console.WriteLine("Es un triángulo válido.");

           
            if (a1 == 90 || a2 == 90 || a3 == 90) {
                Console.WriteLine("Es un triángulo rectángulo.");
            } else {
                Console.WriteLine("No es un triángulo rectángulo.");
            }
        } else {
            Console.WriteLine("No es un triángulo válido.");
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
            Console.WriteLine("========= MENU DE EXAMEN =========");
            Console.WriteLine("1. Ejercicio 1 ");
            Console.WriteLine("2. Ejercicio 2 ");
            Console.WriteLine("3. Ejercicio 3 ");
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
                case "0":
                    continuar = false;
                    Console.WriteLine("Examen Terminado......");
                    break;
                default:
                    Console.WriteLine("OPCION INVALIDA!!!, Presiones cualquier tecla para continuar");
                    Console.ReadKey();
                    break;
            }
        }
    }
}