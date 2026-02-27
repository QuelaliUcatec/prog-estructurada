##Tabla de multiplicar:** Solicitar un número al usuario y mostrar su tabla de multiplicar del 1 al 10.

numero = int(input("Ingrese un número: "))

for i in range(1, 11):
    print(numero, "X",  i, "=" ,numero * i)

   