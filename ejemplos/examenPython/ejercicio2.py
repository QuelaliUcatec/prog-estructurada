# Escribe un programa que solicite los tres ángulos de un triángulo. 
# Primero, debe verificar si los ángulos suman 180° (para saber si es un triángulo válido). 
# Si es válido, debe indicar si es un triángulo rectángulo (si tiene un ángulo de 90°) o si no lo es.

def ejercicio2():
    angulo1 = float(input("Ingresa el primer ángulo del triángulo: "))
    angulo2 = float(input("Ingresa el segundo ángulo del triángulo: "))
    angulo3 = float(input("Ingresa el tercer ángulo del triángulo: "))

    suma_angulos = angulo1 + angulo2 + angulo3

    if suma_angulos == 180:
        print("Los ángulos forman un triángulo válido.")
        if angulo1 == 90 or angulo2 == 90 or angulo3 == 90:
            print("El triángulo es rectángulo.")
        else:
            print("El triángulo no es rectángulo.")
    else:
        print("Los ángulos no suman 180°, no forman un triángulo válido.")