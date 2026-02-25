using System;

class Program
{
    static void Main()
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
                
    }
}