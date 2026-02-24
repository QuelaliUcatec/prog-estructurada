# 1. Calculadora básica con operaciones múltiples
def Ejemplo():

    num1 = 4
    num2 = 5

    resultado = num1 + num2

    print(f"La suma del numero1 {num1} y el numero2 {num2} tiene como resultado el valor de {resultado}")

# Ejercicio 1: Verificar si un numero es par o impar
def Ejercicio1():
    numero = int(input("Ingresa un número: "))

    if numero > 0:
        print("El número es positivo")
    elif numero < 0:
        print("El número es negativo")
    else:
        print("El número es cero")
    
#ejercicio 2 : verificar si es un número es par o impar
def Ejercicio2():
    numero = int(input("Ingresa un número: "))
    if numero % 2 == 0:
        print("El número es par")
    else:
        print("El número es impar")

Ejercicio2() 
