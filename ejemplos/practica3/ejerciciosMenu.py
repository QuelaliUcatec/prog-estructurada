def ejercicio1():
    numero = int(input("Ingresa un número: "))

    if numero > 0:
        print("El número es positivo")
    elif numero < 0:
        print("El número es negativo")
    else:
        print("El número es cero")

# Ejercicio 2: Verificar si un número es par o impar
def ejercicio2():
    
    numero = int(input("Ingresa un número: "))
    if numero % 2 == 0:
        print("El número es par")
    else:
        print("El número es impar")

# Ejercicio 3: Ingresar la edad de una persona y mostrar si es mayor o menor de edad.
def ejercicio3():
    edad = int(input("Ingresa la edad de la persona: "))
    if edad >= 18:
        print("La persona es mayor de edad")
    else:
        print("La persona es menor de edad")

# Ejercicio 4: Leer dos números y mostrar cuál es mayor, o si son iguales.
def ejercicio4():
    numero1 = int(input("Ingresa el primer número: "))
    numero2 = int(input("Ingresa el segundo número: "))
    if numero1 > numero2:
        print("El primer número es mayor")
    elif numero2 > numero1:
        print("El segundo número es mayor")
    else:
        print("Los números son iguales")

bandera = True

while bandera:
    
    print("Menú de ejercicios:")
    print("1. Verificar si un número es positivo, negativo o cero")
    print("2. Verificar si un número es par o impar")
    print("3. Ingresar la edad de una persona y mostrar si es mayor o menor de edad")
    print("4. Leer dos números y mostrar cuál es mayor, o si son iguales")
    print("5. Salir")

    opcion = int(input("Selecciona una opción (1-5): "))

    match opcion:
        case 1:
            ejercicio1()
        case 2:
            ejercicio2()
        case 3:
            ejercicio3()
        case 4:
            ejercicio4()
        case 5:
            bandera = False
            print("Saliendo del programa...")
        case _:
            print("Opción no válida, por favor selecciona una opción del 1 al 5.")