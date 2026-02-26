def ejercicio1():
    numero = int(input("Ingresa un número entero: "))
    if numero > 0 and numero % 5 == 0:
        print("El número es positivo y múltiplo de 5")
    else:
        if numero <= 0:
            print("El número no es positivo")
        if numero % 5 != 0:
            print("El número no es múltiplo de 5")

def ejercicio2():
    angulo1 = float(input("Ingresa el primer ángulo del triángulo: "))
    angulo2 = float(input("Ingresa el segundo ángulo del triángulo: "))
    angulo3 = float(input("Ingresa el tercer ángulo del triángulo: "))

    suma_angulos = angulo1 + angulo2 + angulo3

    if suma_angulos == 180:
        print("Los ángulos forman un triángulo válido.")
        if angulo1 == 90 or angulo2 == 90 or angulo3 == 90:
            print("El triángulo es rectángulo.")
        else:
            print("El triángulo no es rectángulo.")
    else:
        print("Los ángulos no suman 180°, no forman un triángulo válido.")

def ejercicio3():
    nota = float(input("Ingresa la nota del estudiante (0-100): "))

    if nota >= 90:
        print("Excelente")
        if nota == 100:
            print("¡Felicidades, puntaje perfecto!")
    elif 70 <= nota < 90:
        print("Aprobado")
    else:
        print("Reprobado")

band = True

while band:
    print("Menú de ejercicios:")
    print("1. Verificar si un número es positivo y múltiplo de 5")
    print("2. Verificar si los ángulos forman un triángulo válido y si es rectángulo")
    print("3. Evaluar la nota de un estudiante")
    print("4. Salir")

    opcion = int(input("Selecciona una opción (1-4): "))

    match opcion:
        case 1:
            ejercicio1()
        case 2:
            ejercicio2()
        case 3:
            ejercicio3()
        case 4:
            band = False
            print("Saliendo del programa...")
