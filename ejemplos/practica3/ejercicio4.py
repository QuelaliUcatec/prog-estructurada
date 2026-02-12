#ejercicio 4 : Leer dos números y mostrar cuál es mayor, o si son iguales

numero1 = int(input("Ingresa un número: "))

numero2 = int(input("Ingresa un número: "))

if numero1 < numero2:
    print("El segundo número es mayor que el primero")
if numero2 < numero1:
    print("El primer número es mayor que el segundo")
elif numero1 == numero2:
    print("Los dos números son iguales")
