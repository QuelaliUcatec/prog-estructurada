#Leer tres números y mostrar cuál es el mayor.
numero1 = int(input("Ingresa el primer número: "))
numero2 = int(input("Ingresa el segundo número: "))
numero3 = int(input("Ingresa el tercer número: "))
if numero1 > numero2 and numero1 > numero3:
    print("El primer número es mayor")
elif numero2 > numero1 and numero2 > numero3:
    print("El segundo número es mayor")
elif numero3 > numero1 and numero3 > numero2:
    print("El tercer número es mayor")
else:
    print("Los números son iguales")