# Crea un programa que lea un número entero. 
# El programa debe decir si el número cumple ambas condiciones: 
# ser un número positivo y ser múltiplo de 5. Si no cumple alguna, debe indicar cuál no se cumplió.

def ejercicio1():
    numero = int(input("Ingresa un número entero: "))
    if numero > 0 and numero % 5 == 0:
        print("El número es positivo y múltiplo de 5")
    else:
        if numero <= 0:
            print("El número no es positivo")
        if numero % 5 != 0:
            print("El número no es múltiplo de 5")