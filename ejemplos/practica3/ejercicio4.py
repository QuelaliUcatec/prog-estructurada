# Ejercicio 4: Leer dos números y mostrar cuál es mayor, o si son iguales.
numero1 = int(input("Ingresa el primer número: "))
numero2 = int(input("Ingresa el segundo número: "))
if numero1 > numero2:
    print("El primer número es mayor")
elif numero2 > numero1:
    print("El segundo número es mayor")
else:
    print("Los números son iguales")