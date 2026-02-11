#Ingresar tres ángulos y determinar si pueden formar un triángulo.
angulo1 = float(input("Ingresa el primer ángulo: "))
angulo2 = float(input("Ingresa el segundo ángulo: "))
angulo3 = float(input("Ingresa el tercer ángulo: "))
if angulo1 + angulo2 + angulo3 == 180:
    print("Los ángulos pueden formar un triángulo")
else:
    print("Los ángulos no pueden formar un triángulo")