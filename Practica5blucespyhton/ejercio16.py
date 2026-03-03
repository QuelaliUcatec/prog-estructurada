## Pedir un número $N$ y dibujar un triángulo de asteriscos `*` con una altura de $N$ líneas.

n = int(input("Introduce la altura del triángulo: "))

for i in range(1, n + 1):
    print("*" * i)