class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine()?? "0");
        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine()?? "0");
        int resultado = num1 + num2;   
        Console.WriteLine($"La suma es {resultado}");
    }
}