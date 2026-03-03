## Pedir números al usuario y sumarlos uno a uno. El bucle debe detenerse en el momento en que la suma total sea mayor a 100.

suma = 0

while suma <= 100:
    numero = int(input(f"Suma actual: {suma}. Ingresa un número: "))
    suma = suma + numero

print(f"Bucle terminado. La suma final es: {suma}")