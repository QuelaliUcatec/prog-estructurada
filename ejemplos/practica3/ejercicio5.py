#ejercicio 5 : Leer tres números y mostrar cuál es el mayor

numero1 = int(input("Ingresa un número: "))

numero2 = int(input("Ingresa un número: "))

numero3 = int(input("Ingresa un número: "))
if numero1 < numero2 < numero3:
        print("El tercer número es el mayor de todos")
elif numero3 < numero1 < numero2:
        print("El segundo número es el mayor de todos")
elif numero3 < numero2 < numero1:
        print("El primer número es el mayor de todos")        