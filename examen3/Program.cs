using System;

class Program {
    static void Main() {
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
    }
}