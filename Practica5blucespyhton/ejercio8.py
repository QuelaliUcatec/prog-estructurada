## Factorial de un número:** Leer un número entero positivo y calcular su factorial ($n!$).
n = int(input("Ingrese un número entero positivo: "))
factorial = 1
contador = 1

# Calcular el factorial usando while
while contador <= n:
    factorial *= contador
    contador += 1

print("El factorial de", n, "es:", factorial)


   