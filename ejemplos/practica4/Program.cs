class Program
{
    static void Ejercicio1()
    {
        // Ejercicio 1: Suma de dos números
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("La suma es: " + (num1 + num2));
    }

    static void Ejercicio2()
    {   
        // Ejercicio 2: Verificar si un número es par o impar
        Console.WriteLine("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }
    }

    static void Ejercicio3()
    {
        // Ejercicio 3: Ingresar la edad de una persona y mostrar si es mayor o menor de edad.
        Console.WriteLine("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());
        if (edad >= 18)
        {
            Console.WriteLine("Es mayor de edad");
        }
        else
        {
            Console.WriteLine("Es menor de edad");
        }
    }

    static void Ejercicio4()
    {
        // Ejercicio 4: Leer dos números y mostrar cuál es mayor, o si son iguales.
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine("El primer numero es mayor");
        }
        else if (num2 > num1)
        {
            Console.WriteLine("El segundo numero es mayor");
        }
        else
        {
            Console.WriteLine("Los numeros son iguales");
        }
    }

    static void Ejercicio5()
    {
        // Leer tres números y mostrar cuál es el mayor.
        Console.WriteLine("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer numero: ");
        int num3 = int.Parse(Console.ReadLine());
        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("El primer numero es mayor");
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("El segundo numero es mayor");
        }
        else if (num3 > num1 && num3 > num2)
        {
            Console.WriteLine("El tercer numero es mayor");
        }
    }

    static void Ejercicio6()
    {
        // Ingresar una nota (0–100) y mostrar si el estudiante aprueba o reprueba.
        Console.WriteLine("Ingrese la nota: ");
        int nota = int.Parse(Console.ReadLine());
        if (nota >= 60)
        {
            Console.WriteLine("El estudiante aprueba");
        }
        else
        {
            Console.WriteLine("El estudiante reprueba");
        }
    }

    static void Ejercicio7()
    {
        // Leer una nota (0–100) y clasificarla como Excelente, Bueno, Regular o Reprobado.
        Console.WriteLine("Ingrese la nota: ");
        int nota = int.Parse(Console.ReadLine());
        if (nota >= 90)
        {
            Console.WriteLine("Excelente");
        }
        else if (nota >= 70)
        {
            Console.WriteLine("Bueno");
        }
        else if (nota >= 60)
        {
            Console.WriteLine("Regular");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }

    static void Ejercicio8()
    {
        // Ingresar el precio de una compra y aplicar un descuento del 10% si supera cierto monto.
        Console.WriteLine("Ingrese el precio de la compra: ");
        double precio = double.Parse(Console.ReadLine());
        if (precio > 100)
        {
            double descuento = precio * 0.1;
            double precioFinal = precio - descuento;
            Console.WriteLine("Precio final con descuento: " + precioFinal);
        }
        else
        {
            Console.WriteLine("Precio final sin descuento: " + precio);
        }
    }

    static void Ejercicio9()
    {
        // Leer un número y verificar si es múltiplo de 5.
        Console.WriteLine("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 5 == 0)
        {
            Console.WriteLine("El numero es multiplo de 5");
        }
        else
        {
            Console.WriteLine("El numero no es multiplo de 5");
        }
    }

    static void Ejercicio10()
    {
        // Ingresar un año y determinar si es bisiesto.
        Console.WriteLine("Ingrese un año: ");
        int año = int.Parse(Console.ReadLine());
        if (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0))
        {
            Console.WriteLine("El año es bisiesto");
        }
        else
        {
            Console.WriteLine("El año no es bisiesto");
        }
    }

    static void Ejercicio11()
    {
        // Leer el número de un mes (1–12) y mostrar cuántos días tiene.
        Console.WriteLine("Ingrese el numero del mes: ");
        int mes = int.Parse(Console.ReadLine());
        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
        {
            Console.WriteLine("El mes tiene 31 días");
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            Console.WriteLine("El mes tiene 30 días");
        }
        else if (mes == 2)
        {
            Console.WriteLine("El mes tiene 28  (o 29 en años bisiestos)");
        }
        else
        {
            Console.WriteLine("Número de mes inválido");
        }
    }

    static void Ejercicio12()
    {
        // Ingresar un número del 1 al 7 y mostrar el día de la semana correspondiente.
        Console.WriteLine("Ingrese un numero del 1 al 7: ");
        int dia = int.Parse(Console.ReadLine());
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            case 6:
                Console.WriteLine("Sábado");
                break;
            case 7:
                Console.WriteLine("Domingo");
                break;
            default:
                Console.WriteLine("Número inválido");
                break;
        }
    }

    static void Ejercicio13()
    {
        // Leer la hora del día (0–23) y mostrar si es mañana, tarde o noche.
        Console.WriteLine("Ingrese la hora del día (0-23): ");
        int hora = int.Parse(Console.ReadLine());
        if (hora >= 6 && hora < 12)
        {
            Console.WriteLine("Es mañana");
        }
        else if (hora >= 12 && hora < 18)
        {
            Console.WriteLine("Es tarde");
        }
        else
        {
            Console.WriteLine("Es noche");
        }
    }

    static void Ejercicio14()
    {
        // Ingresar dos lados de un rectángulo y determinar si es un cuadrado.
        Console.WriteLine("Ingrese el primer lado del rectángulo: ");
        double lado1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo lado del rectángulo: ");
        double lado2 = double.Parse(Console.ReadLine());
        if (lado1 == lado2)
        {
            Console.WriteLine("Es un cuadrado");
        }
        else
        {
            Console.WriteLine("No es un cuadrado");
        }
    }

    static void Ejercicio15()
    {
        // Leer la temperatura y mostrar si hace frío, templado o calor.
        Console.WriteLine("Ingrese la temperatura: ");
        double temperatura = double.Parse(Console.ReadLine());
        if (temperatura < 10)
        {
            Console.WriteLine("Hace frío");
        }
        else if (temperatura >= 10 && temperatura < 25)
        {
            Console.WriteLine("Hace templado");
        }
        else
        {
            Console.WriteLine("Hace calor");
        }
    }

    static void Ejercicio16()
    {
        // Ingresar el sexo de una persona (M/F) y mostrar un mensaje correspondiente.
        Console.WriteLine("Ingrese el sexo (M/F): ");
        char sexo = char.Parse(Console.ReadLine().ToUpper());
        if (sexo == 'M')
        {
            Console.WriteLine("Es un hombre");
        }
        else if (sexo == 'F')
        {
            Console.WriteLine("Es una mujer");
        }
        else
        {
            Console.WriteLine("Sexo inválido");
        }
    }

    static void Ejercicio17()
    {
        // Leer el total de una compra y determinar si obtiene envío gratis según el monto.
        Console.WriteLine("Ingrese el total de la compra: ");
        double total = double.Parse(Console.ReadLine());
        if (total >= 100)
        {
            Console.WriteLine("Obtiene envío gratis");
        }
        else
        {
            Console.WriteLine("No obtiene envío gratis");
        }
    }

    static void Ejercicio18()
    {
        // Ingresar un número y verificar si está dentro de un rango dado.
        Console.WriteLine("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el rango inferior: ");
        int rangoInferior = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el rango superior: ");
        int rangoSuperior = int.Parse(Console.ReadLine());
        if (num >= rangoInferior && num <= rangoSuperior)
        {
            Console.WriteLine("El número está dentro del rango");
        }
        else
        {
            Console.WriteLine("El número no está dentro del rango");
        }
    }

    static void Ejercicio19()
    {
        // Leer la cantidad de respuestas correctas de un examen y determinar el nivel de desempeño.
        Console.WriteLine("Ingrese la cantidad de respuestas correctas: ");
        int respuestasCorrectas = int.Parse(Console.ReadLine());
        if (respuestasCorrectas >= 0 && respuestasCorrectas <= 10)
        {
            Console.WriteLine("Nivel de desempeño: Bajo");
        }
        else if (respuestasCorrectas > 10 && respuestasCorrectas <= 20)
        {
            Console.WriteLine("Nivel de desempeño: Medio");
        }
        else if (respuestasCorrectas > 20 && respuestasCorrectas <= 30)
        {
            Console.WriteLine("Nivel de desempeño: Alto");
        }
        else
        {
            Console.WriteLine("Cantidad de respuestas incorrecta");
        }
    }

    static void Ejercicio20()
    {
        // Ingresar tres ángulos y determinar si pueden formar un triángulo.
        Console.WriteLine("Ingrese el primer ángulo: ");
        int angulo1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo ángulo: ");
        int angulo2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer ángulo: ");
        int angulo3 = int.Parse(Console.ReadLine());
        if (angulo1 + angulo2 + angulo3 == 180)
        {
            Console.WriteLine("Los ángulos pueden formar un triángulo");
        }
        else
        {
            Console.WriteLine("Los ángulos no pueden formar un triángulo");
        }
    }

    static void Main(string[] args)
    {
        Ejercicio1();
        Ejercicio2();
        Ejercicio3();
        Ejercicio4();
        Ejercicio5();
        Ejercicio6();
        Ejercicio7();
        Ejercicio8();
        Ejercicio9();
        Ejercicio10();
        Ejercicio11();
        Ejercicio12();
        Ejercicio13();
        Ejercicio14();
        Ejercicio15();
        Ejercicio16();
        Ejercicio17();
        Ejercicio18();
        Ejercicio19();
        Ejercicio20();
    }
}