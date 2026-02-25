using System;

class Program
{
    static void Main()
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
    }
}