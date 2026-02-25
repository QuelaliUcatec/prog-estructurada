numero = int(input("Ingresa un numero entero: "))

es_positivo = numero > 0
es_multiplo_de_5 = (numero % 5 == 0)

if es_positivo and es_multiplo_de_5:
    print("El numero cumple ambas condiciones: es positivo y multiplo de 5 ")

if not es_positivo:
    print("No se cumplio: El numero no es positivo ")

if not es_multiplo_de_5:
    print("El numero no es multiplo de 5 ")
    