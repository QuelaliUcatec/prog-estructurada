class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("La suma es: " + (num1 + num2));
    }
}