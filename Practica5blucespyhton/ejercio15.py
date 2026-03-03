## Leer un número entero e indicar mediante un bucle si es un número primo o no.
num = int(input("Ingresa un número: "))

es_primo = True

if num <= 1:
    es_primo = False
else:
    
    for i in range(2, num):
        if num % i == 0:
            es_primo = False
            break  

if es_primo:
    print(f"{num} es un número primo.")
else:
    print(f"{num} no es un número primo.")
