# Crear un programa que imprima los números del 1 al 10 utilizando un bucle `for`.
def ejercicio1():
    for i in range(1, 11):
        print(i)

#Crear un programa que imprima los números del 10 al 1 utilizando un bucle `while`.
def ejercicio2():
    i = 10
    while i >= 1:
        print(i)
        i -= 1

#Calcular la suma de los primeros 10 números naturales (del 1 al 10) y mostrar el resultado final.
def ejercicio3():
    suma = 0
    for i in range(1, 11):
        suma += i
    print("La suma de los primeros 10 números naturales es:", suma)

#Solicitar un número al usuario y mostrar su tabla de multiplicar del 1 al 10.
def ejercicio4():
    numero = int(input("Ingrese un número para mostrar su tabla de multiplicar: "))
    print(f"Tabla de multiplicar del {numero}:")
    for i in range(1, 11):
        print(f"{numero} x {i} = {numero * i}")

#Imprimir todos los números pares que se encuentran entre el 1 y el 50.
def ejercicio5():
    print("Números pares entre 1 y 50:")
    for i in range(2, 51, 2):
        print(i)

#Mostrar todos los números del 1 al 30 que sean divisibles por 3.
def ejercicio6():
    print("Números divisibles por 3 entre 1 y 30:")
    for i in range(1, 31):
        if i % 3 == 0:
            print(i)

#Calcular y mostrar la suma de todos los números pares entre 1 y 100.
def ejercicio7():
    suma = 0
    for i in range(2, 101, 2):
        suma += i
    print("La suma de todos los números pares entre 1 y 100 es:", suma)

#Leer un número entero positivo y calcular su factorial ($n!$).
def ejercicio8():
    numero = int(input("Ingrese un número entero positivo para calcular su factorial: "))
    factorial = 1
    for i in range(1, numero + 1):
        factorial *= i
    print(f"El factorial de {numero} es: {factorial}")

#Pedir al usuario que ingrese una palabra y contar cuántas vocales tiene (a, e, i, o, u).
def ejercicio9():
    palabra = input("Ingrese una palabra: ")
    vocales = "aeiouAEIOU"
    contador = 0
    for letra in palabra:
        if letra in vocales:
            contador += 1
    print(f"La palabra '{palabra}' tiene {contador} vocales.")

#Solicitar al usuario 5 notas, sumarlas y mostrar el promedio final.
def ejercicio10():
    suma = 0
    for i in range(5):
        nota = float(input(f"Ingrese la nota {i+1}: "))
        suma += nota
    promedio = suma / 5
    print(f"El promedio de las notas es: {promedio}")

#Pedir una cadena de texto y mostrar sus caracteres uno por uno en orden inverso.
def ejercicio11():
    cadena = input("Ingrese una cadena de texto: ")
    print("Caracteres en orden inverso:")
    for i in range(len(cadena) - 1, -1, -1):
        print(cadena[i])

#Crear una lista con 10 números predefinidos. Pedir al usuario un valor y decirle si se encuentra en la lista y en qué índice.
def ejercicio12():
    lista = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
    valor = int(input("Ingrese un valor para buscar en la lista: "))
    encontrado = False
    for i in range(len(lista)):
        if lista[i] == valor:
            print(f"El valor {valor} se encuentra en la lista en el índice {i}")
            encontrado = True
            break
    if not encontrado:
        print(f"El valor {valor} no se encuentra en la lista")

#Pedir una contraseña al usuario. El programa no debe terminar hasta que el usuario ingrese la clave correcta (ejemplo: "python123").
def ejercicio13():
    clave_correcta = "python123"
    while True:
        clave = input("Ingrese la contraseña: ")
        if clave == clave_correcta:
            print("Contraseña correcta. Acceso permitido.")
            break
        else:
            print("Contraseña incorrecta. Inténtelo de nuevo.")

#Generar y mostrar los primeros 10 números de la sucesión de Fibonacci ($0, 1, 1, 2, 3, 5, 8, \dots$).
def ejercicio14():
    a, b = 0, 1
    print("Primeros 10 números de la sucesión de Fibonacci:")
    for i in range(10):
        print(a, end=" ")
        a, b = b, a + b

#Leer un número entero e indicar mediante un bucle si es un número primo o no.
def ejercicio15():
    numero = int(input("Ingrese un número entero: "))
    es_primo = True
    if numero < 2:
        es_primo = False
    else:
        for i in range(2, int(numero ** 0.5) + 1):
            if numero % i == 0:
                es_primo = False
                break
    if es_primo:
        print(f"El número {numero} es primo.")
    else:
        print(f"El número {numero} no es primo.")

#Pedir un número $N$ y dibujar un triángulo de asteriscos `*` con una altura de $N$ líneas.
def ejercicio16():
    N = int(input("Ingrese la altura del triángulo de asteriscos: "))
    for i in range(1, N + 1):
        print("*" * i)

#Crear un menú que se repita hasta que el usuario elija la opción "Salir". Opciones: 1. Ver saldo, 2. Retirar, 3. Salir.
def ejercicio17():
    saldo = 1000  # Saldo inicial
    while True:
        print("\nMenú:")
        print("1. Ver saldo")
        print("2. Retirar")
        print("3. Salir")
        opcion = input("Seleccione una opción: ")
        
        if opcion == "1":
            print(f"Su saldo actual es: ${saldo}")
        elif opcion == "2":
            monto = float(input("Ingrese el monto a retirar: "))
            if monto > saldo:
                print("Saldo insuficiente.")
            else:
                saldo -= monto
                print(f"Retiro exitoso. Su nuevo saldo es: ${saldo}")
        elif opcion == "3":
            print("Gracias por usar el programa. ¡Hasta luego!")
            break
        else:
            print("Opción no válida. Por favor, seleccione una opción del menú.")

#El programa genera un número aleatorio entre 1 y 20. El usuario debe intentar adivinarlo; el programa dará pistas ("más alto" o "más bajo") hasta que acierte.
import random
def ejercicio18():
    numero_aleatorio = random.randint(1, 20)
    print("He generado un número entre 1 y 20. ¡Intenta adivinarlo!")
    
    while True:
        intento = int(input("Ingrese su intento: "))
        if intento < numero_aleatorio:
            print("Más alto.")
        elif intento > numero_aleatorio:
            print("Más bajo.")
        else:
            print("¡Felicidades! Has adivinado el número.")
            break

#Pedir una frase completa y contar cuántas palabras contiene (asumiendo que están separadas por espacios).
def ejercicio19():
    frase = input("Ingrese una frase completa: ")
    palabras = frase.split()
    print(f"La frase contiene {len(palabras)} palabras.")

#Pedir números al usuario y sumarlos uno a uno. El bucle debe detenerse en el momento en que la suma total sea mayor a 100.
def ejercicio20():
    suma = 0
    while suma <= 100:
        numero = float(input("Ingrese un número: "))
        suma += numero
        print(f"Suma actual: {suma}")
    print(f"La suma total es mayor a 100: {suma}")

band = True
while band:
    print("\nSeleccione un ejercicio para ejecutar (1-20) o 'salir' para terminar:")
    opcion = input("Opción: ")
    
    if opcion == "1":
        ejercicio1()
    elif opcion == "2":
        ejercicio2()
    elif opcion == "3":
        ejercicio3()
    elif opcion == "4":
        ejercicio4()
    elif opcion == "5":
        ejercicio5()
    elif opcion == "6":
        ejercicio6()
    elif opcion == "7":
        ejercicio7()
    elif opcion == "8":
        ejercicio8()
    elif opcion == "9":
        ejercicio9()
    elif opcion == "10":
        ejercicio10()
    elif opcion == "11":
        ejercicio11()
    elif opcion == "12":
        ejercicio12()
    elif opcion == "13":
        ejercicio13()
    elif opcion == "14":
        ejercicio14()
    elif opcion == "15":
        ejercicio15()
    elif opcion == "16":
        ejercicio16()
    elif opcion == "17":
        ejercicio17()
    elif opcion == "18":
        ejercicio18()
    elif opcion == "19":
        ejercicio19()
    elif opcion == "20":
        ejercicio20()
    elif opcion.lower() == "salir":
        print("¡Hasta luego!")
        band = False
    else:
        print("Opción no válida. Por favor, seleccione un número entre 1 y 20 o 'salir'.")
        