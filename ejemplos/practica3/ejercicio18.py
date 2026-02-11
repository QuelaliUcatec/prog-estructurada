#Ingresar un número y verificar si está dentro de un rango dado.
numero = float(input("Ingresa un número: "))
rango_min = float(input("Ingresa el límite inferior del rango: "))
rango_max = float(input("Ingresa el límite superior del rango: "))
if rango_min <= numero <= rango_max:
    print("El número está dentro del rango")
else:
    print("El número no está dentro del rango")